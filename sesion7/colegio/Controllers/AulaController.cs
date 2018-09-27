namespace colegio.Controllers
{
  using Data.Repositories;
  using Microsoft.AspNetCore.Mvc;
  using Models;

  [Route("api/[controller]")]
  [ApiController]
  public class AulaController : ColegioBaseController<Aula, int>
  {
    public AulaController(IBaseRepository<Aula, int> dependency) : base(dependency)
    {
    }
  }
}