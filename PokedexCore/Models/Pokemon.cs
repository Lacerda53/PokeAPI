using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public string CorFundo { get; set; }
        public IEnumerable<Tipo> TipoPoke { get; set; }
        public IEnumerable<Fraqueza> FraquezaPoke { get; set; }
        public IEnumerable<Evolucao> EvolucaoPoke { get; set; }
        public string Sobre { get; set; }
    }
}
