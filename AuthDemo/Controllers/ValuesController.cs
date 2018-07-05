using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Bll.Dto.User;
using Bll.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : BaseController
    {
        public ValuesController(IMapper mapper, IUserService userService) : base(mapper, userService) { }

        [HttpGet]
        // 5th step
        // Using authorize attribute for restricting access
        [Authorize]
        public IActionResult Get()
        {
            var dict = new Dictionary<string, string>();

            HttpContext.User.Claims.ToList()
                .ForEach(item => dict.Add(item.Type, item.Value));

            return Ok(dict);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        public IActionResult Post()
        {
            var user = new UserCreateDto { Password = "aaaa", Username = "qq rr" };

            UserService.Create(user);

            return Ok();
        }
    }
}
