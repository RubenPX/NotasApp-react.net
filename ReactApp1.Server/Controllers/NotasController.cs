using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Domain;
using ReactApp1.Server.Repository;
using System.Diagnostics;

namespace ReactApp1.Server.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase {

        private NotasRepository notas = InMemoryNotas.instance;

        // GET: api/Lista
        [HttpGet]
        [ProducesResponseType(typeof(List<Nota>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public IActionResult GetLista() {
            try {
                return Ok(notas.GetList());
            } catch (Exception ex) {
                return CodeExceptionDTO.generateResponse(this, ex);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Nota), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CodeExceptionDTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public IActionResult GetNota(string id) {
            try {
                return Ok(notas.Get(id));
            } catch (Exception ex) {
                return CodeExceptionDTO.generateResponse(this, ex);
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(Nota), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public IActionResult CreateNota([FromBody] NotaDTO nota) {
            try {
                return Ok(notas.Create(nota.titulo, nota.autor));
            } catch (Exception ex) {
                return CodeExceptionDTO.generateResponse(this, ex);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Nota), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CodeExceptionDTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteNota(string id) {
            try {
                return Ok(notas.Delete(id));
            } catch (Exception ex) {
                return CodeExceptionDTO.generateResponse(this, ex);
            }
        }

        [HttpPost("{id}")]
        [ProducesResponseType(typeof(Nota), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CodeExceptionDTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public IActionResult ModifyNota(string id, [FromBody]NotaDTO data) {
            try {
                return Ok(notas.Modify(id, data.titulo, data.autor));
            } catch (Exception ex) {
                return CodeExceptionDTO.generateResponse(this, ex);
            }
        }
    }
}
