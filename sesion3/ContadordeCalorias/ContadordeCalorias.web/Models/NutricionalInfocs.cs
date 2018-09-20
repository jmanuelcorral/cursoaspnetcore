using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContadordeCalorias.web.Models
{
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;

  public class NutricionalInfocs
  {
    public Guid Id { get; set; }


    public string Descripcion
    {
      get; set;

    }

    
    public int Calorias { get; set; }
  }
}
