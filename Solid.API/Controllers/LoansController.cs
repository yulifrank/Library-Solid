using AutoMapper;
using AutoMapper.Execution;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using Solid.servies.Services;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {



    private readonly ILoanService _loanService;
        private readonly IMapper _mapper;
        public LoansController(ILoanService loanService, IMapper mapper)
        {
            _loanService=loanService;
            _mapper=mapper;
        }


        // GET: api/<Loans>
        [HttpGet]
        public ActionResult<IEnumerable<LoanDto>> Get()
        {
            var loans = _loanService.GetLoans();
            var loanDtos = _mapper.Map<IEnumerable<LoanDto>>(loans);

            return Ok(loanDtos);
        }
        // GET api/<Loans>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var loan = _loanService.GetById(id);
            //var userDto = _mapping.MapToUserDto(user);
            var loanDto = _mapper.Map<LoanDto>(loan);

            return Ok(loanDto);
        }

        // POST api/<Loans>
        [HttpPost]
        public async Task<Loan> Post([FromBody] LoanPostModel value)
        {
            var loanToAdd=new Loan { Date =value.Date, MemberId =value.MemberId, Name =value.Name};
         return  await _loanService.AddLoanAsync(loanToAdd);
        }

    

        // PUT api/<Loans>/5
        [HttpPut("{id}")]
        public async Task<Loan> Put(int id, [FromBody] Loan updatedLoan)
        {
          return await _loanService.UpdateLoanAsync(id, updatedLoan);
        }

        // DELETE api/<Loans>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await  _loanService.DeleteLoanAsync(id);
        }
    }
}
