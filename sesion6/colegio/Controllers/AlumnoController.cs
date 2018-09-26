using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace colegio.Controllers
{
  using Data;
  using Models;

  [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ColegioBaseController<Alumno, int>
  {
    private IAlumnoRepository _concreteRepo; 
      public AlumnoController(IAlumnoRepository dependency) : base(dependency)
      {
        this._concreteRepo = dependency;
      }

      //[HttpGet()]
      //public ActionResult<IEnumerable<Alumno>> GetAlumnosByCurso(int curso)
      //{
      //  return Ok(_concreteRepo.GetAlumnosByCurso(curso));
      //}
    }
}