using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Banda.infra.DataBase.Mappings
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("GRUPO");

            builder.HasKey(x => x.Id)
                    .HasName("PK_GrupoID");

            builder.Property(x => x.Id)
                    .HasColumnName("ID")
                    .HasColumnType("uniqueidentifier");

            builder.Property(x => x.Descricao)
                    .HasColumnName("DESCRICAO")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(50);

            builder.Property(x => x.NomeMusica)
                    .HasColumnName("NOMEMUSICA")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(50);

            builder.Property(x => x.SequenciaMusica)
                    .HasColumnName("SEQUENCIAMUSICA")
                    .HasColumnType("INT")
                    .HasMaxLength(10);
            
        }
    }
}