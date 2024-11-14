namespace CatalogoArtistasForm.model
{
    partial class FormListado
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
            components = new System.ComponentModel.Container();
            lbNombre = new Label();
            lbContNombre = new Label();
            lbEdad = new Label();
            lbContArtista = new Label();
            lblContEdad = new Label();
            btnPasar = new Button();
            lbContGenero = new Label();
            lbGenero = new Label();
            lbNacionalidad = new Label();
            lbContNacionalidad = new Label();
            btnVolver = new Button();
            lbPuntuacion = new Label();
            lbContPuntuacion = new Label();
            lbNombreTipo = new Label();
            lbContTipo = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            panelDatos = new Panel();
            groupBoxTipo = new GroupBox();
            rbDeGrupo = new RadioButton();
            rbSolista = new RadioButton();
            btnAceptar = new Button();
            tbCancion = new TextBox();
            nbPuntuacion = new NumericUpDown();
            tbTipo = new TextBox();
            tbNacionalidad = new TextBox();
            tbGenero = new TextBox();
            nbEdad = new NumericUpDown();
            tbNombre = new TextBox();
            pbImagen = new PictureBox();
            lbCancion = new Label();
            lbContCancion = new Label();
            btnAtras = new Button();
            bindingSource1 = new BindingSource(components);
            btnSubirFoto = new Button();
            panelDatos.SuspendLayout();
            groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nbEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(51, 60);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(67, 20);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre:";
            // 
            // lbContNombre
            // 
            lbContNombre.AutoSize = true;
            lbContNombre.Location = new Point(124, 60);
            lbContNombre.Name = "lbContNombre";
            lbContNombre.Size = new Size(0, 20);
            lbContNombre.TabIndex = 1;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(51, 97);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(46, 20);
            lbEdad.TabIndex = 2;
            lbEdad.Text = "Edad:";
            // 
            // lbContArtista
            // 
            lbContArtista.AutoSize = true;
            lbContArtista.Location = new Point(278, 411);
            lbContArtista.Name = "lbContArtista";
            lbContArtista.Size = new Size(50, 20);
            lbContArtista.TabIndex = 3;
            lbContArtista.Text = "1 de 1";
            // 
            // lblContEdad
            // 
            lblContEdad.AutoSize = true;
            lblContEdad.Location = new Point(103, 97);
            lblContEdad.Name = "lblContEdad";
            lblContEdad.Size = new Size(0, 20);
            lblContEdad.TabIndex = 4;
            // 
            // btnPasar
            // 
            btnPasar.Location = new Point(514, 375);
            btnPasar.Name = "btnPasar";
            btnPasar.Size = new Size(37, 29);
            btnPasar.TabIndex = 5;
            btnPasar.Text = ">";
            btnPasar.UseVisualStyleBackColor = true;
            btnPasar.Click += btnPasar_Click;
            // 
            // lbContGenero
            // 
            lbContGenero.AutoSize = true;
            lbContGenero.Location = new Point(124, 133);
            lbContGenero.Name = "lbContGenero";
            lbContGenero.Size = new Size(0, 20);
            lbContGenero.TabIndex = 7;
            // 
            // lbGenero
            // 
            lbGenero.AutoSize = true;
            lbGenero.Location = new Point(51, 133);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(60, 20);
            lbGenero.TabIndex = 6;
            lbGenero.Text = "Género:";
            // 
            // lbNacionalidad
            // 
            lbNacionalidad.AutoSize = true;
            lbNacionalidad.Location = new Point(51, 164);
            lbNacionalidad.Name = "lbNacionalidad";
            lbNacionalidad.Size = new Size(101, 20);
            lbNacionalidad.TabIndex = 8;
            lbNacionalidad.Text = "Nacionalidad:";
            // 
            // lbContNacionalidad
            // 
            lbContNacionalidad.AutoSize = true;
            lbContNacionalidad.Location = new Point(155, 164);
            lbContNacionalidad.Name = "lbContNacionalidad";
            lbContNacionalidad.Size = new Size(0, 20);
            lbContNacionalidad.TabIndex = 9;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(71, 375);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(37, 29);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "<";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lbPuntuacion
            // 
            lbPuntuacion.AutoSize = true;
            lbPuntuacion.Location = new Point(51, 234);
            lbPuntuacion.Name = "lbPuntuacion";
            lbPuntuacion.Size = new Size(85, 20);
            lbPuntuacion.TabIndex = 11;
            lbPuntuacion.Text = "Puntuación:";
            // 
            // lbContPuntuacion
            // 
            lbContPuntuacion.AutoSize = true;
            lbContPuntuacion.Location = new Point(136, 233);
            lbContPuntuacion.Name = "lbContPuntuacion";
            lbContPuntuacion.Size = new Size(0, 20);
            lbContPuntuacion.TabIndex = 12;
            // 
            // lbNombreTipo
            // 
            lbNombreTipo.AutoSize = true;
            lbNombreTipo.Location = new Point(51, 270);
            lbNombreTipo.Name = "lbNombreTipo";
            lbNombreTipo.Size = new Size(116, 20);
            lbNombreTipo.TabIndex = 13;
            lbNombreTipo.Text = "Nombre de Pila:";
            // 
            // lbContTipo
            // 
            lbContTipo.AutoSize = true;
            lbContTipo.Location = new Point(183, 270);
            lbContTipo.Name = "lbContTipo";
            lbContTipo.Size = new Size(0, 20);
            lbContTipo.TabIndex = 14;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(345, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(168, 375);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(btnSubirFoto);
            panelDatos.Controls.Add(groupBoxTipo);
            panelDatos.Controls.Add(btnAceptar);
            panelDatos.Controls.Add(tbCancion);
            panelDatos.Controls.Add(nbPuntuacion);
            panelDatos.Controls.Add(tbTipo);
            panelDatos.Controls.Add(tbNacionalidad);
            panelDatos.Controls.Add(tbGenero);
            panelDatos.Controls.Add(nbEdad);
            panelDatos.Controls.Add(tbNombre);
            panelDatos.Location = new Point(33, 49);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(447, 263);
            panelDatos.TabIndex = 17;
            panelDatos.Visible = false;
            // 
            // groupBoxTipo
            // 
            groupBoxTipo.Controls.Add(rbDeGrupo);
            groupBoxTipo.Controls.Add(rbSolista);
            groupBoxTipo.Location = new Point(308, 15);
            groupBoxTipo.Name = "groupBoxTipo";
            groupBoxTipo.Size = new Size(133, 125);
            groupBoxTipo.TabIndex = 28;
            groupBoxTipo.TabStop = false;
            groupBoxTipo.Text = "Tipo";
            // 
            // rbDeGrupo
            // 
            rbDeGrupo.AutoSize = true;
            rbDeGrupo.Location = new Point(10, 71);
            rbDeGrupo.Name = "rbDeGrupo";
            rbDeGrupo.Size = new Size(94, 24);
            rbDeGrupo.TabIndex = 1;
            rbDeGrupo.TabStop = true;
            rbDeGrupo.Text = "De Grupo";
            rbDeGrupo.UseVisualStyleBackColor = true;
            rbDeGrupo.CheckedChanged += rbDeGrupo_CheckedChanged;
            // 
            // rbSolista
            // 
            rbSolista.AutoSize = true;
            rbSolista.Checked = true;
            rbSolista.Location = new Point(10, 32);
            rbSolista.Name = "rbSolista";
            rbSolista.Size = new Size(74, 24);
            rbSolista.TabIndex = 0;
            rbSolista.TabStop = true;
            rbSolista.Text = "Solista";
            rbSolista.UseVisualStyleBackColor = true;
            rbSolista.CheckedChanged += rbSolista_CheckedChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(326, 215);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 27;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // tbCancion
            // 
            tbCancion.Location = new Point(160, 149);
            tbCancion.Name = "tbCancion";
            tbCancion.Size = new Size(125, 27);
            tbCancion.TabIndex = 26;
            // 
            // nbPuntuacion
            // 
            nbPuntuacion.DecimalPlaces = 2;
            nbPuntuacion.Location = new Point(161, 184);
            nbPuntuacion.Name = "nbPuntuacion";
            nbPuntuacion.Size = new Size(125, 27);
            nbPuntuacion.TabIndex = 25;
            // 
            // tbTipo
            // 
            tbTipo.Location = new Point(161, 217);
            tbTipo.Name = "tbTipo";
            tbTipo.Size = new Size(125, 27);
            tbTipo.TabIndex = 24;
            // 
            // tbNacionalidad
            // 
            tbNacionalidad.Location = new Point(161, 113);
            tbNacionalidad.Name = "tbNacionalidad";
            tbNacionalidad.Size = new Size(125, 27);
            tbNacionalidad.TabIndex = 23;
            // 
            // tbGenero
            // 
            tbGenero.Location = new Point(161, 83);
            tbGenero.Name = "tbGenero";
            tbGenero.Size = new Size(125, 27);
            tbGenero.TabIndex = 22;
            // 
            // nbEdad
            // 
            nbEdad.Location = new Point(161, 50);
            nbEdad.Name = "nbEdad";
            nbEdad.Size = new Size(124, 27);
            nbEdad.TabIndex = 21;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(161, 9);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 20;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(486, 49);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(219, 263);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 21;
            pbImagen.TabStop = false;
            // 
            // lbCancion
            // 
            lbCancion.AutoSize = true;
            lbCancion.Location = new Point(51, 202);
            lbCancion.Name = "lbCancion";
            lbCancion.Size = new Size(65, 20);
            lbCancion.TabIndex = 18;
            lbCancion.Text = "Canción:";
            // 
            // lbContCancion
            // 
            lbContCancion.AutoSize = true;
            lbContCancion.Location = new Point(124, 202);
            lbContCancion.Name = "lbContCancion";
            lbContCancion.Size = new Size(0, 20);
            lbContCancion.TabIndex = 19;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(680, 407);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 29);
            btnAtras.TabIndex = 20;
            btnAtras.Text = "Volver";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Location = new Point(326, 164);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(94, 29);
            btnSubirFoto.TabIndex = 29;
            btnSubirFoto.Text = "Subir Foto";
            btnSubirFoto.UseVisualStyleBackColor = true;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // FormListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbImagen);
            Controls.Add(btnAtras);
            Controls.Add(lbNombreTipo);
            Controls.Add(lbPuntuacion);
            Controls.Add(lbNacionalidad);
            Controls.Add(lbGenero);
            Controls.Add(lbEdad);
            Controls.Add(lbNombre);
            Controls.Add(lbCancion);
            Controls.Add(panelDatos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lbContTipo);
            Controls.Add(lbContPuntuacion);
            Controls.Add(btnVolver);
            Controls.Add(lbContNacionalidad);
            Controls.Add(lbContGenero);
            Controls.Add(btnPasar);
            Controls.Add(lblContEdad);
            Controls.Add(lbContArtista);
            Controls.Add(lbContNombre);
            Controls.Add(lbContCancion);
            Name = "FormListado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListado";
            Load += FormListado_Load;
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            groupBoxTipo.ResumeLayout(false);
            groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbPuntuacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nbEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombre;
        private Label lbContNombre;
        private Label lbEdad;
        private Label lbContArtista;
        private Label lblContEdad;
        private Button btnPasar;
        private Label lbContGenero;
        private Label lbGenero;
        private Label lbNacionalidad;
        private Label lbContNacionalidad;
        private Button btnVolver;
        private Label lbPuntuacion;
        private Label lbContPuntuacion;
        private Label lbNombreTipo;
        private Label lbContTipo;
        private Button btnEliminar;
        private Button btnModificar;
        private Panel panelDatos;
        private NumericUpDown nbPuntuacion;
        private TextBox tbTipo;
        private TextBox tbNacionalidad;
        private TextBox tbGenero;
        private NumericUpDown nbEdad;
        private TextBox tbNombre;
        private Label lbCancion;
        private Label lbContCancion;
        private TextBox tbCancion;
        private Button btnAceptar;
        private GroupBox groupBoxTipo;
        private RadioButton rbDeGrupo;
        private RadioButton rbSolista;
        private Button btnAtras;
        private BindingSource bindingSource1;
        private PictureBox pbImagen;
        private Button btnSubirFoto;
    }
}