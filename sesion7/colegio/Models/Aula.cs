using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Models
{
  public class Aula : BaseModel<int>
  {

    public Aula()
    {
      Cursos = new List<Curso>();
    }
    public string Descripcion { get; set; }

    public IList<Curso> Cursos { get; set; }
  }
}
