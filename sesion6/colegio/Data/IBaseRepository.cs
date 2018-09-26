namespace colegio.Data
{
  using System;
  using System.Collections.Generic;
  using System.Threading.Tasks;
  using Models;

  public interface IBaseRepository<TEntity, TKey> where TEntity : BaseModel<TKey>  
    where TKey: IEquatable<TKey>
                                                  
  {
    IEnumerable<TEntity> Get();
    Task<List<TEntity>> GetAsync();
    TEntity GetById(TKey id);
    void Save(TEntity a);
    void Delete(TKey id);
    void Update(TEntity a);
    bool Commit();
  }
}