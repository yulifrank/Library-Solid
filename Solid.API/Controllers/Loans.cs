using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.servies.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Loans : ControllerBase
    {



    private readonly ILoanService _loanService;
        public Loans(ILoanService loanService)
        {
            _loanService=loanService;
        }


        // GET: api/<Loans>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok( _loanService.GetLoans());
        }
        // GET api/<Loans>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_loanService.GetById(id));
        }

        // POST api/<Loans>
        [HttpPost]
        public void Post([FromBody] Loan value)
        {
            _loanService.AddLoan(value);
        }

        // PUT api/<Loans>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Loan updatedLoan)
        {
           _loanService.UpdateLoan(id, updatedLoan);
        }

        // DELETE api/<Loans>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _loanService.DeleteLoan(id);
        }
    }
}
