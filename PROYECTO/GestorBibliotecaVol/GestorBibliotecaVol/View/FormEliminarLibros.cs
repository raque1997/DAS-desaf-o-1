using GestorBibliotecaVol.Models;
using GestorBibliotecaVol.Utils;

namespace GestorBibliotecaVol.View
{
    // Clase parcial que define el formulario para eliminar libros.
    public partial class FormEliminarLibros : Form
    {
        // Variable para almacenar el índice del libro encontrado en la lista.
        private int index = -1;
        // Constructor del formulario, inicializa los componentes gráficos.
        public FormEliminarLibros()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando se hace clic en el botón "Buscar". Busca un libro por su ISBN.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Busca el índice del libro en la lista global de libros basado en el ISBN ingresado.
            index = VariablesGlobales.ListaLibros.FindIndex(s => s.ISBN == txtISBN.Text);

            // Si encuentra el libro, muestra sus datos en el formulario.
            if (index != -1)
            {
                MessageBox.Show("Libro encontrado");
                Libros? book = VariablesGlobales.ListaLibros.Find(s => s.ISBN == txtISBN.Text);

                // Asigna el título del libro, si no es nulo, al campo correspondiente del formulario.
                txtTituloLibro.Text = book.TITULO != null
                    ? book.TITULO.ToString()
                    : string.Empty;

                // Asigna el autor del libro, si no es nulo, al campo correspondiente del formulario.
                txtAutorLibro.Text = book.AUTOR != null
                    ? book.AUTOR.ToString()
                    : string.Empty;

                // Asigna el año de publicación, si no es nulo, al campo correspondiente. Si es nulo, asigna 0.
                nudAnnio.Value = book.PUBLICACION != null
                    ? (decimal)book.PUBLICACION
                    : 0;

                // Habilita el botón para eliminar el libro.
                enableForm();
            }
            // Si no encuentra el libro, muestra un mensaje, limpia el formulario y lo deshabilita.
            else
            {
                MessageBox.Show("No se encontro un libro con ese ISBN");

                clearForm();
                disableForm();
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón "Eliminar". Elimina el libro de la lista.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Si el libro fue encontrado, lo elimina de la lista global.
            if (index != -1)
            {
                VariablesGlobales.ListaLibros.RemoveAt(index);

                // Limpia y deshabilita el formulario tras eliminar el libro.
                clearForm();
                disableForm();
                MessageBox.Show("Libro eliminado.");
            }
        }

        // Evento que se ejecuta cuando se hace clic en el botón "Cancelar". Cierra el formulario y regresa al menú.
        private void btnCancelarRegistroLibro_Click(object sender, EventArgs e)
        {
            FormMenu Form = new();

            // Muestra el formulario del menú principal y cierra el formulario actual.
            Form.Show();
            this.Close();
        }

        // Método para limpiar los campos del formulario.
        private void clearForm()
        {
            txtISBN.Text = string.Empty;
            txtTituloLibro.Text = string.Empty;
            txtAutorLibro.Text = string.Empty;
            nudAnnio.Value = 0;
        }

        // Método para habilitar el botón de eliminar.
        private void enableForm()
        {
            btnEliminar.Enabled = true;
        }

        // Método para deshabilitar el botón de eliminar.
        private void disableForm()
        {
            btnEliminar.Enabled = false;
        }

        // Evento asociado al cambio de texto en el campo ISBN, actualmente sin implementación.
        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
