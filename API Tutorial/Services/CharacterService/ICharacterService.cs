using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Tutorial.Models;

namespace API_Tutorial.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);

    }
}
