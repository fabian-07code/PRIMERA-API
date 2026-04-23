using Microsoft.AspNetCore.Mvc;
using PRIMERA_API.Data;
using PRIMERA_API.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRIMERA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tabla1Controller : ControllerBase

    {
        private readonly AppDbContext _db;

        public Tabla1Controller(AppDbContext db)
        {
            _db = db;


        }


        // GET: api/<Tabla1Controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tabla1>>> Get()
        {
            var consulta = _db.tabla1.ToListAsync();

            return Ok(new { exito = true, consulta });
        }

        // GET api/<Tabla1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Tabla1Controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] tabla1 registro)
        {
            _db.tabla1.Add(registro);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = registro.Id },
                new
                {
                    Ok = true,
                    Message = "Registro creado exitosamente",
                    Data = registro
                });
        }



        // PUT api/<Tabla1Controller>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] tabla1 registro)
        {
            var consulta = await _db.tabla1.FindAsync(id);
            consulta.Id = registro.Id;
            consulta.Nombre = registro.Nombre;

            _db.Entry(consulta).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            return Ok(new
            {
                Ok = true,
                Message = "Registro actualizado exitosamente",
                Data = registro
            });
        }

        // DELETE api/<Tabla1Controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var consulta = await _db.tabla1.FindAsync(id);
            if (consulta == null)
            {
                return NotFound(new
                {
                    Ok = false,
                    Message = "Registro no encontrado"
                });
            }
            _db.tabla1.Remove(consulta);
            await _db.SaveChangesAsync();
            return Ok(new
            {
                Ok = true,
                Message = "Registro eliminado exitosamente"
            });
            {
            }
        }
    }
}
    

