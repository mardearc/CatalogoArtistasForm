using CatalogoArtistas.controller;
using CatalogoArtistas.model;
using CatalogoArtistasForm.model;

namespace CatalogoArtistasForm
{
    public partial class FormConsultar : Form
    {
        CtrlArtista ctrlArtista = CtrlArtista.GetControlador();
        public FormConsultar()
        {
            InitializeComponent();

            //Cargar los datos y mostrarlos en el DataGrid
            ctrlArtista.CargarDatos();
            if (ctrlArtista.ConsultarDatos().Count > 0)
            {
                dgConsultar.DataSource = ctrlArtista.ConsultarDatos();
            }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Cerrar esta ventana cuando se abra la de agregar
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

        //Cerrar esta ventana cuando se abra la de ordenar
        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdenar ordenar = new FormOrdenar();
            this.Hide();
            ordenar.ShowDialog();
            this.Close();
        }

        //Cerrar esta ventana cuando se abra la de eliminar
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminar borrarEmpleado = new FormEliminar();
            this.Hide();
            borrarEmpleado.ShowDialog();
            this.Close();
        }

        //Cerrar esta ventana cuando se abra la de abrir listado
        private void btnAbrirListado_Click(object sender, EventArgs e)
        {
            FormListado formListado = new FormListado();
            this.Hide();
            formListado.ShowDialog();
            this.Close();
        }

        //Cerrar esta ventana cuando se abra la de buscar
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscar buscarForm = new FormBuscar();
            this.Hide();
            buscarForm.ShowDialog();
            this.Close();
        }

        //Botón para cargar un archivo distinto al cargado
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //Configuración del cuadro de diálogo solo JPG
                ofd.Filter = "Archivos DAT (*.dat)|*.dat";
                ofd.Title = "Seleccione un archivo DAT";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Validar que el archivo sea dat (aunque el filtro ya lo limita)
                        if (Path.GetExtension(ofd.FileName).ToLower() != ".dat")
                        {
                            MessageBox.Show("Por favor, seleccione un archivo DAT válido.", "Formato no admitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        //Carga los datos
                        ctrlArtista.CargarDatos(ofd.FileName);

                        //Cargar la lista en el DataGrid
                        dgConsultar.DataSource = new List<Artista>();
                        dgConsultar.DataSource = ctrlArtista.ConsultarDatos();


                        MessageBox.Show("Archivo cargado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar o guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Botón para guardar como
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                //Configuración del cuadro de diálogo
                sfd.Filter = "Archivos DAT (*.dat)|*.dat";
                sfd.Title = "Guardar archivo como";

                //Mostrar el diálogo y procesar la selección del usuario
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Obtener la ruta seleccionada
                        string rutaArchivo = sfd.FileName;

                        //Llamar a un método que guarde los datos en la ruta especificada
                        ctrlArtista.EscribirDatos(rutaArchivo);

                        MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
