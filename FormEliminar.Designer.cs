﻿namespace CatalogoArtistasForm
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
            gbTipo = new GroupBox();
            rbDeGrupo = new RadioButton();
            rbSolista = new RadioButton();
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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).BeginInit();
            gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbEdad).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, agregarToolStripMenuItem, ordenarToolStripMenuItem, buscarToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(540, 28);
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
            tbNombreTipo.Location = new Point(598, 281);
            tbNombreTipo.Name = "tbNombreTipo";
            tbNombreTipo.Size = new Size(125, 27);
            tbNombreTipo.TabIndex = 33;
            // 
            // lblNombreTipo
            // 
            lblNombreTipo.AutoSize = true;
            lblNombreTipo.Location = new Point(426, 284);
            lblNombreTipo.Name = "lblNombreTipo";
            lblNombreTipo.Size = new Size(114, 20);
            lblNombreTipo.TabIndex = 32;
            lblNombreTipo.Text = "Nombre de pila";
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
            // gbTipo
            // 
            gbTipo.Controls.Add(rbDeGrupo);
            gbTipo.Controls.Add(rbSolista);
            gbTipo.Location = new Point(426, 118);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(250, 125);
            gbTipo.TabIndex = 27;
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
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(lbBorrar);
            Controls.Add(btnBuscar);
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
            Name = "FormEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrarEmpleado";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).EndInit();
            gbTipo.ResumeLayout(false);
            gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbEdad).EndInit();
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
        private GroupBox gbTipo;
        private RadioButton rbDeGrupo;
        private RadioButton rbSolista;
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
    }
}