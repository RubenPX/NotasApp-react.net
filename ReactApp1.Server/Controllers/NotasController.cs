using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Domain;
using ReactApp1.Server.Repository;

namespace ReactApp1.Server.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase {

        private InMemoryNotas notas = new InMemoryNotas();

        // GET: api/Lista
        [HttpGet]
        public IEnumerable<Nota> GetLista() {
            return notas.GetList();
        }

        [HttpGet("{id}")]
        public string GetNota(string id) {
            Console.WriteLine(id);
            return "OK!";
        }

        [HttpPut]
        public Nota CreateNota([FromBody] NotaDTO nota) {
            return notas.Create(nota.titulo, nota.autor);
        }

        [HttpDelete("{id}")]
        public Nota DeleteNota(string id) {
            return notas.Delete(id);
        }

        [HttpPost("{id}")]
        public Nota ModifyNota(string id, [FromBody]NotaDTO data) {
            return notas.Modify(id, data.titulo, data.autor);
        }


    }
}
