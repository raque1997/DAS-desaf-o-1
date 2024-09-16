using GestorBibliotecaVol.Models;
using GestorBibliotecaVol.Utils;

namespace GestorBibliotecaVol
{
    // Clase parcial que define el formulario para registrar nuevos libros.
    public partial class FormRegistroLibros : Form
    {
        // Constructor que inicializa los componentes gráficos del formulario.
        public FormRegistroLibros()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón "Guardar" para registrar un libro nuevo.
        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea un nuevo objeto "Libros" con la información ingresada por el usuario.
                Libros newBook = new()
                {
                    ISBN = txtISBN.Text, // Asigna el valor del ISBN ingresado.
                    TITULO = txtTituloLibro.Text, // Asigna el título ingresado.
                    AUTOR = txtAutorLibro.Text, // Asigna el autor ingresado.
                    PUBLICACION = (int)nudAnnio.Value // Asigna el año de publicación ingresado.
                };

                // Añade el nuevo libro a la lista global de libros.
                VariablesGlobales.ListaLibros.Add(newBook);
                // Limpia el formulario para ingresar nuevos datos.
                clearForm();
                // Muestra un mensaje indicando que el libro se ha agregado correctamente.
                MessageBox.Show("Libro agregado exitosamente");
            }
            catch (Exception)
            {
                // En caso de error, muestra un mensaje de error.
                MessageBox.Show("Error inesperado");
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Cancelar". Cierra el formulario actual y regresa al menú principal.
        private void btnCancelarRegistroLibro_Click(object sender, EventArgs e)
        {
            // Crea y muestra el formulario del menú principal.
            FormMenu Form = new();

            Form.Show();
            // Cierra el formulario actual de registro de libros.
            this.Close();
        }

        // Método para limpiar los campos del formulario tras agregar o cancelar.
        private void clearForm()
        {
            txtISBN.Text = string.Empty; // Limpia el campo del ISBN.
            txtTituloLibro.Text = string.Empty; // Limpia el campo del título.
            txtAutorLibro.Text = string.Empty; // Limpia el campo del autor.
            nudAnnio.Value = 0; // Reinicia el campo del año de publicación a 0.
        }

        // Evento asociado al cambio de texto en el campo ISBN, actualmente sin implementación.

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
