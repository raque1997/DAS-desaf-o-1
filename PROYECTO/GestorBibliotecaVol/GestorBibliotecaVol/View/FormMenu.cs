using GestorBibliotecaVol.View;

namespace GestorBibliotecaVol
{
    // Clase parcial que representa el formulario principal del menú de la aplicación.
    public partial class FormMenu : Form
    {
        // Constructor del formulario. Inicializa los componentes gráficos del formulario cuando se instancia.
        public FormMenu()
        {
            InitializeComponent(); // Inicializa los componentes definidos en el diseñador de Visual Studio.
        }

        // Evento que se dispara cuando el formulario es cerrado.
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Finaliza la aplicación cuando se cierra el formulario principal.
            Application.Exit();
        }

        // Evento asociado al botón "Registrar". Abre el formulario de registro de libros.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de registro de libros.
            FormRegistroLibros Form = new();

            // Muestra el formulario de registro de libros.
            Form.Show();
            // Oculta el formulario actual (el menú).
            this.Hide();
        }

        // Evento asociado al botón "Consultar". Abre el formulario de consulta de libros.
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de consulta de libros.
            FormConsultarLibros Form = new();

            // Muestra el formulario de consulta de libros.
            Form.Show();
            // Oculta el formulario actual (el menú).
            this.Hide();
        }

        // Evento asociado al botón "Actualizar". Abre el formulario para actualizar libros.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de actualización de libros.
            FormActualizarLibros Form = new();

            // Muestra el formulario de actualización de libros.
            Form.Show();
            // Oculta el formulario actual (el menú).
            this.Hide();
        }

        // Evento asociado al botón "Eliminación". Abre el formulario para eliminar libros.
        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario de eliminación de libros.
            FormEliminarLibros Form = new();

            // Muestra el formulario de eliminación de libros.
            Form.Show();
            // Oculta el formulario actual (el menú).
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
