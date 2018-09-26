using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using colegio.Data;
using colegio.Models;

namespace colegio.Controllers
{
  public class ProfesorsController : ColegioBaseController<Profesor, int>
  {
    public ProfesorsController(IBaseRepository<Profesor, int> dependency) : base(dependency)
    {
    }
  }
}
