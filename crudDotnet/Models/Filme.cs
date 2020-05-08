using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDotnet.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string FilmeNome { get; set; }
        public string FilmeSinopse { get; set; }
        public int FilmeAnoLancamento { get; set; }
        public int FilmeImdb { get; set; }
        public string FilmeUrlImg { get; set; }
    }
}
