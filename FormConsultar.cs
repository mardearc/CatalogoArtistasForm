using CatalogoArtistas.controller;
using CatalogoArtistas.model;
using CatalogoArtistasForm.model;

namespace CatalogoArtistasForm
{
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();

            CtrlArtista ctrlArtista = CtrlArtista.GetControlador();
            ctrlArtista.CargarDatos();

            dgConsultar.DataSource = ctrlArtista.ConsultarDatos();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new();
            this.Hide();
            agregar.ShowDialog();
            this.Close();



        }

        private void lbArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdenar ordenar = new FormOrdenar();
            this.Hide();
            ordenar.ShowDialog();
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar borrarEmpleado = new FormEliminar();
            this.Hide();
            borrarEmpleado.ShowDialog();
            this.Close();
        }

        private void btnAbrirListado_Click(object sender, EventArgs e)
        {
            FormListado formListado = new FormListado();
            this.Hide();
            formListado.ShowDialog();
            this.Close();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscar buscarForm = new FormBuscar();
            this.Hide();
            buscarForm.ShowDialog();
            this.Close();
        }
    }
}
