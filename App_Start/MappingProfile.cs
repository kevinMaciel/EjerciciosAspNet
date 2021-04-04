using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vuelos.Dtos;
using Vuelos.Models;

namespace Vuelos.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Models.Vuelos, VueloDto>();


            // Dto to Domain
            Mapper.CreateMap<VueloDto, Models.Vuelos>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
        

        
    }
}