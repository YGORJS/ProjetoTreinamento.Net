using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Funcionario : Pessoa
    {
        public string Matricula { get; set; }
        public Status ? Status { get; set; }
        public int CargoId { get; set; }

        public virtual Cargo cargo { get; set; }

        //tem q botar a fk de cargo




        public Funcionario(int Id, string Nome, DateTime DtNasc, string Cpf, string Estado, string Cidade, string Endereco, DateTime DtIncl, DateTime DtAtlz, string Matricula, Status Status, int CargoId, Cargo cargo) : base (Id,Nome,DtNasc, Cpf, Estado, Cidade, Endereco, DtIncl, DtAtlz )
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
            this.Matricula = Matricula;
            this.Status = Status;
            this.CargoId = CargoId;
            this.cargo = cargo;


        }

        public Funcionario()
        {

        }




    }
}
