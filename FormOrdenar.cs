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

namespace CatalogoArtistasForm
{
    public partial class FormOrdenar : Form
    {
        CtrlArtista ctrlArtista = CtrlArtista.GetControlador();
        public FormOrdenar()
        {
            InitializeComponent();


            dgOrdenar.DataSource = ctrlArtista.Ordenar("1");
        }

        private void lbArtistas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Ordenar por nombre
        private void btnNombre_Click(object sender, EventArgs e)
        {
            dgOrdenar.DataSource = ctrlArtista.Ordenar("1");
        }
        //Ordenar por edad
        private void btnEdad_Click(object sender, EventArgs e)
        {
            dgOrdenar.DataSource = ctrlArtista.Ordenar("2");
        }
        //Ordenar por género
        private void btnGenero_Click(object sender, EventArgs e)
        {
            dgOrdenar.DataSource = ctrlArtista.Ordenar("3");
        }
        //Ordenar por nacionalidad
        private void btnNacionalidad_Click(object sender, EventArgs e)
        {
            dgOrdenar.DataSource = ctrlArtista.Ordenar("4");
        }
        //Ordenar por canción
        private void btnCancion_Click(object sender, EventArgs e)
        {
            dgOrdenar.DataSource = ctrlArtista.Ordenar("5");
        }
        //Ordenar por puntuación
        private void btnPuntuacion_Click(object sender, EventArgs e)
        {
            dgOrdenar.DataSource = ctrlArtista.Ordenar("6");
        }

        //Abrir ventana consultar
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar ordenar = new FormConsultar();
            this.Hide();
            ordenar.ShowDialog();
            this.Close();
        }
        //Abrir ventana agregar
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            this.Hide();
            agregar.ShowDialog();
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
        //Abrir ventana buscar
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscar buscarForm = new FormBuscar();
            this.Hide();
            buscarForm.ShowDialog();
            this.Close();
        }
    }
}
