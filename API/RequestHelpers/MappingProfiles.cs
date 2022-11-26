using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _Deploy.API.DTOs;
using AutoMapper;
using NewStore.API;

namespace _Deploy.API.RequestHelpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}