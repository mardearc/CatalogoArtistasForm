using CatalogoArtistas.controller;
using CatalogoArtistas.model;
using CatalogoArtistasForm.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CatalogoArtistasForm
{
    public partial class FormEliminar : Form
    {
        CtrlArtista ctrlArtista = CtrlArtista.GetControlador();

        List<Artista> listBorrar = new List<Artista>();
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lbBorrar.Items.Clear();
            Artista a;
            string Nombre = tbNombre.Text;
            int Edad = Int32.Parse(nbEdad.Value.ToString());
            string Genero = tbGenero.Text;
            string Nacionalidad = tbNacionalidad.Text;
            string Cancion = tbCancion.Text;
            double Puntuacion = Double.Parse(nbPuntuacion.Value.ToString());
            char Tipo;
            string NombrePila = null;
            string NombreGrupo = null;
            if (rbSolista.Checked)
            {
                Tipo = 's';
                NombrePila = tbNombreTipo.Text;
            }
            else
            {
                Tipo = 'g';
                NombreGrupo = tbNombreTipo.Text;
            }

            listBorrar = ctrlArtista.Buscar(Edad, Puntuacion, Tipo, Nombre, Genero, Nacionalidad, Cancion, NombrePila, NombreGrupo);

            foreach (Artista artista in listBorrar)
            {
                lbBorrar.Items.Add(artista);
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int items = listBorrar.Count;
            DialogResult respuesta = MessageBox.Show($"¿Seguro que quiere borrar {items} artistas?", "¡CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {

                int cont = ctrlArtista.EliminarArtista(listBorrar);

                tbNombre.Text = "";
                nbEdad.Value = 0;
                tbGenero.Text = "";
                tbNacionalidad.Text = "";
                tbCancion.Text = "";
                nbPuntuacion.Value = 0;
                tbNombreTipo.Text = "";

                MessageBox.Show($"Se han eliminado {cont} artistas");
            }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar ordenar = new FormConsultar();
            this.Hide();
            ordenar.ShowDialog();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            this.Hide();
            agregar.ShowDialog();
            this.Close();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdenar ordenar = new FormOrdenar();
            this.Hide();
            ordenar.ShowDialog();
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
