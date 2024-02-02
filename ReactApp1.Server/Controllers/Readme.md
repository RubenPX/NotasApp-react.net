# Estructura y ejemplo

```csharp
namespace ReactApp1.Server.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class NotasController : ControllerBase {

        private NotasRepository notas = InMemoryNotas.instance;

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
```

Vamos a ir recorriendo un poco lo que vemos.

- `namespace`: Espacio de nombres que se usara para referirse donde esta cada cosa que escribamos dentro.
- `NotasController`: Esto es una clase, donde se gestionara varias rutas
  - Decoradores
    - `ApiController`: Esto indica a la clase, que es un controlador para la aplicación
    - `Route("api/[controller]")`: Esto indica que se interceptará todas las rutas que empiecen por `/api/Notas`
  - Herencia
    - `ControllerBase`: Esto hereda todas las funcionalidades de la clase `ControllerBase` y asi asegurar que .NET lo reconoce como un controlador
- Propiedades:
  - `notas`: Aqui se suele guardar el acceso a un repositorio de datos, sin que se conozca de donde viene. En este caso, se implementa la interfaz [NotasRepository](../Domain/NotasRepository.cs)
- Metodos
  - `GetNota`: Aqui se define una posible ruta a la hora de que el controlador intercepte la request
      > [!note]
      > Normalmente los metodos siguen un patrón `[operación]nombre`.
      > Dentro de operacion, de momento existe varios posibles candidatos: `Get`, `Post`, `Put`, `Delete`, `Patch`. Hay mas, pero son para cosas mas avanzadas
    - Decoradores
      - `HttpPost("{id}")`: Define que la ruta completa con sus parametros. En este caso, se define el parametro `id`, asi que la ruta en este caso es `/api/Notas/{id}`. Hay muchas mas operaciones que se soportan, ver la nota anterior
      - `ProducesResponseType({tipo de dato}, {codigo de salida})`: Esto es mas para la documentación de swagger para que se muestre las posibles salidas que hay
    - Parametros
      - `string id`: Define que lo que se va a recibir por el parametro id sera un string. Es el mismo id que esta definido en ``HttpPost("{id}")``.
      - `[FromBody]NotaDTO data`: Define el parametro que se recibira por el body de la request. La propiedad `[FromBody]` es lo que indica que viene del body