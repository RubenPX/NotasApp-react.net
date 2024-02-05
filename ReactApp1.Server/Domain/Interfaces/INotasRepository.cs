using ReactApp1.Server.Domain.Entity;

namespace ReactApp1.Server.Domain.Interfaces
{
    public interface INotasRepository
    {

        /// <summary>Consigue la lista completa de notas</summary>
        /// <returns>Lista de notas</returns>
        public IEnumerable<Nota> GetList();

        /// <summary>Devuelve una nota en especifico</summary>
        /// <param name="id">ID de la nota que se quiere extraer</param>
        /// <returns>Nota</returns>
        public Nota Get(string id);

        /// <summary>Crea una nota nueva</summary>
        /// <param name="titulo">Titulo de la nota</param>
        /// <param name="autor">Autor de la nota</param>
        /// <returns>Devuelve la nota</returns>
        public Nota Create(string titulo, string autor);

        /// <summary>Modifica una nota</summary>
        /// <param name="id">ID de la nota que se quiere modificar</param>
        /// <param name="titulo">titulo de la nota</param>
        /// <param name="autor">autor de la nota</param>
        /// <returns>Nota</returns>
        public Nota Modify(string id, string titulo, string autor);

        /// <summary>Elimina una nota</summary>
        /// <param name="id">ID de la nota que se quiere eliminar</param>
        /// <returns>Nota eliminada</returns>
        public Nota Delete(string id);
    }
}
