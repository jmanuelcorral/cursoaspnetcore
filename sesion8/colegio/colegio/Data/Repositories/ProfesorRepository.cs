namespace colegio.Data.Repositories
{
  using colegio.Data.Contexts;
  using Microsoft.EntityFrameworkCore;
  using Models;

  public class ProfesorRepository : BaseRepository<Profesor, int>, IBaseRepository<Profesor,int>
  {
   
    public ProfesorRepository(DataContext context) : base(context)
    {
    }
  }
}