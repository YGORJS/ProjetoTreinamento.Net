using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public DateTime? DtIncl { get; set; }
        public DateTime? DtAtlz { get; set; }

        public Pessoa(int Id, string Nome, DateTime DtNasc, string Cpf, string Estado, string Cidade, string Endereco, DateTime DtIncl, DateTime DtAtlz)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.DtNasc = DtNasc;
            this.Cpf = Cpf;
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.Endereco = Endereco;
            this.DtIncl = DtIncl;
            this.DtAtlz = DtAtlz;
        }
        public Pessoa()
        {

        }



    }
}
