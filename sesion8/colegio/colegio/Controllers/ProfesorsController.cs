namespace colegio.Controllers
{
  using colegio.Data.Repositories;
  using Models;

  public class ProfesorsController : ColegioBaseController<Profesor, int>
  {
    public ProfesorsController(IBaseRepository<Profesor, int> dependency) : base(dependency)
    {
    }
  }
}