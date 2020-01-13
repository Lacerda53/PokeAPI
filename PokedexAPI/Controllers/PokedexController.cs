using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Models;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokedexController : ControllerBase
    {
        List<Pokemon> ListaPokemons = new List<Pokemon>()
        {
            new Pokemon
            {
               Id = 1,
               Nome= "Bulbasaur",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png",
               TipoPoke = new List<Tipo>()
                {
                   new Tipo {TipoPoke="Grama"},
                   new Tipo {TipoPoke = "Venenoso" } },
               Sobre= "Bulbasaur pode ser visto cochilando sob a luz do sol. Há uma semente nas costas. Ao absorver os raios do sol, a semente cresce progressivamente maior.",
               CorFundo= "#48D0B0",
                FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=1, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png", Name="Bulbasaur"},
                   new Evolucao { Id=2, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png", Name="Ivysaur"},
                   new Evolucao { Id=3, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/003.png", Name="Venusaur"},
               }
            },
            new Pokemon
            {
               Id = 2,
               Nome= "Ivysaur",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png",
               Sobre= "Há um botão nas costas deste Pokémon. Para suportar seu peso, as pernas e o tronco de Ivysaur ficam grossos e " +
                "fortes. Se começar a passar mais tempo deitado sob a luz do sol, é um sinal de que o broto florescerá em uma flor grande em breve.",
               CorFundo= "#48D0B0",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Grama"},
                   new Tipo { TipoPoke = "Venenoso" } },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=1, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png", Name="Bulbasaur"},
                   new Evolucao { Id=2, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png", Name="Ivysaur"},
                   new Evolucao { Id=3, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/003.png", Name="Venusaur"},
               }
            },
            new Pokemon
            {
               Id = 3,
               Nome= "Venusaur",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/003.png",
               Sobre= "Há uma flor grande nas costas de Venusaur. Diz-se que a flor adquire cores vivas se receber muita nutrição e luz solar. " +
                "O aroma da flor acalma as emoções das pessoas.",
               CorFundo= "#48D0B0",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Grama"},
                   new Tipo { TipoPoke = "Venenoso" } },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=1, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png", Name="Bulbasaur"},
                   new Evolucao { Id=2, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png", Name="Ivysaur"},
                   new Evolucao { Id=3, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/003.png", Name="Venusaur"},
               }
            },
            new Pokemon
            {
               Id = 4,
               Nome= "Charmander",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/004.png",
               Sobre= "A chama que queima na ponta da cauda é uma indicação de suas emoções. A chama tremula quando Charmander está se divertindo. " +
                "Se o Pokémon se enfurecer, a chama queima ferozmente.",
               CorFundo= "#FB6C6C",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Fogo"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
                   new Fraqueza { FraquezaPoke= "Água"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=4, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/004.png", Name="Charmander"},
                   new Evolucao { Id=5, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/005.png", Name="Charmeleon"},
                   new Evolucao { Id=6, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png", Name="Charizard"},
               }
            },
            new Pokemon
            {
               Id = 5,
               Nome= "Charmeleon",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/005.png",
               Sobre= "Charmeleon impiedosamente destrói seus inimigos usando suas garras afiadas. " +
                "Se encontrar um inimigo forte, ele se torna agressivo. Nesse estado excitado, a chama na ponta de sua cauda brilha com uma cor branca azulada.",
               CorFundo= "#FB6C6C",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Fogo"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
                   new Fraqueza { FraquezaPoke= "Água"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=4, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/004.png", Name="Charmander"},
                   new Evolucao { Id=5, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/005.png", Name="Charmeleon"},
                   new Evolucao { Id=6, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png", Name="Charizard"},
               }
            },
            new Pokemon
            {
               Id = 6,
               Nome= "Charizard",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png",
               Sobre= "Charizard voa pelo céu em busca de oponentes poderosos. Ele respira um calor tão grande que derrete qualquer coisa. " +
                 "No entanto, nunca dá um sopro ardente a qualquer oponente mais fraco que ele.",
               CorFundo= "#FB6C6C",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Fogo"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Água"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=4, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/004.png", Name="Charmander"},
                   new Evolucao { Id=5, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/005.png", Name="Charmeleon"},
                   new Evolucao { Id=6, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png", Name="Charizard"},
               }
            },
            new Pokemon
            {
               Id = 7,
               Nome= "Squirtle",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/007.png",
               Sobre= "A concha de Squirtle não é apenas usada para proteção. A forma arredondada da concha e as " +
                "ranhuras na superfície ajudam a minimizar a resistência na água, permitindo que este Pokémon nade em alta velocidade.",
               CorFundo= "#77BDFE",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Água"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Planta"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=7, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/007.png", Name="Squirtle"},
                   new Evolucao { Id=8, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/008.png", Name="Wartortle"},
                   new Evolucao { Id=9, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/009.png", Name="Blastoise"},
               }
            },
            new Pokemon
            {
               Id = 8,
               Nome= "Wartortle",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/008.png",
               Sobre= "Sua cauda é grande e coberta com um pêlo rico e grosso. A cauda torna-se cada vez mais profunda na cor à " +
                "medida que Wartortle envelhece. Os arranhões em sua concha são uma evidência da dureza deste Pokémon como um lutador.",
               CorFundo= "#77BDFE",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Água"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Planta"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=7, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/007.png", Name="Squirtle"},
                   new Evolucao { Id=8, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/008.png", Name="Wartortle"},
                   new Evolucao { Id=9, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/009.png", Name="Blastoise"},
               }
            },
            new Pokemon
            {
               Id = 9,
               Nome= "Blastoise",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/009.png",
               Sobre= "Blastoise tem bicos de água que se projetam de sua concha. Os bicos de água são muito precisos. Eles podem disparar balas de água com precisão suficiente para atingir latas vazias a uma distância de mais de 60 metros.",
               CorFundo= "#77BDFE",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Água"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Planta"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=7, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/007.png", Name="Squirtle"},
                   new Evolucao { Id=8, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/008.png", Name="Wartortle"},
                   new Evolucao { Id=9, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/009.png", Name="Blastoise"},
               }
            },
            new Pokemon
            {
               Id = 10,
               Nome= "Caterpie",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/010.png",
               Sobre= "Caterpie tem um apetite voraz. Ele pode devorar folhas maiores que seu corpo diante dos seus olhos. De sua antena, este Pokémon libera um odor terrivelmente forte.",
               CorFundo= "#C5D048",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=10, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/010.png", Name="Caterpie"},
                   new Evolucao { Id=11, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/011.png", Name="Metapod"},
                   new Evolucao { Id=12, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/012.png", Name="Butterfree"},
               }
            },
            new Pokemon
            {
               Id = 11,
               Nome= "Metapod",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/011.png",
               Sobre= "A concha que cobre o corpo deste Pokémon é tão dura quanto uma laje de ferro. Metapod não se move muito. Ele fica parado porque está preparando suas entranhas suaves para a evolução dentro da casca dura.",
               CorFundo= "#C5D048",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=10, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/010.png", Name="Caterpie"},
                   new Evolucao { Id=11, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/011.png", Name="Metapod"},
                   new Evolucao { Id=12, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/012.png", Name="Butterfree"},
               }
            },
            new Pokemon
            {
               Id = 12,
               Nome= "Butterfree",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/012.png",
               Sobre= "Butterfree tem uma capacidade superior para procurar mel delicioso de flores. Pode até procurar, extrair e transportar mel de flores que estão desabrochando a mais de 10 quilômetros do ninho.",
               CorFundo= "#C5D048",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Pedra"},
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=10, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/010.png", Name="Caterpie"},
                   new Evolucao { Id=11, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/011.png", Name="Metapod"},
                   new Evolucao { Id=12, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/012.png", Name="Butterfree"},
               }
            },
        };
        // GET: api/Pokedex
        [HttpGet]
        public IEnumerable<Pokemon> ListarPokemons()
        {
            return ListaPokemons;
        }

        // GET: api/Pokedex/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Pokemon> BuscarPorId(int id)
        {
            return ListaPokemons.Where(item => item.Id == id);
        }

        // POST: api/Pokedex
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
