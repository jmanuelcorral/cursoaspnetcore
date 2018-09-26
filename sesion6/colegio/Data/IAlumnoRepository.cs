namespace colegio.Data
{
  using System.Collections.Generic;
  using Models;

  public interface IAlumnoRepository : IBaseRepository<Alumno, int>
  {
    List<Alumno> GetAlumnosByCurso(int Curso);
  }
}