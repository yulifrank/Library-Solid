using AutoMapper;
using AutoMapper.Execution;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//using Member = Solid.Core.Entities.Member;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LoanDto, Loan>().ReverseMap();
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<MemberDto, Entities.Member>().ReverseMap();
        }
    }
}
