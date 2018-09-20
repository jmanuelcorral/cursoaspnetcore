using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Data
{
  using Microsoft.EntityFrameworkCore;
  using Models;

  public class DataContext : DbContext
  {

    public DbSet<Alumno> Alumnos { get; set; }
    public DbSet<Curso> Cursos { get; set; }

  }
}
