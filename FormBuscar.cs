using CatalogoArtistas.controller;
using CatalogoArtistas.model;

namespace CatalogoArtistasForm.model
{
    public partial class FormBuscar : Form
    {
        CtrlArtista ctrlArtista = CtrlArtista.GetControlador();

        List<Artista> listBorrar = new List<Artista>();

        public FormBuscar()
        {
            InitializeComponent();
        }

        //Método para buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Borrar la lista por si había registros
            lbBorrar.Items.Clear();

            string Nombre = tbNombre.Text;
            int Edad = Int32.Parse(nbEdad.Value.ToString());
            string Genero = tbGenero.Text;
            string Nacionalidad = tbNacionalidad.Text;
            string Cancion = tbCancion.Text;
            double Puntuacion = Double.Parse(nbPuntuacion.Value.ToString());
            char Tipo = 'n';
            string NombrePila = null;
            string NombreGrupo = null;

            if (cbSolista.Checked)
            {
                Tipo = 's';
                NombrePila = tbNombreTipo.Text;
            }
            if (cbDeGrupo.Checked)
            {
                Tipo = 'g';
                NombreGrupo = tbNombreTipo.Text;
            }

            listBorrar = ctrlArtista.Buscar(Edad, Puntuacion, Tipo, Nombre, Genero, Nacionalidad, Cancion, NombrePila, NombreGrupo);

            //Agregar a la lista los artistas
            foreach (Artista artista in listBorrar)
            {
                lbBorrar.Items.Add(artista);
            }
        }

        //Abrir ventana consultar
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar form1 = new FormConsultar();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
        //Abrir ventana agregar
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new();
            this.Hide();
            agregar.ShowDialog();
            this.Close();
        }
        //Abrir ventana ordenar
        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdenar ordenar = new FormOrdenar();
            this.Hide();
            ordenar.ShowDialog();
            this.Close();
        }
        //Abrir ventana eliminar
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar borrarEmpleado = new FormEliminar();
            this.Hide();
            borrarEmpleado.ShowDialog();
            this.Close();
        }
        //Si es solista se elige el nombre de pila
        private void cbSolista_CheckedChanged(object sender, EventArgs e)
        {
            cbDeGrupo.Checked = false;
            lblNombreTipo.Text = "Nombre de pila";
            tbNombreTipo.Visible = true;
            lblNombreTipo.Visible = true;

            if (!cbSolista.Checked)
            {
                tbNombreTipo.Visible = false;
                lblNombreTipo.Visible = false;
            }
        }

        //Si es de grupo se elige el nombre de grupo
        private void cbDeGrupo_CheckedChanged(object sender, EventArgs e)
        {
            cbSolista.Checked = false;
            lblNombreTipo.Text = "Nombre de Grupo";
            tbNombreTipo.Visible = true;
            lblNombreTipo.Visible = true;
            if (!cbDeGrupo.Checked)
            {
                tbNombreTipo.Visible = false;
                lblNombreTipo.Visible = false;
            }
        }
    }
}
