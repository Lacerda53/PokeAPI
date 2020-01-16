using PokedexAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexCore.Services.Core
{
    public interface IPokemonService
    {
        IEnumerable<Pokemon> ListarPokemons();
    }
}
