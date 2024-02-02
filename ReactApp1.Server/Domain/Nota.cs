namespace ReactApp1.Server.Domain {
    public class Nota {
        /// <summary>ID de la nota</summary>
        public string id {  get; set; }

        /// <summary>Titulo de la nota</summary>
        public string titulo { get; set; }

        /// <summary>Creador de la nota</summary>
        public string autor { get; set; }

        /// <summary>Fecha de creación</summary>
        public DateTime fechaCreacion { get; set; }

        /// <summary>Fecha de modificación</summary>
        public DateTime fechaEdicion { get; set; }
    }
}
