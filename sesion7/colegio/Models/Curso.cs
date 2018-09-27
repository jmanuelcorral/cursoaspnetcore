namespace colegio.Models
{
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;

  public class Curso : BaseModel<int>
  {
    public Curso()
    {
      Alumnos = new List<Alumno>();
      Profesor = new List<Profesor>();
    }
    public string Descripcion { get; set; }
    public int? AulaId { get; set; }

    public Aula Aula { get; set; }
    public IList<Alumno> Alumnos { get; set; }
    public IList<Profesor> Profesor { get; set; }
  }
}