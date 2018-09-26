namespace colegio.Controllers
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using Data;
  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;
  using Swashbuckle.AspNetCore.SwaggerGen;
  using Models;
  using System.Threading.Tasks;

  [Route("api/[controller]")]
  [ApiController]
  public abstract class ColegioBaseController<TEntity,TKey> : ControllerBase
      where TEntity : BaseModel<TKey>
      where TKey : IEquatable<TKey>
  {

    protected readonly IBaseRepository<TEntity, TKey> _repo;
    public ColegioBaseController(IBaseRepository<TEntity, TKey> dependency)
    {
      _repo = dependency;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> Get()
    {
      var resultado = await _repo.GetAsync();
      if (resultado.Count() > 0)
        return Ok(resultado);
      else return NotFound(new ErrorResponse() {Message =  "No hay cursos"});
    }

    // GET: api/Curso/5
    [HttpGet("{id}")]
    public ActionResult<TEntity> Get(TKey id)
    {
      var mibusqueda = _repo.GetById(id);
      if (mibusqueda == null) return NotFound();
      else return Ok(mibusqueda);
    }

    // POST: api/Curso
    [HttpPost]
    public ActionResult<TEntity> Post([FromBody] TEntity value)
    {
      if (ModelState.IsValid)
      {
        _repo.Save(value);
        if (_repo.Commit()) return Ok(new {mensaje = "Grabado correctamente"});
        else return BadRequest(new {mensaje = "Error al Grabar"});
      }
      else return BadRequest(ModelState);
    }

    // PUT: api/Curso/5
    [HttpPut("{id}")]
    public ActionResult<TEntity> Put(TKey id, [FromBody] TEntity value)
    {
      var mibusqueda = _repo.GetById(id);
      if (mibusqueda == null) return NotFound(new ErrorResponse() {Message =  "Curso no encontrado"});
      _repo.Update(value);
      if (_repo.Commit()) return Ok(new {mensaje = "Grabado correctamente"});
      else return BadRequest(new {mensaje = "Error al Grabar"});
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public ActionResult Delete(TKey id)
    {
      _repo.Delete(id);
      if (_repo.Commit()) return Ok(new {mensaje = "Borrado correctamente"});
      else return BadRequest(new {mensaje = "Error al Grabar"});
    }
  }
}