using GestorBibliotecaVol.Models;
using GestorBibliotecaVol.Utils;

namespace GestorBibliotecaVol.View
{
    // Clase parcial que representa el formulario para actualizar libros.
    public partial class FormActualizarLibros : Form
    {
        // Índice que se utiliza para almacenar la posición del libro en la lista.
        private int index = -1;
        // Constructor del formulario que inicializa los componentes gráficos.
        public FormActualizarLibros()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta al hacer clic en el botón "Buscar". Busca un libro en la lista por su ISBN.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Busca el índice del libro en la lista global de libros basado en el ISBN ingresado.
            index = VariablesGlobales.ListaLibros.FindIndex(s => s.ISBN == txtISBN.Text);

            // Si encuentra el libro, muestra los datos en los campos del formulario.
            if (index != -1)
            {
                MessageBox.Show("Libro encontrado");
                Libros? book = VariablesGlobales.ListaLibros.Find(s => s.ISBN == txtISBN.Text);

                // Muestra el título, autor y año de publicación en los campos correspondientes si no son nulos.
                txtTituloLibro.Text = book.TITULO != null
                    ? book.TITULO.ToString()
                    : string.Empty;

                txtAutorLibro.Text = book.AUTOR != null
                    ? book.AUTOR.ToString()
                    : string.Empty;

                // Asigna el valor del año de publicación si no es nulo, si no, asigna 0.
                nudAnnio.Value = book.PUBLICACION != null
                    ? (decimal)book.PUBLICACION
                    : 0;

                // Habilita los campos del formulario para que puedan ser editados.
                enableForm();
            }
            else
            {
                // Si no se encuentra el libro, muestra un mensaje y deshabilita el formulario.
                MessageBox.Show("No se encontro un libro con ese ISBN");

                clearForm();
                disableForm();
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Actualizar". Actualiza los datos del libro encontrado.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Si el libro fue encontrado previamente, se procede a actualizarlo.
            if (index != -1)
            {
                // Crea una nueva instancia del libro con los datos ingresados en el formulario.
                Libros bookUpdate = new Libros
                {
                    ISBN = txtISBN.Text,
                    TITULO = txtTituloLibro.Text,
                    AUTOR = txtAutorLibro.Text,
                    PUBLICACION = (int)nudAnnio.Value
                };

                // Actualiza el libro en la lista global en la posición correspondiente.
                VariablesGlobales.ListaLibros[index] = bookUpdate;

                // Limpia y deshabilita el formulario tras actualizar el libro.
                clearForm();
                disableForm();
                MessageBox.Show("Libro actualizado.");
            }
        }

        // Evento que se ejecuta al hacer clic en "Cancelar". Cierra el formulario actual y regresa al menú principal.
        private void btnCancelarRegistroLibro_Click(object sender, EventArgs e)
        {
            FormMenu Form = new();

            // Muestra el formulario del menú principal.
            Form.Show();
            this.Close(); // Cierra el formulario actual.
        }

        // Método para limpiar los campos del formulario.
        private void clearForm()
        {
            txtISBN.Text = string.Empty;
            txtTituloLibro.Text = string.Empty;
            txtAutorLibro.Text = string.Empty;
            nudAnnio.Value = 0;
        }

        // Habilita los campos del formulario para permitir la edición.
        private void enableForm()
        {
            btnActualizar.Enabled = true;
            txtTituloLibro.Enabled = true;
            txtAutorLibro.Enabled = true;
            nudAnnio.Enabled = true;
        }

        // Deshabilita los campos del formulario para impedir la edición.
        private void disableForm()
        {
            btnActualizar.Enabled = false;
            txtTituloLibro.Enabled = false;
            txtAutorLibro.Enabled = false;
            nudAnnio.Enabled = false;
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
