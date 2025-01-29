namespace CatalogoArtistasForm
{
    partial class FormEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminar));
            menuStrip1 = new MenuStrip();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            btnBuscar = new Button();
            tbNombreTipo = new TextBox();
            lblNombreTipo = new Label();
            lblCancion = new Label();
            nbPuntuacion = new NumericUpDown();
            lblPuntuacion = new Label();
            tbCancion = new TextBox();
            tbNacionalidad = new TextBox();
            lblNacionalidad = new Label();
            tbGenero = new TextBox();
            lblGenero = new Label();
            nbEdad = new NumericUpDown();
            lblEdad = new Label();
            tbNombre = new TextBox();
            lblNombre = new Label();
            btnBorrar = new Button();
            fontDialog1 = new FontDialog();
            lbBorrar = new ListBox();
            cbDeGrupo = new CheckBox();
            cbSolista = new CheckBox();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbEdad).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, agregarToolStripMenuItem, ordenarToolStripMenuItem, buscarToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(390, 28);
            menuStrip1.TabIndex = 6;
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
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // ordenarToolStripMenuItem
            // 
            ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            ordenarToolStripMenuItem.Size = new Size(77, 24);
            ordenarToolStripMenuItem.Text = "Ordenar";
            ordenarToolStripMenuItem.Click += ordenarToolStripMenuItem_Click;
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
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(629, 330);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbNombreTipo
            // 
            tbNombreTipo.Location = new Point(188, 125);
            tbNombreTipo.Name = "tbNombreTipo";
            tbNombreTipo.Size = new Size(125, 27);
            tbNombreTipo.TabIndex = 33;
            tbNombreTipo.Visible = false;
            // 
            // lblNombreTipo
            // 
            lblNombreTipo.AutoSize = true;
            lblNombreTipo.Location = new Point(43, 128);
            lblNombreTipo.Name = "lblNombreTipo";
            lblNombreTipo.Size = new Size(114, 20);
            lblNombreTipo.TabIndex = 32;
            lblNombreTipo.Text = "Nombre de pila";
            lblNombreTipo.Visible = false;
            // 
            // lblCancion
            // 
            lblCancion.AutoSize = true;
            lblCancion.Location = new Point(53, 274);
            lblCancion.Name = "lblCancion";
            lblCancion.Size = new Size(166, 20);
            lblCancion.TabIndex = 31;
            lblCancion.Text = "Canción más escuchada";
            // 
            // nbPuntuacion
            // 
            nbPuntuacion.DecimalPlaces = 2;
            nbPuntuacion.Location = new Point(598, 54);
            nbPuntuacion.Name = "nbPuntuacion";
            nbPuntuacion.Size = new Size(125, 27);
            nbPuntuacion.TabIndex = 30;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(426, 61);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(82, 20);
            lblPuntuacion.TabIndex = 29;
            lblPuntuacion.Text = "Puntuación";
            // 
            // tbCancion
            // 
            tbCancion.Location = new Point(225, 271);
            tbCancion.Name = "tbCancion";
            tbCancion.Size = new Size(125, 27);
            tbCancion.TabIndex = 28;
            // 
            // tbNacionalidad
            // 
            tbNacionalidad.Location = new Point(225, 222);
            tbNacionalidad.Name = "tbNacionalidad";
            tbNacionalidad.Size = new Size(125, 27);
            tbNacionalidad.TabIndex = 26;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Location = new Point(53, 225);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(98, 20);
            lblNacionalidad.TabIndex = 25;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // tbGenero
            // 
            tbGenero.Location = new Point(225, 172);
            tbGenero.Name = "tbGenero";
            tbGenero.Size = new Size(125, 27);
            tbGenero.TabIndex = 24;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(53, 172);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 23;
            lblGenero.Text = "Género";
            // 
            // nbEdad
            // 
            nbEdad.Location = new Point(225, 111);
            nbEdad.Name = "nbEdad";
            nbEdad.Size = new Size(125, 27);
            nbEdad.TabIndex = 22;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(53, 118);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 21;
            lblEdad.Text = "Edad";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(225, 58);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(53, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(629, 375);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 36;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lbBorrar
            // 
            lbBorrar.FormattingEnabled = true;
            lbBorrar.HorizontalScrollbar = true;
            lbBorrar.Location = new Point(55, 319);
            lbBorrar.Name = "lbBorrar";
            lbBorrar.Size = new Size(543, 104);
            lbBorrar.TabIndex = 35;
            // 
            // cbDeGrupo
            // 
            cbDeGrupo.AutoSize = true;
            cbDeGrupo.Location = new Point(43, 86);
            cbDeGrupo.Name = "cbDeGrupo";
            cbDeGrupo.Size = new Size(95, 24);
            cbDeGrupo.TabIndex = 57;
            cbDeGrupo.Text = "De Grupo";
            cbDeGrupo.UseVisualStyleBackColor = true;
            cbDeGrupo.CheckedChanged += cbDeGrupo_CheckedChanged;
            // 
            // cbSolista
            // 
            cbSolista.AutoSize = true;
            cbSolista.Location = new Point(43, 47);
            cbSolista.Name = "cbSolista";
            cbSolista.Size = new Size(75, 24);
            cbSolista.TabIndex = 56;
            cbSolista.Text = "Solista";
            cbSolista.UseVisualStyleBackColor = true;
            cbSolista.CheckedChanged += cbSolista_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSolista);
            groupBox1.Controls.Add(cbDeGrupo);
            groupBox1.Controls.Add(lblNombreTipo);
            groupBox1.Controls.Add(tbNombreTipo);
            groupBox1.Location = new Point(426, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 187);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnBorrar);
            Controls.Add(lbBorrar);
            Controls.Add(btnBuscar);
            Controls.Add(lblCancion);
            Controls.Add(nbPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(tbCancion);
            Controls.Add(tbNacionalidad);
            Controls.Add(lblNacionalidad);
            Controls.Add(tbGenero);
            Controls.Add(lblGenero);
            Controls.Add(nbEdad);
            Controls.Add(lblEdad);
            Controls.Add(tbNombre);
            Controls.Add(lblNombre);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrarEmpleado";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbEdad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnBuscar;
        private TextBox tbNombreTipo;
        private Label lblNombreTipo;
        private Label lblCancion;
        private NumericUpDown nbPuntuacion;
        private Label lblPuntuacion;
        private TextBox tbCancion;
        private TextBox tbNacionalidad;
        private Label lblNacionalidad;
        private TextBox tbGenero;
        private Label lblGenero;
        private NumericUpDown nbEdad;
        private Label lblEdad;
        private TextBox tbNombre;
        private Label lblNombre;
        private Button btnBorrar;
        private FontDialog fontDialog1;
        private ListBox lbBorrar;
        private CheckBox cbDeGrupo;
        private CheckBox cbSolista;
        private GroupBox groupBox1;
    }
}