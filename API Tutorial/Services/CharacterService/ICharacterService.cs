using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Tutorial.Dtos.Character;
using API_Tutorial.Models;

namespace API_Tutorial.Services.CharacterService
{
    public interface ICharacterService
    {
        //Task für asynchronous Calls
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

    }
}
