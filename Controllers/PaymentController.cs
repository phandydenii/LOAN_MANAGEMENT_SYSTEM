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
    public class PaymentController : ControllerBase
    {
         private readonly IPayment _service;
        public PaymentController(IPayment service)
        {
            _service = service;
        }
        [HttpGet("payments")]
        public ActionResult Get()
        {
             var data = _service.GetAll()!;
            if (data != null)
            {
                return Ok(new { data = data, });
            }
            return Ok(new { data = "Data not found", });
        }

        [HttpGet("payment/{id}")]
        public ActionResult Get(int id)
        {
            var data = _service.GetById(id)!;
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpPost("payment-post")]
        public ActionResult Post([FromBody] PaymentDto req)
        {
             var data = _service.Create(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

         [HttpPut("payment-put")]
        public IActionResult Put(PaymentDto req)
        {
            var data = _service.Update(req);
            if (data != null)
            {
                return Ok(new { data = data });
            }
            return NotFound();
        }

        [HttpDelete("payment-delete/{id}")]
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