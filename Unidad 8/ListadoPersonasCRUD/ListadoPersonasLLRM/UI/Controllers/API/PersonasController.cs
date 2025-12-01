using Domain.RepositoriesUseCases;
using Domain.Entities;
using Domain.RepositoriesInterfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaUseCases _personaUseCases;

        public PersonasController(IPersonaUseCases personaUseCases)
        {
            _personaUseCases = personaUseCases;
        }

        // GET: api/personas
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var listado = _personaUseCases.GetPersonasConDetalles();

                if (listado == null || listado.Count == 0)
                    return NoContent();

                return Ok(listado);
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: api/personas/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var persona = _personaUseCases.GetPersonaById(id);

                if (persona == null)
                    return NotFound();

                return Ok(persona);
            }
            catch
            {
                return BadRequest();
            }
        }

        // POST: api/personas
        [HttpPost]
        public IActionResult Post([FromBody] clsPersona persona)
        {
            try
            {
                int nuevoId = _personaUseCases.InsertPersona(persona);

                if (nuevoId <= 0)
                    return BadRequest();

                persona.ID = nuevoId;
                return Ok(persona);
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT: api/personas/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] clsPersona persona)
        {
            try
            {
                persona.ID = id;
                int filas = _personaUseCases.UpdatePersona(persona);

                if (filas == 0)
                    return NotFound();

                return Ok(persona);
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE: api/personas/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool borrado = _personaUseCases.DeletePersona(id);

                if (!borrado)
                    return NotFound();

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}