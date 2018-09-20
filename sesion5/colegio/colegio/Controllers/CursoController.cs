namespace colegio.Controllers
{
  using System.Collections.Generic;
  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;
  using Swashbuckle.AspNetCore.SwaggerGen;
  using Models;

  [Route("api/[controller]")]
  [ApiController]
  public class CursoController : ColegioBaseController<Curso>
  {
    public CursoController(List<Curso> dependency) : base(dependency)
    {
    }
  }
}