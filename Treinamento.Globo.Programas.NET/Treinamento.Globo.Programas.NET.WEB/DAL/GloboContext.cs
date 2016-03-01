using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Treinamento.Globo.Programas.NET.WEB.DAL
{
    public class GloboContext : DbContext
    {
        public GloboContext():base("GloboContext")
        {

        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<CategoriaPrograma> CategoriaProgramas { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Atividade> Atividades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Cargo>().HasMany(c => c.Funcionarios); um p muitos
            //modelBuilder.Entity<Cargo>().HasRequired(r => r.Funcionarios); um p muitos com obrigatoriedade , onde cargo deve ter funcionario
        
        }

    }
}