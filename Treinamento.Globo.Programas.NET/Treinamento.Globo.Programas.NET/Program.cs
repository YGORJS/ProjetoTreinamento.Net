using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento.Globo.Programas.NET
{
    class Program
    {
        static void Main(string[] args)
        {

            Cargo cargo = new Cargo();
            cargo.Nome = "Cargo 1";
            Console.WriteLine(cargo.Nome);
            Console.ReadKey();

            CategoriaPrograma cat = new CategoriaPrograma();
            var c = cat.Programas.FindAll(a => a.Id == 1);
        }
    }
}
