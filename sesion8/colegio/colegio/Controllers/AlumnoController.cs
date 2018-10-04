namespace colegio.Controllers
{
  using Data.Repositories;
  using Microsoft.AspNetCore.Mvc;
  using Models;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  [Route("api/[controller]")]
  [ApiController]
  public class AlumnoController : ColegioBaseController<Alumno, int>
  {
    private IAlumnoRepository _concreteRepo;

    public AlumnoController(IAlumnoRepository dependency) : base(dependency)
    {
      _concreteRepo = dependency;
    }

    [HttpGet]
    [Route("withcurso")]
    public async Task<ActionResult<IEnumerable<Alumno>>> GetFull()
    {
      var resultado = await _concreteRepo.GetFullAlumnosCurso();
      if (resultado.Count > 0)
        return Ok(resultado);
      return NotFound(new ErrorResponse {Message = "No hay Alumnos"});
    }
    
    [HttpGet]
    [Route("resumen")]
    public async Task<ActionResult<IEnumerable<AlumnoCursoAula>>> GetResumen()
    {
      var resultado = await _concreteRepo.GetAlumnoCursoAula();
      if (resultado.Count > 0)
        return Ok(resultado);
      return NotFound(new ErrorResponse {Message = "No hay Alumnos"});
    }
  }
}