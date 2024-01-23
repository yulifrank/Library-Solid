using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.servies.Services;
using System.Runtime.Serialization.DataContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
      private readonly IMemberService _memberService;
        private readonly IMapper _mapper;
        public MembersController(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }
        // GET: api/<Member>
        [HttpGet]
        public ActionResult<IEnumerable<MemberDto>> Get()
        {
            var members = _memberService.GetMembers();
            var memberDtos = _mapper.Map<IEnumerable<MemberDto>>(members);

            return Ok(memberDtos);
        }


        // GET api/<Member>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var member = _memberService.GetById(id);
            //var userDto = _mapping.MapToUserDto(user);
            var memberDto = _mapper.Map<MemberDto>(member);

            return Ok(memberDto);
        }

        // POST api/<Member>
        [HttpPost]
        public async Task<Member> Post([FromBody] MemberPostModel value)
        {
            var memberToAdd=new Member { Age = value.Age , Name=value.Name};
          return await _memberService.AddMemberAsync(memberToAdd);
        }
       


        // PUT api/<Member>/5
        [HttpPut("{id}")]
        public async Task<Member> Put(int id, [FromBody] Member ? updatedMember)
        {
          return await  _memberService.UpdateMemberAsync(id, updatedMember); 
        }
        // DELETE api/<Member>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
          await  _memberService.DeleteMemberAsync(id);
        }
    }
}
