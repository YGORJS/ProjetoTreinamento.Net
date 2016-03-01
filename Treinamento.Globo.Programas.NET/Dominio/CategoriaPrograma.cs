using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  


    public class CategoriaPrograma
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Status ? Status { get; set; }
        public DateTime DtIncl { get; set; }
        public DateTime DtAtlz { get; set; }
        public List<Programa> Programas { get; set; }


    }
}
