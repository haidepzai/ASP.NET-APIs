﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Tutorial.Dtos.Character;
using API_Tutorial.Models;
using AutoMapper;

namespace API_Tutorial.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(), //ID Standard 0
            new Character { Id = 1, Name = "Sam"}
        };

        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        //Task für asynchronous Calls
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>(); //Enthält die Daten + Success Message
            Character character = _mapper.Map<Character>(newCharacter); //Map Dto into Character
            character.Id = characters.Max(c => c.Id) + 1; //Sucht die höchste ID und addiert 1
            characters.Add(character);
            serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList(); //list of Characters
            return serviceResponse; //List
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            ServiceResponse<List<GetCharacterDto>> serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = (characters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = new ServiceResponse<GetCharacterDto>();
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
            return serviceResponse;
        }
    }
}
