using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colegio.Data
{
  using Microsoft.EntityFrameworkCore;
  using Models;

  public abstract class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> 
                                                where TEntity : BaseModel<TKey>  
                                                where TKey: IEquatable<TKey>
  {
    private readonly DbContext _context;
    private DbSet<TEntity> _tabla { get; set; }
    protected IQueryable<TEntity> _query { get; set; }
    public BaseRepository(DbContext context)
    {
      _context = context;
      _tabla = context.Set<TEntity>();
      _query = _tabla;
    }
    public void Delete(TKey id)
    {
      var entityToRemove = GetById(id);
      _tabla.Remove(entityToRemove);
    }

    public IEnumerable<TEntity> Get()
    {
      return _tabla.ToArray();
    }

    public Task<List<TEntity>> GetAsync()
    {
      return _tabla.ToListAsync();
    }

    public TEntity GetById(TKey id)
    {
      return _tabla.FirstOrDefault(x => x.Id.Equals(id));
    }

    public void Save(TEntity a)
    {
      _tabla.Add(a);
    }

    public void Update(TEntity a)
    {
      _tabla.Update(a);
    }

    public bool Commit()
    {
      return (_context.SaveChanges() > 0);
    }
  }
}
