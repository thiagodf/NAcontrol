﻿using NAControl.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace NAControl.Infraestructure.Data.Map
{
    class UsuarioMapa: EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapa()
        {
            ToTable("Usuario");

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(160)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_EMAIL", 1) { IsUnique = true }))
                .IsRequired();

            Property(x => x.Senha)
                .HasMaxLength(32)
                .IsFixedLength();
        }
    }
}
