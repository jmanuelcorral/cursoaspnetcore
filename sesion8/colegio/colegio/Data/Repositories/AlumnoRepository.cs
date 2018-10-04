namespace colegio.Data.Repositories
{
  using colegio.Data.Contexts;
  using Microsoft.EntityFrameworkCore;
  using Models;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;

  public class AlumnoRepository : BaseRepository<Alumno, int>, IAlumnoRepository
  {
    private readonly DataContext _concreteContext;
    public List<Alumno> GetAlumnosByCurso(int Curso)
    {
      return _query.Where(x => x.CursoId == Curso).ToList();
    }

    public Task<List<Alumno>> GetFullAlumnosCurso()
    {
      return _query.Include("Curso").ToListAsync();
    }

    public Task<List<AlumnoCursoAula>> GetAlumnoCursoAula()
    {
      return _concreteContext.VAlumnoCursoAula.ToListAsync();
    }

    public AlumnoRepository(DataContext context) : base(context)
    {
      _concreteContext = context;
    }
  }
}