using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Models;
using PokedexCore.Services;
using PokedexCore.Services.Core;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokedexController : ControllerBase
    {
        private readonly IPokemonService _pokemonServices;
        public PokedexController(IPokemonService pokemonService)
        {
            _pokemonServices = pokemonService;
        }
        // GET: api/Pokedex
        [HttpGet]
        public IEnumerable<Pokemon> ListarPokemons()
        {
            return _pokemonServices.ListarPokemons();
        }

        // GET: api/Pokedex/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Pokemon> BuscarPorId(int id)
        {
            return _pokemonServices.ListarPokemons().Where(item => item.Id == id);
        }

        // POST: api/Pokedex
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
