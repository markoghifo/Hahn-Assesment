using AutoMapper;
using Business.Entities;
using Business.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helpers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreateCategoryDTO, Category>().ReverseMap();
        }
    }
}
