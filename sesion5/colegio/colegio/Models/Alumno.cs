using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Models
{
  public class Alumno : BaseModel
  {
    public string nombre { get; set; }
    public int edad { get; set; }
  }
}
