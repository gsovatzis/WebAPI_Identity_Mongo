using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Identity_Mongo.DTOs;
using WebAPI_Identity_Mongo.Models.Identity;

namespace WebAPI_Identity_Mongo.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Place your mappings here to be loaded from DI
            CreateMap<MyUser, UserDTO>();
            CreateMap<UserDTO, MyUser>();
        }
    }
}
