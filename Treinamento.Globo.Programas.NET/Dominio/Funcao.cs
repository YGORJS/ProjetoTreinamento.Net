using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Funcao
    {
        public int Id { get; set; }
        public int CargoID { get; set; }
        public int FuncionarioID { get; set; }

        public virtual Cargo cargo { get; set; }
        public virtual Funcionario funcionario { get; set; }

    }
}
