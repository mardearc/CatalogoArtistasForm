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

        //Botón para buscar
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
            //Guardar en una lista los registros que cumplen la condición
            listBorrar = ctrlArtista.Buscar(Edad, Puntuacion, Tipo, Nombre, Genero, Nacionalidad, Cancion, NombrePila, NombreGrupo);

            //Añadirlos a la lista del formulario
            foreach (Artista artista in listBorrar)
            {
                lbBorrar.Items.Add(artista);
            }


        }
        //Botón para eliminar artistas
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int items = listBorrar.Count;

            //Si hay artistas se da la opción de borrar
            if (items > 0)
            {
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
            else //Si no hay artistas salta un MessageBox
            {
                MessageBox.Show($"No hay artistas para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        //Abrir ventana ordenar
        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdenar ordenar = new FormOrdenar();
            this.Hide();
            ordenar.ShowDialog();
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
