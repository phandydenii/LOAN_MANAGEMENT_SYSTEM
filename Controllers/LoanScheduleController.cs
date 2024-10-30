using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.AspNetCore.Mvc;
using Namespace;
//using LOAN_MANAGEMENT_API.Models;

namespace LOAN_MANAGEMENT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanScheduleController : ControllerBase
    {
         private readonly ILoanSchedule _service;
        public LoanScheduleController(ILoanSchedule service)
        {
            _service = service;
        }

        [HttpGet("loan-schedules")]
        public ActionResult Get()
        {
            var data = _service.GetAll()!;
            if (data != null)
            {
                return Ok(new { data = data, });
            }
            return Ok(new { data = "Data not found", });
        }

        [HttpGet("loan-schedules/{id}")]
        public ActionResult GetById(int id)
        {
            var data = _service.GetById(id)!;
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPost("loan-schedules-post")]
        public ActionResult Post(LoanScheduleDto req)
        {
            var data = _service.Create(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPut("loan-schedules-put")]
        public IActionResult Put(LoanScheduleDto req)
        {
            var data = _service.Update(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpDelete("loan-schedules-delete/{id}")]
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