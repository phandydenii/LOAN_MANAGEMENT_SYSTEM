using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoan _service;
        public LoanController(ILoan service)
        {
            _service = service;
        }
        [HttpGet("loans")]
        public ActionResult Get()
        {
             var data = _service.GetAll()!;
            if (data != null)
            {
                return Ok(new { data = data, });
            }
            return Ok(new { data = "Data not found", });
        }

        [HttpGet("loan/{id}")]
        public ActionResult Get(int id)
        {
            var data = _service.GetById(id)!;
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPost("loan-post")]
        public ActionResult Post([FromBody] LoanDto req)
        {
             var data = _service.Create(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

         [HttpPut("loan-put")]
        public IActionResult Put(LoanDto req)
        {
            var data = _service.Update(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpDelete("loan-delete/{id}")]
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