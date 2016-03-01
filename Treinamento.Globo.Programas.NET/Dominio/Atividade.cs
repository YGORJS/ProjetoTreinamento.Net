using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Atividade
    {
        public int Id { get; set; }
        public int ProgramaId { get; set; }
        public int FuncionarioId { get; set; }

        public virtual Programa programa { get; set; }
        public virtual Funcionario funcionario { get; set; }

    }
}
