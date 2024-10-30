using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOAN_MANAGEMENT_API.DTO;
using LOAN_MANAGEMENT_API.Model;
using LOAN_MANAGEMENT_API.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LOAN_MANAGEMENT_API.Controllers
{
    [Route("api/[controller]")]
    public class LoanTypesController : Controller
    {
        private readonly ILoanType _service;
        public LoanTypesController(ILoanType service)
        {
            _service = service;
        }
        [HttpGet("loan-types")]
        public ActionResult Get()
        {
             var data = _service.GetAll()!;
            if (data != null)
            {
                return Ok(new { data = data, });
            }
            return Ok(new { data = "Data not found", });
        }

        [HttpGet("loan-type/{id}")]
        public ActionResult Get(int id)
        {
            var data = _service.GetById(id)!;
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPost("loan-type-post")]
        public ActionResult Post([FromBody] LoanTypeDto req)
        {
             var data = _service.Create(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

         [HttpPut("loan-type-put")]
        public IActionResult Put(LoanTypeDto req)
        {
            var data = _service.Update(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpDelete("loan-type-delete/{id}")]
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

