using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Models
{
  public class BaseModel<TKey> where TKey : IEquatable<TKey>
  {
    public TKey Id { get; set; }
  }

}
