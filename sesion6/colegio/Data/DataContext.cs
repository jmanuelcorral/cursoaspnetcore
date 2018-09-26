using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using colegio.Models;

namespace colegio.Data
{
  using Microsoft.EntityFrameworkCore;
  using Models;

  public class DataContext : DbContext
  {

    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Alumno> Alumnos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Profesor> Profesores { get; set; }

    public DbSet<Aula> Aulas { get; set; }

  }
}
