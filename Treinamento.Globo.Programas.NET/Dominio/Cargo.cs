using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;



namespace Dominio
{
    public class Cargo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public Status? Status { get; set; }
        public DateTime? DtIncl { get; set; }
        public DateTime? DtAtlz { get; set; }
        public List<Funcionario>  Funcionarios { get; set; }


    }
}
