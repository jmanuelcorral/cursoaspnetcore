namespace colegio.Data.Repositories
{
  using System.Collections.Generic;
  using Models;

  public interface IAlumnoRepository : IBaseRepository<Alumno, int>
  {
    List<Alumno> GetAlumnosByCurso(int Curso);
  }
}