using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Models
{
  public class Alumno : BaseModel<int>
  {
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string Email { get; set; }
    public int CursoId { get; set; }

    public Curso Curso { get; set; }
  }
}
