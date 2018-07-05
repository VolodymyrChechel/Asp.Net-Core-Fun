using AutoMapper;
using Bll.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IMapper Mapper;
        protected IUserService UserService;

        protected BaseController(IMapper mapper, IUserService userService)
        {
            Mapper = mapper;
            UserService = userService;
        }
    }
}