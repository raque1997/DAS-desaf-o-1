using GestorBibliotecaVol.Models;

namespace GestorBibliotecaVol.Utils
{
    // Clase estática que contiene variables globales que serán accesibles desde cualquier parte de la aplicación.
    public static class VariablesGlobales
    {
        // Lista estática que contiene objetos de tipo "Libros". Esta lista actúa como un almacenamiento global para los libros registrados en la aplicación.
        public static List<Libros> ListaLibros = new List<Libros>();
    }
}
