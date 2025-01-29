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

        //Bot�n para cargar un archivo distinto al cargado
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //Configuraci�n del cuadro de di�logo solo JPG
                ofd.Filter = "Archivos DAT (*.dat)|*.dat";
                ofd.Title = "Seleccione un archivo DAT";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Validar que el archivo sea dat (aunque el filtro ya lo limita)
                        if (Path.GetExtension(ofd.FileName).ToLower() != ".dat")
                        {
                            MessageBox.Show("Por favor, seleccione un archivo DAT v�lido.", "Formato no admitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        //Carga los datos
                        ctrlArtista.CargarDatos(ofd.FileName);

                        //Cargar la lista en el DataGrid
                        dgConsultar.DataSource = new List<Artista>();
                        dgConsultar.DataSource = ctrlArtista.ConsultarDatos();


                        MessageBox.Show("Archivo cargado con �xito", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar o guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Bot�n para guardar como
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                //Configuraci�n del cuadro de di�logo
                sfd.Filter = "Archivos DAT (*.dat)|*.dat";
                sfd.Title = "Guardar archivo como";

                //Mostrar el di�logo y procesar la selecci�n del usuario
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Obtener la ruta seleccionada
                        string rutaArchivo = sfd.FileName;

                        //Llamar a un m�todo que guarde los datos en la ruta especificada
                        ctrlArtista.EscribirDatos(rutaArchivo);

                        MessageBox.Show("Archivo guardado correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
