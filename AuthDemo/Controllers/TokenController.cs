using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using AuthDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AuthDemo.Controllers
{
    // 3rd step - Controller for issuing token
    [Route("Token")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config;
        }

        private readonly Dictionary<string, string> _userDictionary = new Dictionary<string, string>
        {
            {"bill", "1234"},
            {"john", "abcd"}
        };

        private bool ValidateUser(string username, string password)
        {
            if (!_userDictionary.ContainsKey(username))
            {
                return false;
            }

            return _userDictionary[username].Equals(password);
        }

        // 4th - Method which returns token
        [HttpPost]
        public IActionResult Create([FromBody] LoginModel loginModel)
        {
            if (!ValidateUser(loginModel.Username, loginModel.Password))
            {
                return Unauthorized();
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // token creating
            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds,
                claims: new List<Claim>
                {
                    new Claim("MembershipId", "123"),
                    new Claim("Role", "Admin")
                });

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { token = tokenString});
        }
    }
}