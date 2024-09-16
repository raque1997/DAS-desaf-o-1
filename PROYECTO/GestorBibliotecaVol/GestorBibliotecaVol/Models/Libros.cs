namespace GestorBibliotecaVol.Models
{
    // Clase que representa el modelo "Libros". Esta clase contiene las propiedades que definen los atributos de un libro en el sistema.
    public class Libros
    {
        // Propiedad pública que almacena el ISBN del libro. El tipo string es nullable (puede ser null) por el uso de '?'.
        public string? ISBN { get; set; }
        // Propiedad pública que almacena el título del libro. El tipo string es nullable (puede ser null).
        public string? TITULO { get; set; }
        // Propiedad pública que almacena el nombre del autor del libro. El tipo string es nullable (puede ser null).
        public string? AUTOR { get; set; }
        // Propiedad pública que almacena el año de publicación del libro. El tipo int es nullable (puede ser null).
        public int? PUBLICACION { get; set; }
    }
}
