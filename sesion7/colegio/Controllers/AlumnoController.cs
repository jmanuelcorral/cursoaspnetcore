namespace colegio.Controllers
{
  using Data.Repositories;
  using Microsoft.AspNetCore.Mvc;
  using Models;

  [Route("api/[controller]")]
  [ApiController]
  public class AlumnoController : ColegioBaseController<Alumno, int>
  {
    private IAlumnoRepository _concreteRepo;

    public AlumnoController(IAlumnoRepository dependency) : base(dependency)
    {
      _concreteRepo = dependency;
    }

  }
}