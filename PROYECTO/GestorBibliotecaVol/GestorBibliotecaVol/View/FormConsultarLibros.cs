using GestorBibliotecaVol.Utils;

namespace GestorBibliotecaVol.View
{
    public partial class FormConsultarLibros : Form
    {
        public FormConsultarLibros()
        {
            InitializeComponent();
        }

        private void FormConsultarLibros_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VariablesGlobales.ListaLibros;
        }

        private void FormConsultarLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu Form = new();

            Form.Show();
        }
    }
}
