using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Tutorial.Dtos.Character;
using API_Tutorial.Models;
using AutoMapper;

namespace API_Tutorial
{
    //Maps for the Mapping
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>(); //Map Character to GetCharacterDto
            CreateMap<AddCharacterDto, Character>(); //Map AddCharacterDto to Character
        }
    }
}
