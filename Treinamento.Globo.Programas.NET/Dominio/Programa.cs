using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Programa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Horario { get; set; }
        public DateTime DtIncl { get; set; }
        public DateTime DtAtlz { get; set; }
        public Status ? Status { get; set; }
        public int CategoriaProgramaId { get; set; }
        public virtual CategoriaPrograma CategoriaPrograma { get; set; }
        public List<Artista> Artistas { get; set; }

    }

}