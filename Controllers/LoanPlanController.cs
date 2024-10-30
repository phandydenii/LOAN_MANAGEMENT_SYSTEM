using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOAN_MANAGEMENT_API.DTO;
using Microsoft.AspNetCore.Mvc;
using Namespace;
//using LOAN_MANAGEMENT_API.Models;

namespace LOAN_MANAGEMENT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanPlanController : ControllerBase
    {
        private readonly ILoanPlan _service;
        public LoanPlanController(ILoanPlan service)
        {
            _service = service;
        }

        [HttpGet("loan-plans")]
        public ActionResult Get()
        {
            var data = _service.GetAll()!;
            if (data != null)
            {
                return Ok(new { data = data, });
            }
            return Ok(new { data = "Data not found", });
        }

        [HttpGet("loan-plan/{id}")]
        public ActionResult GetById(int id)
        {
            var data = _service.GetById(id)!;
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPost("loan-plan-post")]
        public ActionResult Post(LoanPlanDto req)
        {
            var data = _service.Create(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPut("loan-plan-put")]
        public IActionResult Put(LoanPlanDto req)
        {
            var data = _service.Update(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpDelete("loan-plan-delete/{id}")]
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