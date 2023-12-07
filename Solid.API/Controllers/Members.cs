using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using System.Runtime.Serialization.DataContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Members : ControllerBase
    {
      private readonly IMemberService _memberService;
        public Members(IMemberService memberService)
        {
            _memberService = memberService;
        }
        // GET: api/<Member>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_memberService.GetMembers());
        }

        // GET api/<Member>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_memberService.GetById(id));
        }

        // POST api/<Member>
        [HttpPost]
        public void Post([FromBody] Member value)
        {
            _memberService.AddMember(value);
        }

        // PUT api/<Member>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Member ? updatedMember)
        {
            _memberService.UpdateMember(id, updatedMember); 
        }
        // DELETE api/<Member>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _memberService.DeleteMember(id);
        }
    }
}
