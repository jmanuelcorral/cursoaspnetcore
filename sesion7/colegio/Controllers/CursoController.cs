namespace colegio.Controllers
{
  using Data.Repositories;
  using Microsoft.AspNetCore.Mvc;
  using Models;

  [Route("api/[controller]")]
  [ApiController]
  public class CursoController : ColegioBaseController<Curso, int>
  {
    public CursoController(IBaseRepository<Curso, int> dependency) : base(dependency)
    {
    }
  }
}