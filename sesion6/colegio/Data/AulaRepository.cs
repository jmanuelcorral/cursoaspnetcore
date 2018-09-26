using colegio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Data
{
  public class AulaRepository : BaseRepository<Aula, int>
  {
 
    public AulaRepository(DataContext context) : base(context)
    {
    }
  }
}
