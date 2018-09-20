using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace colegio.Controllers
{
  using Models;

  [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ColegioBaseController<Models.Alumno>
    {
      public AlumnoController(List<Alumno> dependency) : base(dependency)
      {
      }
    }
}