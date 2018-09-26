using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Models
{
  public class Profesor :BaseModel<int>
  {
    public string Nombre { get; set; }

  }
}
