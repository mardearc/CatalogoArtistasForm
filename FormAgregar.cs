using CatalogoArtistas.controller;
using CatalogoArtistas.model;
using CatalogoArtistasForm.model;

namespace CatalogoArtistasForm
{
    public partial class FormAgregar : Form
    {
        CtrlArtista ctrlArtista = CtrlArtista.GetControlador();

        String rutaOrigen = "";
        public FormAgregar()
        {
            InitializeComponent();

            //Asignar imagen por defecto a el PictureBox
            pbImagen.Image = Image.FromFile("images/default.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void tbGenero_TextChanged(object sender, EventArgs e)
        {

        }

        //Controlar que la edad no sea mayor a 120
        private void nbEdad_ValueChanged(object sender, EventArgs e)
        {
            if (nbEdad.Value >= 120)
            {
                nbEdad.Value = 120;
            }
        }

        private void lblCancion_Click(object sender, EventArgs e)
        {

        }

        //Método para poner la puntuación a 10 si se pone un número mayor
        private void nbPuntuacion_ValueChanged(object sender, EventArgs e)
        {
            if (nbPuntuacion.Value >= 10)
            {
                nbPuntuacion.Value = 10;
            }
        }

        //Cambiar el texto del label si se selecciona el radio button solista
        private void rbSolista_CheckedChanged(object sender, EventArgs e)
        {
            lblNombreTipo.Text = "Nombre de pila";
        }
        //Cambiar el texto del label si se selecciona el radio button de grupo
        private void rbDeGrupo_CheckedChanged(object sender, EventArgs e)
        {
            lblNombreTipo.Text = "Nombre del grupo";
        }

        private void lblNombreTipo_Click(object sender, EventArgs e)
        {

        }

        //Método para añadir un nuevo artista
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Artista a;


            string Nombre = "";
            int Edad = 0;
            string Genero = "";
            string Nacionalidad = "";
            string Cancion = "";
            double Puntuacion = 0;
            string NombreTipo = "";
            bool correcto = true;

            //Comprobar que ha introducido un nombre
            if (tbNombre.Text.Length > 0)
            {
                Nombre = tbNombre.Text;
                tbNombre.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                MessageBox.Show("Debe asignar un nombre", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombre.BackColor = Color.Red;
                correcto = false;
            }
            if (nbEdad.Text != "0") //Comprobar que ha introducido una edad
            {
                Edad = Int32.Parse(nbEdad.Value.ToString());
                nbEdad.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                MessageBox.Show("Debe asignar una edad", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nbEdad.BackColor = Color.Red;
                correcto = false;
            }
            if (tbGenero.Text.Length > 0)  //Comprobar que ha introducido un género
            {
                Genero = tbGenero.Text;
                tbGenero.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                MessageBox.Show("Debe asignar un género", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbGenero.BackColor = Color.Red;
                correcto = false;
            }
            if (tbNacionalidad.Text.Length > 0)  //Comprobar que ha introducido una nacionalidad
            {
                Nacionalidad = tbNacionalidad.Text;
                tbNacionalidad.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                MessageBox.Show("Debe asignar una nacionalidad", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNacionalidad.BackColor = Color.Red;
                correcto = false;
            }
            if (tbCancion.Text.Length > 0)  //Comprobar que ha introducido una canción
            {
                Cancion = tbCancion.Text;
                tbCancion.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                MessageBox.Show("Debe asignar una canción", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCancion.BackColor = Color.Red;
                correcto = false;
            }
            if (nbPuntuacion.Text != "0,00") //Comprobar que ha introducido una puntuación
            {
                Puntuacion = Double.Parse(nbPuntuacion.Value.ToString());
                nbPuntuacion.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                MessageBox.Show("Debe asignar una puntuación", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nbPuntuacion.BackColor = Color.Red;
                correcto = false;
            }
            if (tbNombreTipo.Text.Length > 0)  //Comprobar que ha introducido un nombre de tipo
            {
                NombreTipo = tbNombreTipo.Text;
                tbNombreTipo.BackColor = Color.White;
            }
            else //Lanzar MessageBox de error si no cumple condición
            {
                string Tipo = rbDeGrupo.Checked ? "de grupo" : "de pila";
                MessageBox.Show($"Debe asignar un nombre {Tipo}", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNombreTipo.BackColor = Color.Red;
                correcto = false;
            }

            if (correcto)  //Si esta todo bien introducido se añade a la lista el artista
            {
                if (rbSolista.Checked)
                {
                    Solista solista = new(Nombre, Edad, Genero, Nacionalidad, Cancion, Puntuacion, NombreTipo);
                    a = solista;
                }
                else
                {
                    DeGrupo deGrupo = new(Nombre, Edad, Genero, Nacionalidad, Cancion, Puntuacion, NombreTipo);
                    a = deGrupo;
                }


                //Añadir artista a la lista
                ctrlArtista.AddArtista(a);

                //Si se ha añadido foto se guarda con el mismo id que el del artista
                if (rutaOrigen.Length > 0)
                {
                    string rutaImagen = $"images/{Utils.GenerarNuevoId() - 1}.jpg";
                    File.Copy(rutaOrigen, rutaImagen, true);
                }

                // Liberar la imagen al aceptar
                if (pbImagen.Image != null)
                {
                    pbImagen.Image.Dispose();
                    pbImagen.Image = Image.FromFile("images/default.jpg");
                }

                //Poner textfields en blanco
                tbNombre.Text = "";
                nbEdad.Value = 0;
                tbGenero.Text = "";
                tbNacionalidad.Text = "";
                tbCancion.Text = "";
                nbPuntuacion.Value = 0;
                tbNombreTipo.Text = "";

                MessageBox.Show("Artista añadido", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Cerrar esta ventana si se abre la de consultar
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultar form = new FormConsultar();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }


        //Cerrar esta ventana si se abre la de ordenar
        private void ordenarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormOrdenar ordenar = new FormOrdenar();
            this.Hide();
            ordenar.ShowDialog();
            this.Close();
        }
        //Cerrar esta ventana si se abre la de eliminar
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar borrarEmpleado = new FormEliminar();
            this.Hide();
            borrarEmpleado.ShowDialog();
            this.Close();
        }
        //Cerrar esta ventana si se abre la de buscar
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscar buscarForm = new FormBuscar();
            this.Hide();
            buscarForm.ShowDialog();
            this.Close();
        }

        //Botón para subir foto
        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            //Ruta en la que se va a guardar la imagen
            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // Configuración del cuadro de diálogo solo JPG
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

                        rutaOrigen = ofd.FileName;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar o guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
