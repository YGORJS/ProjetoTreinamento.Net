using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Treinamento.Globo.Programas.NET.WEB.DAL
{
    public class GloboInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GloboContext>
    {

        protected override void Seed(GloboContext context)
        {

            
            var cargos = new List<Cargo>
            {
                new Cargo {Nome="Cargo especifico",Status=Status.A, DtIncl=DateTime.Parse("2005-09-01") },
                new Cargo {Nome="Cargo Atribuido",Status=Status.I, DtIncl=DateTime.Parse("2005-09-02") },
                new Cargo {Nome="Cargo Excluído",Status=Status.A, DtIncl=DateTime.Parse("2005-09-02") }

            };

            cargos.ForEach(s => context.Cargos.Add(s));
            context.SaveChanges();

    

      


        }



    }
}