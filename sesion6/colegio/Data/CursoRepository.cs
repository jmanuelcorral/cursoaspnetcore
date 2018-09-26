namespace colegio.Data
{
  using Microsoft.EntityFrameworkCore;
  using Models;

  public class CursoRepository : BaseRepository<Curso, int>, IBaseRepository<Curso,int>
  {
   
    public CursoRepository(DataContext context) : base(context)
    {
    }
  }
}