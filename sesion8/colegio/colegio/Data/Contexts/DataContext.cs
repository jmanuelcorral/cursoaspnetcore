namespace colegio.Data.Contexts
{
  using Mappings;
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

    public DbQuery<AlumnoCursoAula> VAlumnoCursoAula { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      ColegioMappings.Build(modelBuilder);
      base.OnModelCreating(modelBuilder);
    }
  }
}
