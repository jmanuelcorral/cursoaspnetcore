namespace colegio.Data.Repositories
{
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using Models;

  public interface IAlumnoRepository : IBaseRepository<Alumno, int>
  {
    List<Alumno> GetAlumnosByCurso(int Curso);
    Task<List<Alumno>> GetFullAlumnosCurso();
    Task<List<AlumnoCursoAula>> GetAlumnoCursoAula();
  }
}