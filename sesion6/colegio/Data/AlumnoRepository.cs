namespace colegio.Data
{
  using System.Collections.Generic;
  using System.Linq;
  using Microsoft.EntityFrameworkCore;
  using Models;

  public class AlumnoRepository : BaseRepository<Alumno, int>, IAlumnoRepository
  {
    public List<Alumno> GetAlumnosByCurso(int Curso)
    {
      return _query.Where(x => x.cursos == Curso).ToList();
    }

    public AlumnoRepository(DataContext context) : base(context)
    {
    }
  }
}