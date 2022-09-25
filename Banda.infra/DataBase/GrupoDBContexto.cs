using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.Models;
using Banda.infra.DataBase.Mappings;
using Microsoft.EntityFrameworkCore;


namespace Banda.infra.DataBase
{
    public class GrupoDBContexto : DbContext
    {
        public DbSet<Grupo> Grupos {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=GrupoDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new GrupoMap());
        }
    }
}