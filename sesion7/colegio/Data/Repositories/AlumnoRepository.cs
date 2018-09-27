namespace colegio.Data.Repositories
{
  using colegio.Data.Contexts;
  using Models;
  using System.Collections.Generic;
  using System.Linq;

  public class AlumnoRepository : BaseRepository<Alumno, int>, IAlumnoRepository
  {
    public List<Alumno> GetAlumnosByCurso(int Curso)
    {
      return _query.Where(x => x.CursoId == Curso).ToList();
    }

    public AlumnoRepository(DataContext context) : base(context)
    {
    }
  }
}