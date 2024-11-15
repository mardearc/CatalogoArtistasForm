namespace CatalogoArtistasForm
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            lblNombre = new Label();
            tbNombre = new TextBox();
            lblEdad = new Label();
            nbEdad = new NumericUpDown();
            tbGenero = new TextBox();
            lblGenero = new Label();
            tbNacionalidad = new TextBox();
            lblNacionalidad = new Label();
            gbTipo = new GroupBox();
            rbDeGrupo = new RadioButton();
            rbSolista = new RadioButton();
            tbCancion = new TextBox();
            nbPuntuacion = new NumericUpDown();
            lblPuntuacion = new Label();
            lblCancion = new Label();
            tbNombreTipo = new TextBox();
            lblNombreTipo = new Label();
            btnAdd = new Button();
            btnSubirFoto = new Button();
            pbImagen = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbEdad).BeginInit();
            gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, agregarToolStripMenuItem, ordenarToolStripMenuItem, buscarToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(85, 24);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(77, 24);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // ordenarToolStripMenuItem
            // 
            ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            ordenarToolStripMenuItem.Size = new Size(77, 24);
            ordenarToolStripMenuItem.Text = "Ordenar";
            ordenarToolStripMenuItem.Click += ordenarToolStripMenuItem_Click_1;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(66, 24);
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(77, 24);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(211, 74);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 3;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(39, 134);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // nbEdad
            // 
            nbEdad.Location = new Point(211, 127);
            nbEdad.Name = "nbEdad";
            nbEdad.Size = new Size(125, 27);
            nbEdad.TabIndex = 5;
            nbEdad.ValueChanged += nbEdad_ValueChanged;
            // 
            // tbGenero
            // 
            tbGenero.Location = new Point(211, 188);
            tbGenero.Name = "tbGenero";
            tbGenero.Size = new Size(125, 27);
            tbGenero.TabIndex = 7;
            tbGenero.TextChanged += tbGenero_TextChanged;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(39, 188);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 6;
            lblGenero.Text = "Género";
            // 
            // tbNacionalidad
            // 
            tbNacionalidad.Location = new Point(211, 238);
            tbNacionalidad.Name = "tbNacionalidad";
            tbNacionalidad.Size = new Size(125, 27);
            tbNacionalidad.TabIndex = 9;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(39, 241);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(98, 20);
            lblNacionalidad.TabIndex = 8;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // gbTipo
            // 
            gbTipo.Controls.Add(rbDeGrupo);
            gbTipo.Controls.Add(rbSolista);
            gbTipo.Location = new Point(424, 71);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(250, 125);
            gbTipo.TabIndex = 10;
            gbTipo.TabStop = false;
            gbTipo.Text = "Tipo";
            // 
            // rbDeGrupo
            // 
            rbDeGrupo.AutoSize = true;
            rbDeGrupo.Location = new Point(44, 65);
            rbDeGrupo.Name = "rbDeGrupo";
            rbDeGrupo.Size = new Size(94, 24);
            rbDeGrupo.TabIndex = 1;
            rbDeGrupo.Text = "De Grupo";
            rbDeGrupo.UseVisualStyleBackColor = true;
            rbDeGrupo.CheckedChanged += rbDeGrupo_CheckedChanged;
            // 
            // rbSolista
            // 
            rbSolista.AutoSize = true;
            rbSolista.Checked = true;
            rbSolista.Location = new Point(44, 23);
            rbSolista.Name = "rbSolista";
            rbSolista.Size = new Size(74, 24);
            rbSolista.TabIndex = 0;
            rbSolista.TabStop = true;
            rbSolista.Text = "Solista";
            rbSolista.UseVisualStyleBackColor = true;
            rbSolista.CheckedChanged += rbSolista_CheckedChanged;
            // 
            // tbCancion
            // 
            tbCancion.Location = new Point(211, 287);
            tbCancion.Name = "tbCancion";
            tbCancion.Size = new Size(125, 27);
            tbCancion.TabIndex = 12;
            tbCancion.TextChanged += textBox1_TextChanged;
            // 
            // nbPuntuacion
            // 
            nbPuntuacion.DecimalPlaces = 2;
            nbPuntuacion.Location = new Point(211, 338);
            nbPuntuacion.Name = "nbPuntuacion";
            nbPuntuacion.Size = new Size(125, 27);
            nbPuntuacion.TabIndex = 14;
            nbPuntuacion.ValueChanged += nbPuntuacion_ValueChanged;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(39, 345);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(82, 20);
            lblPuntuacion.TabIndex = 13;
            lblPuntuacion.Text = "Puntuación";
            // 
            // lblCancion
            // 
            lblCancion.AutoSize = true;
            lblCancion.Location = new Point(39, 290);
            lblCancion.Name = "lblCancion";
            lblCancion.Size = new Size(166, 20);
            lblCancion.TabIndex = 15;
            lblCancion.Text = "Canción más escuchada";
            lblCancion.Click += lblCancion_Click;
            // 
            // tbNombreTipo
            // 
            tbNombreTipo.Location = new Point(596, 223);
            tbNombreTipo.Name = "tbNombreTipo";
            tbNombreTipo.Size = new Size(125, 27);
            tbNombreTipo.TabIndex = 17;
            // 
            // lblNombreTipo
            // 
            lblNombreTipo.AutoSize = true;
            lblNombreTipo.Location = new Point(424, 226);
            lblNombreTipo.Name = "lblNombreTipo";
            lblNombreTipo.Size = new Size(114, 20);
            lblNombreTipo.TabIndex = 16;
            lblNombreTipo.Text = "Nombre de pila";
            lblNombreTipo.Click += lblNombreTipo_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(596, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Añadir";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Location = new Point(468, 307);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(94, 29);
            btnSubirFoto.TabIndex = 19;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = true;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(596, 290);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(61, 62);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 20;
            pbImagen.TabStop = false;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbImagen);
            Controls.Add(btnSubirFoto);
            Controls.Add(btnAdd);
            Controls.Add(tbNombreTipo);
            Controls.Add(lblNombreTipo);
            Controls.Add(lblCancion);
            Controls.Add(nbPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(tbCancion);
            Controls.Add(gbTipo);
            Controls.Add(tbNacionalidad);
            Controls.Add(lblNacionalidad);
            Controls.Add(tbGenero);
            Controls.Add(lblGenero);
            Controls.Add(nbEdad);
            Controls.Add(lblEdad);
            Controls.Add(tbNombre);
            Controls.Add(lblNombre);
            Controls.Add(menuStrip1);
            Name = "FormAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbEdad).EndInit();
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Label lblNombre;
        private TextBox tbNombre;
        private Label lblEdad;
        private NumericUpDown nbEdad;
        private TextBox tbGenero;
        private Label lblGenero;
        private TextBox tbNacionalidad;
        private Label lblNacionalidad;
        private GroupBox gbTipo;
        private RadioButton rbDeGrupo;
        private RadioButton rbSolista;
        private TextBox tbCancion;
        private NumericUpDown nbPuntuacion;
        private Label lblPuntuacion;
        private Label lblCancion;
        private TextBox tbNombreTipo;
        private Label lblNombreTipo;
        private Button btnAdd;
        private ToolStripComboBox toolStripComboBox1;
        private Button btnSubirFoto;
        private PictureBox pbImagen;
    }
}