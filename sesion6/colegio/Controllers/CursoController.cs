namespace colegio.Controllers
{
  using System.Collections.Generic;
  using Data;
  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;
  using Swashbuckle.AspNetCore.SwaggerGen;
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