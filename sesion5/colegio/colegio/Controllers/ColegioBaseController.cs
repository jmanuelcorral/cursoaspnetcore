namespace colegio.Controllers
{
  using System.Collections.Generic;
  using Microsoft.AspNetCore.Http;
  using Microsoft.AspNetCore.Mvc;
  using Swashbuckle.AspNetCore.SwaggerGen;
  using Models;

  [Route("api/[controller]")]
  [ApiController]
  public abstract class ColegioBaseController<T> : ControllerBase where T : BaseModel
  {
    private List<T> miRecurso;
    public ColegioBaseController(List<T> dependency)
    {
      miRecurso = dependency;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<T>> Get()
    {
      if (miRecurso.Count > 0)
        return Ok(miRecurso);
      else return NotFound(new ErrorResponse() {Message =  "No hay cursos"});
    }

    // GET: api/Curso/5
    [HttpGet("{id}")]
    public ActionResult<T> Get(int id)
    {
      var mibusqueda = miRecurso.Find(x => x.Id == id);
      if (mibusqueda == null) return NotFound();
      else return Ok(mibusqueda);
    }

    // POST: api/Curso
    [HttpPost]
    public ActionResult<T> Post([FromBody] T value)
    {
      if (ModelState.IsValid)
      {
        miRecurso.Add(value);
        return Ok(new {mensaje = "Grabado correctamente"});
      }
      else return BadRequest(ModelState);
    }

    // PUT: api/Curso/5
    [HttpPut("{id}")]
    public ActionResult<T> Put(int id, [FromBody] T value)
    {
      var mibusqueda = miRecurso.Find(x => x.Id == id);
      if (mibusqueda == null) return NotFound(new ErrorResponse() {Message =  "Curso no encontrado"});
      miRecurso.Remove(mibusqueda);
      miRecurso.Add(value);
      return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}