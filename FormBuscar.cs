using CatalogoArtistas.controller;
using CatalogoArtistas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar form1 = new FormConsultar();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new();
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar borrarEmpleado = new FormEliminar();
            this.Hide();
            borrarEmpleado.ShowDialog();
            this.Close();
        }
    }
}
