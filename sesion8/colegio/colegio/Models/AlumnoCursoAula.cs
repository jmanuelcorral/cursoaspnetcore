using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Models
{
  public class AlumnoCursoAula
  {
    public int AlumnoId { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string Email { get; set; }
    public string Curso { get; set; }
    public string Aula { get; set; }
  }
}
