namespace colegio.Models
{
  using System.ComponentModel.DataAnnotations;

  public class Curso : BaseModel<int>
  {
    public string Descripcion { get; set; }

    public int NumAlumnos { get; set; }
  }
}