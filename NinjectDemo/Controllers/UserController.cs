using Microsoft.AspNetCore.Mvc;
using NinjectDemo.Dependencies;
using NinjectDemo.Domain.Entities.DTOs;
using NinjectDemo.Domain.Interfaces;
using System;

//http://localhost:59214/api/User/Add?name=Test%20Club&Salary=400

namespace NinjectDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        // NORMAL SINGLE INTERFACE WITH ONE IMPLEMENTATION
        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
        //}
        public UserController(Func<ServiceEnum, IUserService> serviceResolver)
        {
            _userService = serviceResolver(ServiceEnum.Window);
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add([FromQuery] UserDTO userDto)
        {
            try
            {
                var message = _userService.Add(userDto);
                return Ok(message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

//https://dejanstojanovic.net/aspnet/2018/december/registering-multiple-implementations-of-the-same-interface-in-aspnet-core/
// Added DI :
//services.AddScoped<IService, ServiceA>();  
//services.AddScoped<IService, ServiceB>();  
//services.AddScoped<IService, ServiceC>();  

//public ValuesController(IService serviceA, IService serviceB, IService serviceC)  
// IMP // ALL 3 HAVE SAME INSTANCE : LAST ONE INJECTED IR SERVICE