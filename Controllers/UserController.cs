using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using LOAN_MANAGEMENT_API.Model;
using LOAN_MANAGEMENT_API.Model.Req;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.AspNetCore.Mvc;
//using LOAN_MANAGEMENT_API.Models;

namespace LOAN_MANAGEMENT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _service;
        public UserController(IUser service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public ActionResult GetTModels([FromBody] UserLoginReq req)
        {
            var data = _service.Login(req);
            if (data != null)
            {
                return Ok(new
                {
                    data
                });
            }
            return BadRequest(new
            {
                code = 400,
                message = "Username or password is incorrect"
            });
        }
        [HttpPost("register")]
        public ActionResult Reister([FromBody] User req)
        {
            var data = _service.Register(req);
            if (data != null)
            {
                return Ok(new
                {
                    data
                });
            }
            return BadRequest(new
            {
                code = 400,
                message = "Username or password is incorrect"
            });
        }

    }
}