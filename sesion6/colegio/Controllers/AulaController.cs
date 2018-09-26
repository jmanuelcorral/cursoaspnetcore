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
  public class AulaController : ColegioBaseController<Aula, int>
  {
    public AulaController(IBaseRepository<Aula, int> dependency) : base(dependency)
    {
    }

    }
}