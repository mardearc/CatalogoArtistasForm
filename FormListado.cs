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
    public partial class FormListado : Form
    {
        CtrlArtista ctrlArtista = CtrlArtista.GetControlador();
        int cont = 0;
        int max = 0;
        List<Artista> artistas = new List<Artista>();
        public FormListado()
        {
            InitializeComponent();

            //Cargar los datos del fichero
            ctrlArtista.CargarDatos();
            artistas = ctrlArtista.ConsultarDatos();
            max = artistas.Count;
            lbContArtista.Text = $"{cont + 1} de {max}";


            //Cargar datos en el formulario
            Cargar();


            btnPasar.Enabled = cont < max - 1;

            btnVolver.Enabled = !(cont <= 0);

        }
        //Botón para ir a un artista posterior
        private void btnPasar_Click(object sender, EventArgs e)
        {
            if (cont < max - 1)
            {
                cont++;
            }

            Cargar();

            btnPasar.Enabled = cont < max - 1;

            btnVolver.Enabled = !(cont <= 0);
        }
        //Métood para cargar el artista
        private void Cargar()
        {
            string rutaImagen = "";
            if (artistas.Count > 0)
            {
                rutaImagen = $"images/{artistas[cont].Id}.jpg";

                // Liberar cualquier imagen previamente cargada.
                if (pbImagen.Image != null)
                {
                    pbImagen.Image.Dispose();
                    pbImagen.Image = null;
                }

                if (File.Exists(rutaImagen))
                {
                    pbImagen.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    pbImagen.Image = Image.FromFile("images/default.jpg");
                }

                lbContArtista.Text = $"{cont + 1} de {max}";
                lbContNombre.Text = artistas[cont].Nombre;
                lblContEdad.Text = artistas[cont].Edad.ToString();
                lbContGenero.Text = artistas[cont].Genero;
                lbContNacionalidad.Text = artistas[cont].Nacionalidad;
                lbContCancion.Text = artistas[cont].CancionMasEscuchada;
                lbContPuntuacion.Text = artistas[cont].Puntuacion.ToString();

                if (artistas[cont] is Solista solista)
                {
                    lbNombreTipo.Text = "Nombre de pila:";
                    lbContTipo.Text = solista.NombrePila;
                }
                else if (artistas[cont] is DeGrupo degrupo)
                {
                    lbNombreTipo.Text = "Nombre de grupo:";
                    lbContTipo.Text = degrupo.NombreGrupo;
                }
            }
        }
        //Botón para eliminar un artista
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show($"¿Seguro que quiere borrar el artista?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                List<Artista> eliminar = new List<Artista>();
                eliminar.Add(artistas[cont]);

                try
                {
                    string rutaImagen = $"images/{artistas[cont].Id}.jpg";
                    // Liberar la imagen antes de eliminar el archivo.
                    if (pbImagen.Image != null)
                    {
                        pbImagen.Image.Dispose();
                        pbImagen.Image = null;
                    }
                    ctrlArtista.EliminarArtista(eliminar);
                    max--;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo eliminar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                if (max == 0) // Si no hay elementos en la lista, cierra el formulario
                {
                    this.Close();
                }
                if (cont == max) // Si se borra el último elemento, muestra el anterior
                {
                    cont--;
                }
                Cargar();
            }
        }
        //Botón para ir a un artista anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                cont--;
            }

            Cargar();


            btnPasar.Enabled = cont < max - 1;

            btnVolver.Enabled = !(cont <= 0);
        }


        //Botón para modificar artista
        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelDatos.Visible = true;

            tbNombre.Text = lbContNombre.Text.Trim();
            nbEdad.Value = Int32.Parse(lblContEdad.Text.Trim());
            tbGenero.Text = lbContGenero.Text.Trim();
            tbNacionalidad.Text = lbContNacionalidad.Text.Trim();
            tbCancion.Text = lbContCancion.Text.Trim();
            nbPuntuacion.Value = Decimal.Parse(lbContPuntuacion.Text.Trim());
            tbTipo.Text = lbContTipo.Text.Trim();

            if (artistas[cont] is Solista solista)
            {
                rbSolista.Checked = true;
            }
            else if (artistas[cont] is DeGrupo degrupo)
            {
                rbDeGrupo.Checked = true;
            }

            btnEliminar.Enabled = false;
            btnPasar.Enabled = false;
            btnVolver.Enabled = false;
            btnModificar.Enabled = false;
            btnAtras.Enabled = false;
            pbImagen.Visible = false;


        }

        //Botón aceptar modificación
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Artista a;
            string Nombre = tbNombre.Text;
            int Edad = Int32.Parse(nbEdad.Value.ToString());
            string Genero = tbGenero.Text;
            string Nacionalidad = tbNacionalidad.Text;
            string Cancion = tbCancion.Text;
            double Puntuacion = Double.Parse(nbPuntuacion.Value.ToString());
            string NombreTipo = tbTipo.Text;
            int id = artistas[cont].Id;



            if (rbSolista.Checked)
            {

                Solista solista = new(Nombre, Edad, Genero, Nacionalidad, Cancion, Puntuacion, id, NombreTipo);
                a = solista;
            }
            else
            {
                DeGrupo deGrupo = new(Nombre, Edad, Genero, Nacionalidad, Cancion, Puntuacion, id, NombreTipo);
                a = deGrupo;
            }

            ctrlArtista.Modificar(cont, a);
            Cargar();

            btnEliminar.Enabled = true;
            btnPasar.Enabled = true;
            btnVolver.Enabled = true;
            btnModificar.Enabled = true;
            btnAtras.Enabled = true;
            pbImagen.Visible = true;

            panelDatos.Visible = false;
        }
        //Si es solista se elige el nombre de pila
        private void rbSolista_CheckedChanged(object sender, EventArgs e)
        {
            lbNombreTipo.Text = "Nombre de pila:";
        }
        //si es de grupo se elige el nombre de grupo
        private void rbDeGrupo_CheckedChanged(object sender, EventArgs e)
        {
            lbNombreTipo.Text = "Nombre de grupo:";
        }

        private void FormListado_Load(object sender, EventArgs e)
        {

        }
        //Cerrar este formulario, liberar la imagen
        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Liberar la imagen antes de cerrar el formulario
            if (pbImagen.Image != null)
            {
                pbImagen.Image.Dispose();
                pbImagen.Image = null;
            }
            FormConsultar form = new FormConsultar();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        //Botón para subir la foto
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            string rutaImagen = $"images/{artistas[cont].Id}.jpg";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Configuración del cuadro de diálogo para solo JPG
                ofd.Filter = "Archivos JPG (*.jpg)|*.jpg";
                ofd.Title = "Seleccione una imagen JPG";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Validar que el archivo sea JPG (aunque el filtro ya lo limita)
                        if (Path.GetExtension(ofd.FileName).ToLower() != ".jpg")
                        {
                            MessageBox.Show("Por favor, seleccione un archivo JPG válido.", "Formato no admitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Mostrar la imagen en el PictureBox
                        pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                        pbImagen.Image = Image.FromFile(ofd.FileName);

                        // Copiar la imagen al directorio de la aplicación con el nombre basado en cont
                        File.Copy(ofd.FileName, rutaImagen, true);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar o guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
