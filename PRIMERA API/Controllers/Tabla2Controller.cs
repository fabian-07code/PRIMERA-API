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
            var resultado  = _db.tabla2.ToListAsync();

            return Ok(new { exito = true, resultado });

        }

        // GET api/<Tabla2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Tabla2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Tabla2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Tabla2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
