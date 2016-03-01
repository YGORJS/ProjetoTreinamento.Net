using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Artista : Pessoa
    {
        public string Atividade { get; set; }
        public string Descricao { get; set; }
        public int ProgramaId { get; set; }
        public virtual Programa Programa { get; set; }

        public Artista(int Id, string Nome, DateTime DtNasc, string Cpf, string Estado, string Cidade, string Endereco, DateTime DtIncl, DateTime DtAtlz, string Atividade, string Descricao, int ProgramaId, Programa Programa) : base (Id,Nome,DtNasc, Cpf, Estado, Cidade, Endereco, DtIncl, DtAtlz )
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
            this.Atividade = Atividade;
            this.Descricao = Descricao;
            this.ProgramaId = ProgramaId;
            this.Programa = Programa;

        }

        public Artista()
        {

        }

    }
}
