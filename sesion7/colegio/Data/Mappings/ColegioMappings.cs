using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Data.Mappings
{
  using colegio.Models;
  using Microsoft.EntityFrameworkCore;

  public static class ColegioMappings
  {

    public static void Build(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Alumno>(entity =>
      {
        entity.ToTable("Alumnos");
        entity.Property(e => e.Apellidos)
          .IsRequired()
          .HasMaxLength(250);

        entity.Property(e => e.Email).HasMaxLength(250);

        entity.Property(e => e.FechaNacimiento).HasColumnType("date");

        entity.Property(e => e.Nombre)
          .IsRequired()
          .HasMaxLength(250);

        entity.HasOne(d => d.Curso)
          .WithMany(p => p.Alumnos)
          .HasForeignKey(d => d.CursoId)
          .OnDelete(DeleteBehavior.ClientSetNull)
          .HasConstraintName("FK_Alumnos_Cursos");
      });

      modelBuilder.Entity<Aula>(entity =>
      {
        entity.ToTable("Aulas");
        entity.Property(e => e.Descripcion).HasMaxLength(250);
      });

      modelBuilder.Entity<Curso>(entity =>
      {
        entity.ToTable("Cursos");
        entity.Property(e => e.Descripcion).HasMaxLength(250);

        entity.HasOne(d => d.Aula)
          .WithMany(p => p.Cursos)
          .HasForeignKey(d => d.AulaId)
          .HasConstraintName("FK_Cursos_Aulas");
      });

      modelBuilder.Entity<Profesor>(entity =>
      {
        entity.Property(e => e.Apellidos).HasMaxLength(250);

        entity.Property(e => e.Nombre).HasMaxLength(250);

        entity.HasOne(d => d.Curso)
          .WithMany(p => p.Profesor)
          .HasForeignKey(d => d.CursoId)
          .OnDelete(DeleteBehavior.ClientSetNull)
          .HasConstraintName("FK_Profesor_Cursos");
      });
    }
  }
}
