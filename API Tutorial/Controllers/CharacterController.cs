using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Tutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Tutorial.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters[id]);
        }
    }
}
