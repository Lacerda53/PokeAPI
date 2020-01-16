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
        public List<Pokemon> Pokemons = new List<Pokemon>()
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
            },//1
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
            },//2
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
            },//3
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
            },//4
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
            },//5
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
            },//6
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
            },//7
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
            },//8
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
            },//9
            new Pokemon
            {
               Id = 10,
               Nome= "Caterpie",
               Imagem= "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/010.png",
               Sobre= "Caterpie tem um apetite voraz. Ele pode devorar folhas maiores que seu corpo diante dos seus olhos. De sua antena, este Pokémon libera um odor terrivelmente forte.",
               CorFundo= "#74A465",
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
               CorFundo= "#74A465",
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
               CorFundo= "#74A465",
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
               CorFundo= "#74A465",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
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
               CorFundo= "#74A465",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
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
               CorFundo= "#74A465",
                TipoPoke = new List<Tipo>()
                {
                   new Tipo { TipoPoke="Planta"},
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#BDBBA5",
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
               CorFundo= "#9448D0",
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
               CorFundo= "#9448D0",
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
               CorFundo= "#FFCE4B",
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
               CorFundo= "#FFCE4B",
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
               CorFundo= "#D0A248",
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
               CorFundo= "#D0A248",
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
               CorFundo= "#9448D0",
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
               CorFundo= "#9448D0",
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
               CorFundo= "#9448D0",
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
        };

        public IEnumerable<Pokemon> ListarPokemons()
        {
            return Pokemons;
        }
    }
}
