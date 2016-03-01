using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telespectador : Pessoa
    {
        public string Descricao { get; set; }
        public List<Comentario> Comentarios { get; set; }



        public Telespectador(int Id, string Nome, DateTime DtNasc, string Cpf, string Estado, string Cidade, string Endereco, DateTime DtIncl, DateTime DtAtlz, string Descricao, List<Comentario> Comentarios) : base (Id,Nome,DtNasc, Cpf, Estado, Cidade, Endereco, DtIncl, DtAtlz )
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
            this.Descricao = Descricao;
            this.Comentarios = Comentarios;


        }
       

    }
}
