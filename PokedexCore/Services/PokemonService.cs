using PokedexAPI.Models;
using PokedexCore.Services.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexCore.Services
{
    public class PokemonService : IPokemonService
    {
        private List<Pokemon> Pokemons;

        public IEnumerable<Pokemon> ListarPokemons()
        {
            var Planta = "#48D0B0";
            var Fogo = "#FB6C6C";
            var Agua = "#77BDFE";
            var Inseto = "#74A465";
            var Normal = "#BDBBA5";
            var Venenoso = "#9448D0";
            var Eletrico = "#FFCE4B";
            var Terra = "#D0A248";
            var Fada = "";

            Pokemons = new List<Pokemon>()
{
            new Pokemon
            {
               Id = 1,
               Nome= "Bulbasaur",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png",
               TipoPoke = new List<Tipo>()
                {
                   new Tipo {TipoPoke="Planta"},
                   new Tipo {TipoPoke = "Venenoso" } },
               Sobre= "Bulbasaur pode ser visto cochilando sob a luz do sol. Há uma semente nas costas. Ao absorver os raios do sol, a semente cresce progressivamente maior.",
               CorFundo= Planta,
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
            },//1
            new Pokemon
            {
               Id = 2,
               Nome= "Ivysaur",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/002.png",
               Sobre= "Há um botão nas costas deste Pokémon. Para suportar seu peso, as pernas e o tronco de Ivysaur ficam grossos e " +
                "fortes. Se começar a passar mais tempo deitado sob a luz do sol, é um sinal de que o broto florescerá em uma flor grande em breve.",
               CorFundo= Planta,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
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
            },//2
            new Pokemon
            {
               Id = 3,
               Nome= "Venusaur",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/003.png",
               Sobre= "Há uma flor grande nas costas de Venusaur. Diz-se que a flor adquire cores vivas se receber muita nutrição e luz solar. " +
                "O aroma da flor acalma as emoções das pessoas.",
               CorFundo= Planta,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
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
            },//3
            new Pokemon
            {
               Id = 4,
               Nome= "Charmander",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/004.png",
               Sobre= "A chama que queima na ponta da cauda é uma indicação de suas emoções. A chama tremula quando Charmander está se divertindo. " +
                "Se o Pokémon se enfurecer, a chama queima ferozmente.",
               CorFundo= Fogo,
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
            },//4
            new Pokemon
            {
               Id = 5,
               Nome= "Charmeleon",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/005.png",
               Sobre= "Charmeleon impiedosamente destrói seus inimigos usando suas garras afiadas. " +
                "Se encontrar um inimigo forte, ele se torna agressivo. Nesse estado excitado, a chama na ponta de sua cauda brilha com uma cor branca azulada.",
               CorFundo= Fogo,
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
            },//5
            new Pokemon
            {
               Id = 6,
               Nome= "Charizard",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/006.png",
               Sobre= "Charizard voa pelo céu em busca de oponentes poderosos. Ele respira um calor tão grande que derrete qualquer coisa. " +
                 "No entanto, nunca dá um sopro ardente a qualquer oponente mais fraco que ele.",
               CorFundo= Fogo,
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
            },//6
            new Pokemon
            {
               Id = 7,
               Nome= "Squirtle",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/007.png",
               Sobre= "A concha de Squirtle não é apenas usada para proteção. A forma arredondada da concha e as " +
                "ranhuras na superfície ajudam a minimizar a resistência na água, permitindo que este Pokémon nade em alta velocidade.",
               CorFundo= Agua,
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
            },//7
            new Pokemon
            {
               Id = 8,
               Nome= "Wartortle",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/008.png",
               Sobre= "Sua cauda é grande e coberta com um pêlo rico e grosso. A cauda torna-se cada vez mais profunda na cor à " +
                "medida que Wartortle envelhece. Os arranhões em sua concha são uma evidência da dureza deste Pokémon como um lutador.",
               CorFundo= Agua,
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
            },//8
            new Pokemon
            {
               Id = 9,
               Nome= "Blastoise",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/009.png",
               Sobre= "Blastoise tem bicos de água que se projetam de sua concha. Os bicos de água são muito precisos. Eles podem disparar balas de água com precisão suficiente para atingir latas vazias a uma distância de mais de 60 metros.",
               CorFundo= Agua,
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
            },//9
            new Pokemon
            {
               Id = 10,
               Nome= "Caterpie",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/010.png",
               Sobre= "Caterpie tem um apetite voraz. Ele pode devorar folhas maiores que seu corpo diante dos seus olhos. De sua antena, este Pokémon libera um odor terrivelmente forte.",
               CorFundo= Inseto,
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
            },//10
            new Pokemon
            {
               Id = 11,
               Nome= "Metapod",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/011.png",
               Sobre= "A concha que cobre o corpo deste Pokémon é tão dura quanto uma laje de ferro. Metapod não se move muito. Ele fica parado porque está preparando suas entranhas suaves para a evolução dentro da casca dura.",
               CorFundo= Inseto,
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
            },//11
            new Pokemon
            {
               Id = 12,
               Nome= "Butterfree",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/012.png",
               Sobre= "Butterfree tem uma capacidade superior para procurar mel delicioso de flores. Pode até procurar, extrair e transportar mel de flores que estão desabrochando a mais de 10 quilômetros do ninho.",
               CorFundo= Inseto,
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
            },//12
            new Pokemon
            {
               Id = 13,
               Nome= "Weedle",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/013.png",
               Sobre= "Weedle tem um olfato extremamente agudo. Ele é capaz de distinguir seus tipos favoritos de folhas daqueles de que não gosta, apenas farejando com sua grande tromba vermelha (nariz).",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=13, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/013.png", Name="Weedle"},
                   new Evolucao { Id=14, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/014.png", Name="Kakuna"},
                   new Evolucao { Id=15, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/015.png", Name="Beedril"},
               }
            },//13
            new Pokemon
            {
               Id = 14,
               Nome= "Kakuna",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/014.png",
               Sobre= "Kakuna permanece praticamente imóvel enquanto se agarra a uma árvore. No entanto, por dentro, é extremamente ocupado, enquanto se prepara para a sua evolução futura. Isso é evidente pelo quão quente a concha fica ao toque.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=13, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/013.png", Name="Weedle"},
                   new Evolucao { Id=14, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/014.png", Name="Kakuna"},
                   new Evolucao { Id=15, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/015.png", Name="Beedril"},
               }
            },//14
            new Pokemon
            {
               Id = 15,
               Nome= "Beedrill",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/015.png",
               Sobre= "Beedrill é extremamente territorial. Ninguém deve se aproximar de seu ninho - isso é para sua própria segurança. Se irritados, eles atacarão em um enxame furioso.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=13, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/013.png", Name="Weedle"},
                   new Evolucao { Id=14, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/014.png", Name="Kakuna"},
                   new Evolucao { Id=15, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/015.png", Name="Beedril"},
               }
            },//15
            new Pokemon
            {
               Id = 16,
               Nome= "Pidgey",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/016.png",
               Sobre= "Pidgey tem um senso de direção extremamente nítido. Ela é capaz de voltar para o seu ninho de forma infalível, por mais longe que possa ser removida de seu ambiente familiar.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=16, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/016.png", Name="Pidgey"},
                   new Evolucao { Id=17, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/017.png", Name="Pidgeotto"},
                   new Evolucao { Id=18, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/018.png", Name="Pidgeot"},
               }
            },//16
            new Pokemon
            {
               Id = 17,
               Nome= "Pidgeotto",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/017.png",
               Sobre= "Pidgeotto reivindica uma grande área como seu próprio território. Este Pokémon voa, patrulhando seu espaço de vida. Se seu território é violado, não mostra piedade de punir completamente o inimigo com suas garras afiadas.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=16, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/016.png", Name="Pidgey"},
                   new Evolucao { Id=17, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/017.png", Name="Pidgeotto"},
                   new Evolucao { Id=18, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/018.png", Name="Pidgeot"},
               }
            },//17
            new Pokemon
            {
               Id = 18,
               Nome= "Pidgeot",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/018.png",
               Sobre= "Este Pokémon tem uma plumagem deslumbrante de penas maravilhosamente brilhantes. Muitos treinadores são cativados pela impressionante beleza das penas em sua cabeça, obrigando-os a escolher Pidgeot como seu Pokémon.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=16, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/016.png", Name="Pidgey"},
                   new Evolucao { Id=17, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/017.png", Name="Pidgeotto"},
                   new Evolucao { Id=18, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/018.png", Name="Pidgeot"},
               }
            },//18
            new Pokemon
            {
               Id = 19,
               Nome= "Rattata",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/019.png",
               Sobre= "Rattata é cauteloso ao extremo. Mesmo dormindo, ouve constantemente movendo os ouvidos. Não é exigente sobre onde vive - fará seu ninho em qualquer lugar.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Lutador"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=19, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/019.png", Name="Rattata"},
                   new Evolucao { Id=20, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/020.png", Name="Raticate"},
               }
            },//19
            new Pokemon
            {
               Id = 20,
               Nome= "Raticate",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/020.png",
               Sobre= "As presas fortes de Raticate crescem constantemente. Para mantê-los triturados, roem pedras e troncos. Pode até mastigar as paredes das casas.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Lutador"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=19, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/019.png", Name="Rattata"},
                   new Evolucao { Id=20, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/020.png", Name="Raticate"},
               }
            },//20
            new Pokemon
            {
               Id = 21,
               Nome= "Spearow",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/021.png",
               Sobre= "Spearow tem um grito muito alto que pode ser ouvido a mais de 800 metros de distância. Se seu grito alto e agudo for ouvido ecoando por toda parte, é um sinal de que eles estão alertando um ao outro sobre o perigo.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Voador"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=21, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/021.png", Name="Spearow"},
                   new Evolucao { Id=22, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/022.png", Name="Fearow"},
               }
            },//21
            new Pokemon
            {
               Id = 22,
               Nome= "Fearow",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/022.png",
               Sobre= "O medo é reconhecido pelo pescoço longo e pelo bico alongado. Eles são convenientemente modelados para capturar presas no solo ou na água. Ele habilmente move seu bico longo e magro para colher presas.",
               CorFundo= Normal,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Voador"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Pedra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=21, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/021.png", Name="Spearow"},
                   new Evolucao { Id=22, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/022.png", Name="Fearow"},
               }
            },//22
            new Pokemon
            {
               Id = 23,
               Nome= "Ekans",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/023.png",
               Sobre= "Ekans se enrola em espiral enquanto descansa. Assumir esta posição permite que ela responda rapidamente a uma ameaça de qualquer direção com um clarão de sua cabeça erguida.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=23, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/023.png", Name="Ekans"},
                   new Evolucao { Id=24, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/024.png", Name="Arbok"},
               }
            },//23
            new Pokemon
            {
               Id = 24,
               Nome= "Arbok",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/024.png",
               Sobre= "Este Pokémon é terrivelmente forte para contrair as coisas com seu corpo. Pode até achatar tambores de óleo de aço. Uma vez que Arbok envolve seu corpo em torno de seu inimigo, é impossível escapar do abraço esmagador.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=23, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/023.png", Name="Ekans"},
                   new Evolucao { Id=24, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/024.png", Name="Arbok"},
               }
            },//24
            new Pokemon
            {
               Id = 25,
               Nome= "Pikachu",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/025.png",
               Sobre= "Sempre que Pikachu se depara com algo novo, ele o explode com um choque elétrico. Se você se deparar com uma baga enegrecida, é evidente que este Pokémon confundiu a intensidade de sua carga.",
               CorFundo= Eletrico,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Elétrico"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=172, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/172.png", Name="Pichu"},
                   new Evolucao { Id=25, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/025.png", Name="Pikachu"},
                   new Evolucao { Id=26, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/026.png", Name="Raichu"},
               }
            },//25
            new Pokemon
            {
               Id = 26,
               Nome= "Raichu",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/026.png",
               Sobre= "Se os sacos elétricos ficarem excessivamente carregados, Raichu plantará sua cauda no chão e descarregará. Pedaços de terra queimados serão encontrados perto do ninho deste Pokémon.",
               CorFundo= Eletrico,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Elétrico"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=172, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/172.png", Name="Pichu"},
                   new Evolucao { Id=25, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/025.png", Name="Pikachu"},
                   new Evolucao { Id=26, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/026.png", Name="Raichu"},
               }
            },//26
            new Pokemon
            {
               Id = 27,
               Nome= "Sandshrew",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/027.png",
               Sobre= "O corpo de Sandshrew está configurado para absorver água sem desperdício, permitindo que ele sobreviva em um deserto árido. Este Pokémon se enrola para se proteger de seus inimigos.",
               CorFundo= Terra,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Terra"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Planta"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Water"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=27, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/017.png", Name="Sandshrew"},
                   new Evolucao { Id=28, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/028.png", Name="Sandslash"}
               }
            },//27
            new Pokemon
            {
               Id = 28,
               Nome= "Sandslash",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/028.png",
               Sobre= "O corpo do Sandslash é coberto por pontas duras, que são seções endurecidas de sua pele. Uma vez por ano, os picos antigos caem, para serem substituídos por novos picos que crescem por baixo dos antigos.",
               CorFundo= Terra,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Terra"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Planta"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Water"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=27, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/017.png", Name="Sandshrew"},
                   new Evolucao { Id=28, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/028.png", Name="Sandslash"}
               }
            },//28
            new Pokemon
            {
               Id = 29,
               Nome= "Nidoran?",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/029.png",
               Sobre= "Nidoran? tem farpas que secretam um poderoso veneno. Pensa-se que eles tenham se desenvolvido como proteção para este Pokémon de corpo pequeno. Quando enfurecido, libera uma toxina horrível do chifre.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=29, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/029.png", Name="Nidoran?"},
                   new Evolucao { Id=30, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/030.png", Name="Nidorina"},
                   new Evolucao { Id=31, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/031.png", Name="Nidoqueen"}
               }
            },//29
            new Pokemon
            {
               Id = 30,
               Nome= "Nidorina",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/030.png",
               Sobre= "Quando Nidorina está com seus amigos ou familiares, eles mantêm suas farpas afastadas para evitar se machucar. Este Pokémon parece ficar nervoso se separado dos outros.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=29, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/029.png", Name="Nidoran?"},
                   new Evolucao { Id=30, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/030.png", Name="Nidorina"},
                   new Evolucao { Id=31, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/031.png", Name="Nidoqueen"}
               }
            },//30
            new Pokemon
            {
               Id = 31,
               Nome= "Nidoqueen",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/031.png",
               Sobre= "O corpo de Nidoqueen é envolto em escamas extremamente duras. É hábil em enviar inimigos voando com agressões severas. Este Pokémon é mais forte quando defende seus filhotes.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
                   new Tipo { TipoPoke="Terra"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Water"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=29, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/029.png", Name="Nidoran?"},
                   new Evolucao { Id=30, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/030.png", Name="Nidorina"},
                   new Evolucao { Id=31, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/031.png", Name="Nidoqueen"}
               }
            },//31
            new Pokemon
            {
               Id = 32,
               Nome= "Nidoran?",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/032.png",
               Sobre= "Nidoran? desenvolveu músculos para mover seus ouvidos. Graças a eles, os ouvidos podem ser movidos livremente em qualquer direção. Mesmo o menor som não escapa à atenção deste Pokémon.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=32, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/032.png", Name="Nidoran?"},
                   new Evolucao { Id=33, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/033.png", Name="Nidorino"},
                   new Evolucao { Id=34, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/034.png", Name="Nodoking"}
               }
            },//32
            new Pokemon
            {
               Id = 33,
               Nome= "Nidorino",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/033.png",
               Sobre= "Nidorino tem um chifre mais duro que um diamante. Se sente uma presença hostil, todas as farpas nas costas se arrepiam de uma só vez e desafia o inimigo com toda a sua força.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=32, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/032.png", Name="Nidoran?"},
                   new Evolucao { Id=33, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/033.png", Name="Nidorino"},
                   new Evolucao { Id=34, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/034.png", Name="Nodoking"}
               }
            },//33
            new Pokemon
            {
               Id = 34,
               Nome= "Nidoking",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/034.png",
               Sobre= "A cauda grossa de Nidoking possui poder enormemente destrutivo. Com um balanço, ele pode derrubar uma torre de transmissão de metal. Uma vez que este Pokémon se agita, não há como detê-lo.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
                   new Tipo { TipoPoke="Terra"},
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Terra"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Água"},
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=32, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/032.png", Name="Nidoran?"},
                   new Evolucao { Id=33, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/033.png", Name="Nidorino"},
                   new Evolucao { Id=34, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/034.png", Name="Nodoking"}
               }
            },//34
            new Pokemon
            {
               Id = 35,
               Nome= "Clefairy",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/035.png",
               Sobre= "Em todas as noites de lua cheia, grupos deste Pokémon aparecem para jogar. Quando o amanhecer chega, os Clefairy cansados voltam para seus retiros tranquilos nas montanhas e vão dormir aninhados um contra o outro.",
               CorFundo= Fada,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Fada"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Metálico"},
                   new Fraqueza { FraquezaPoke= "Venenoso"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=173, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/172.png", Name="Cleffa"},
                   new Evolucao { Id=35, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/035.png", Name="Clefairy"},
                   new Evolucao { Id=36, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/036.png", Name="Clefable"}
               }
            },//35
            new Pokemon
            {
               Id = 36,
               Nome= "Clefable",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/036.png",
               Sobre= "Clefable se move pulando levemente como se estivesse voando usando as asas. Seu passo saltitante permite que ele ande sobre a água. É conhecido por passear em lagos em noites tranquilas e iluminadas pela lua.",
               CorFundo= Fada,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Fada"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Metálico"},
                   new Fraqueza { FraquezaPoke= "Venenoso"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=173, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/172.png", Name="Cleffa"},
                   new Evolucao { Id=35, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/035.png", Name="Clefairy"},
                   new Evolucao { Id=36, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/036.png", Name="Clefable"}
               }
            },//36
            new Pokemon
            {
               Id = 37,
               Nome= "Vulpix",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/037.png",
               Sobre= "No momento do seu nascimento, o Vulpix tinha uma cauda branca. A cauda se separa em seis se este Pokémon receber muito amor de seu treinador. As seis caudas ficam magnificamente enroladas.",
               CorFundo= Fogo,
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
                   new Evolucao { Id=37, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/037.png", Name="Vulpix"},
                   new Evolucao { Id=38, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/038.png", Name="Ninetales"}
               }
            },//37
            new Pokemon
            {
               Id = 38,
               Nome= "Ninetales",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/038.png",
               Sobre= "Ninetales lança uma luz sinistra de seus olhos vermelhos brilhantes para obter controle total sobre a mente de seu inimigo. Diz-se que este Pokémon vive por mil anos.",
               CorFundo= Fogo,
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
                   new Evolucao { Id=37, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/037.png", Name="Vulpix"},
                   new Evolucao { Id=38, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/038.png", Name="Ninetales"}
               }
            },//38
            new Pokemon
            {
               Id = 39,
               Nome= "Jigglypuf",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/039.png",
               Sobre= "As cordas vocais de Jigglypuff podem ajustar livremente o comprimento de onda de sua voz. Este Pokémon usa essa capacidade de cantar exatamente no comprimento de onda certo para deixar seus inimigos mais sonolentos.",
               CorFundo= Fada,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Fada"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Metálico"},
                   new Fraqueza { FraquezaPoke= "Venenoso"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=174, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/174.png", Name="Igglybuff"},
                   new Evolucao { Id=39, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/039.png", Name="Jigglypuf"},
                   new Evolucao { Id=40, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/040.png", Name="Wigglytuff"}
               }
            },//39
            new Pokemon
            {
               Id = 40,
               Nome= "Wigglytuff",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/040.png",
               Sobre= "Wigglytuff tem olhos grandes e parecidos com pires. As superfícies dos olhos estão sempre cobertas por uma fina camada de lágrimas. Se houver poeira nos olhos deste Pokémon, ele é rapidamente lavado.",
               CorFundo= Fada,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Normal"},
                   new Tipo { TipoPoke="Fada"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Metálico"},
                   new Fraqueza { FraquezaPoke= "Venenoso"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=174, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/174.png", Name="Igglybuff"},
                   new Evolucao { Id=39, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/039.png", Name="Jigglypuf"},
                   new Evolucao { Id=40, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/040.png", Name="Wigglytuff"}
               }
            },//40
            new Pokemon
            {
               Id = 41,
               Nome= "Zubat",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/041.png",
               Sobre= "Zubat permanece silenciosamente imóvel em um ponto escuro durante o dia claro. Isso ocorre porque a exposição prolongada ao sol faz com que seu corpo se torne ligeiramente queimado.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=41, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/041.png", Name="Zubat"},
                   new Evolucao { Id=42, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/042.png", Name="Golbat"},
                   new Evolucao { Id=169, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/169.png", Name="Crobat"}
               }
            },//41
            new Pokemon
            {
               Id = 42,
               Nome= "Golbat",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/042.png",
               Sobre= "Golbat adora beber o sangue de seres vivos. É particularmente ativo no escuro da noite. Este Pokémon voa pelo céu noturno, buscando sangue fresco.",
               CorFundo= Venenoso,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Venenoso"},
                   new Tipo { TipoPoke="Voador"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Elétrico"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=41, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/041.png", Name="Zubat"},
                   new Evolucao { Id=42, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/042.png", Name="Golbat"},
                   new Evolucao { Id=169, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/169.png", Name="Crobat"}
               }
            },//42
            new Pokemon
            {
               Id = 43,
               Nome= "Oddish",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/043.png",
               Sobre= "Durante o dia, Oddish se enterra no solo para absorver os nutrientes do solo usando todo o corpo. Quanto mais fértil o solo, mais brilhantes ficam as suas folhas.",
               CorFundo= Planta,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=43, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/043.png", Name="Oddish"},
                   new Evolucao { Id=44, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/044.png", Name="Gloom"},
                   new Evolucao { Id=45, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/045.png", Name="Vileplume"},
                   new Evolucao { Id=182, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/182.png", Name="Bellossom"}
               }
            },//43
            new Pokemon
            {
               Id = 44,
               Nome= "Gloom",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/044.png",
               Sobre= "Gloom libera uma fragrância suja do pistilo de sua flor. Quando confrontado com o perigo, o fedor piora. Se este Pokémon estiver calmo e seguro, ele não liberará seu aroma fedido habitual.",
               CorFundo= Planta,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=43, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/043.png", Name="Oddish"},
                   new Evolucao { Id=44, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/044.png", Name="Gloom"},
                   new Evolucao { Id=45, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/045.png", Name="Vileplume"},
                   new Evolucao { Id=182, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/182.png", Name="Bellossom"}
               }
            },//44
            new Pokemon
            {
               Id = 45,
               Nome= "Vileplume",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/045.png",
               Sobre= "O pólen tóxico de Vileplume desencadeia ataques alérgicos atrozes. É por isso que é aconselhável nunca abordar flores atraentes em uma floresta, por mais bonitas que sejam.",
               CorFundo= Planta,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Psíquico"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=43, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/043.png", Name="Oddish"},
                   new Evolucao { Id=44, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/044.png", Name="Gloom"},
                   new Evolucao { Id=45, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/045.png", Name="Vileplume"},
                   new Evolucao { Id=182, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/182.png", Name="Bellossom"}
               }
            },//45
            new Pokemon
            {
               Id = 46,
               Nome= "Paras",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/046.png",
               Sobre= "Paras tem cogumelos parasitas crescendo nas costas, chamados tochukaso. Eles crescem ao extrair nutrientes deste hospedeiro Pokémon Bug. Eles são altamente valorizados como remédio para prolongar a vida.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Planta"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Inseto"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Venenoso"},
                   new Fraqueza { FraquezaPoke= "Pedra"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=46, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/046.png", Name="Oddish"},
                   new Evolucao { Id=47, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/047.png", Name="Gloom"}
               }
            },//46
            new Pokemon
            {
               Id = 47,
               Nome= "Parasect",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/047.png",
               Sobre= "O parasita é conhecido por infestar grandes árvores em massa e drenar nutrientes do tronco e raízes inferiores. Quando uma árvore infestada morre, elas se movem para outra árvore de uma só vez.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Planta"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Inseto"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Venenoso"},
                   new Fraqueza { FraquezaPoke= "Pedra"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=46, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/046.png", Name="Paras"},
                   new Evolucao { Id=47, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/047.png", Name="Parasect"}
               }
            },//47
            new Pokemon
            {
               Id = 48,
               Nome= "Venonat",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/048.png",
               Sobre= "Diz-se que Venonat evoluiu com uma camada de cabelo fino e rígido que cobre todo o corpo para proteção. Possui olhos grandes que nunca deixam de detectar presas minúsculas.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=48, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/048.png", Name="Venonat"},
                   new Evolucao { Id=49, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/049.png", Name="Venomoth"}
               }
            },//48
            new Pokemon
            {
               Id = 49,
               Nome= "Venomoth",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/049.png",
               Sobre= "Venomoth é noturno - é um Pokémon que só se torna ativo à noite. Suas presas favoritas são pequenos insetos que se reúnem em torno das luzes da rua, atraídos pela luz na escuridão.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Inseto"},
                   new Tipo { TipoPoke="Venenoso"}
               },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Fogo"},
                   new Fraqueza { FraquezaPoke= "Voador"},
                   new Fraqueza { FraquezaPoke= "Psíquico"},
                   new Fraqueza { FraquezaPoke= "Pedra"}
               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=48, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/048.png", Name="Venonat"},
                   new Evolucao { Id=49, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/049.png", Name="Venomoth"}
               }
            },//49
            new Pokemon
            {
               Id = 50,
               Nome= "Diglett",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/050.png",
               Sobre= "Venomoth é noturno - é um Pokémon que só se torna ativo à noite. Suas presas favoritas são pequenos insetos que se reúnem em torno das luzes da rua, atraídos pela luz na escuridão.",
               CorFundo= Inseto,
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Terra"}
                },
               FraquezaPoke = new List<Fraqueza>()
               {
                   new Fraqueza { FraquezaPoke= "Planta"},
                   new Fraqueza { FraquezaPoke= "Gelo"},
                   new Fraqueza { FraquezaPoke= "Água"},

               },
               EvolucaoPoke = new List<Evolucao>()
               {
                   new Evolucao { Id=50, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/048.png", Name="Diglett"},
                   new Evolucao { Id=51, Imagem="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/049.png", Name="Dugtrio"}
               }
            },//50
        };

            return Pokemons;
        }
    }
}
