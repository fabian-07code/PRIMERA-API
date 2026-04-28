using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRIMERA_API.Data;
using PRIMERA_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRIMERA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tabla2Controller : ControllerBase
    {
        private readonly AppDbContext _db;

        public Tabla2Controller(AppDbContext db)
        {
            _db = db;


        }
        // GET: api/<Tabla2Controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tabla2>>> Get()
        {
            var resultado = _db.tabla2.ToListAsync();

            return Ok(new { exito = true, resultado });

        }

        // GET api/<Tabla2Controller>/5
      [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var consulta = await _db.tabla2.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                Ok = true,
                Message = "Consulta realizada exitosamente",
                Data = consulta
            });

        }

        // POST api/<Tabla2Controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Tabla2 registro)
        {
            _db.tabla2.Add(registro);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = registro.Id },
                new
                {
                    Ok = true,
                    Message = "Registro creado exitosamente",
                    Data = registro
                });
        }

        // PUT api/<Tabla2Controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Tabla2 registro)
        {
            var consulta = await _db.tabla2.FindAsync(id);

            consulta.Color = registro.Color;
            await _db.SaveChangesAsync();
            return Ok(new
            {
                Ok = true,
                Message = "Registro actualizado exitosamente",
                Data = consulta
            });
        }

        // DELETE api/<Tabla2Controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var registro = await _db.tabla2.FindAsync(id);
            if (registro == null)
            {
                return NotFound();
            }

            _db.tabla2.Remove(registro);
            await _db.SaveChangesAsync();

            return NoContent();
        }


        [HttpPatch("{id}")]
        public async Task<ActionResult> Patchtabla2(int id, [FromBody] Dictionary<string, object> cambios)
        {
            var consulta = await _db.tabla2.FindAsync(id);
            foreach (var campo in cambios)
            {
                switch (campo.Key.ToLower())
                {
                    case "color":
                        consulta.Color = campo.Value.ToString();
                        break;
                    case "descripcion":
                        consulta.Descripcion = campo.Value.ToString();
                        break;

                }
                    

            }
            await _db.SaveChangesAsync();

            return Ok(new
            {
                Ok = true,
                Message = "Registro actualizado exitosamente",
                Data = consulta
            });
        }
    }
}