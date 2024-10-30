using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Namespace;
//using LOAN_MANAGEMENT_API.Models;

namespace LOAN_MANAGEMENT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class BorrowController : ControllerBase
    {
        private readonly IBorrow _service;
        public BorrowController(IBorrow service)
        {
            _service = service;
        }

        [Authorize]
        [AllowAnonymous]
        [HttpGet("borrows")]
        public ActionResult Get()
        {
            var data = _service.GetAll()!;
            if (data != null)
            {
                return Ok(new { data = data, });
            }
            return Ok(new { data = "Data not found", });
        }

        [HttpGet("borrow/{id}")]
        public ActionResult GetById(int id)
        {
            var data = _service.GetById(id)!;
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPost("borrow-post")]
        public ActionResult Post(BorrowDto req)
        {
            var data = _service.Create(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPut("borrow-put")]
        public IActionResult Put(BorrowDto req)
        {
            var data = _service.Update(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpDelete("borrow-delete/{id}")]
        public ActionResult Delete(int id)
        {
            var data = _service.Remove(id);
            if (data)
            {
                return Ok(new { ok = true });
            }
            return NotFound();
        }
    }
}