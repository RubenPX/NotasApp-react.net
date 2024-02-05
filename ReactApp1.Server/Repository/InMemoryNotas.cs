using ReactApp1.Server.Domain.Entity;
using ReactApp1.Server.Domain.Interfaces;
using System.ComponentModel;

namespace ReactApp1.Server.Repository
{
    public class InMemoryNotas : INotasRepository {

        private static INotasRepository? repository;
        public static INotasRepository instance {
            get { 
                if (repository == null) { repository = new InMemoryNotas(); }
                return repository;
            }
        }

        private readonly List<Nota> _notas = new List<Nota>();

        public Nota Create(string titulo, string autor) {
            Nota nota = new Nota {
                id = _notas.Count.ToString(),
                titulo = titulo, 
                autor = autor, 
                fechaCreacion = DateTime.Now, 
                fechaEdicion = DateTime.Now 
            };

            _notas.Add(nota);

            return nota;
        }

        public Nota Delete(string id) {
            Nota nota = this.Get(id);
            _notas.Remove(nota);
            return nota;
        }

        public Nota Get(string id) {
            Nota? foundNota = _notas.Find(nota => nota.id == id);
            if (foundNota == null) throw new CodeException(404, "Nota no encontrada");
            return foundNota;
        }

        public IEnumerable<Nota> GetList() {
            return _notas;
        }

        public Nota Modify(string id, string titulo, string autor) {
            // Consigue la nota que se busca
            int notaIndex = _notas.FindIndex(nota => nota.id == id);

            // Si no se encuentra, se envia un error
            if (notaIndex == -1) throw new CodeException(404, "Nota no encontrada");

            // Consigue los datos de la nota
            Nota nota = _notas[notaIndex];

            // Reemplaza los datos
            nota.titulo = titulo;
            nota.autor = autor;
            nota.fechaEdicion = DateTime.Now;

            // Reemplaza los datos de la nota
            _notas[notaIndex] = nota;
            return nota;
        }
    }
}
