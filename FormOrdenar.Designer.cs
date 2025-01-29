namespace CatalogoArtistasForm
{
    partial class FormOrdenar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenar));
            btnNombre = new Button();
            btnEdad = new Button();
            menuStrip1 = new MenuStrip();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            ordenarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            btnGenero = new Button();
            btnNacionalidad = new Button();
            btnCancion = new Button();
            btnPuntuacion = new Button();
            dgOrdenar = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrdenar).BeginInit();
            SuspendLayout();
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(38, 37);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(94, 29);
            btnNombre.TabIndex = 3;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnEdad
            // 
            btnEdad.Location = new Point(154, 37);
            btnEdad.Name = "btnEdad";
            btnEdad.Size = new Size(94, 29);
            btnEdad.TabIndex = 4;
            btnEdad.Text = "Edad";
            btnEdad.UseVisualStyleBackColor = true;
            btnEdad.Click += btnEdad_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, agregarToolStripMenuItem, ordenarToolStripMenuItem, buscarToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(390, 28);
            menuStrip1.TabIndex = 5;
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
            // btnGenero
            // 
            btnGenero.Location = new Point(274, 37);
            btnGenero.Name = "btnGenero";
            btnGenero.Size = new Size(94, 29);
            btnGenero.TabIndex = 6;
            btnGenero.Text = "Género";
            btnGenero.UseVisualStyleBackColor = true;
            btnGenero.Click += btnGenero_Click;
            // 
            // btnNacionalidad
            // 
            btnNacionalidad.Location = new Point(392, 37);
            btnNacionalidad.Name = "btnNacionalidad";
            btnNacionalidad.Size = new Size(112, 29);
            btnNacionalidad.TabIndex = 7;
            btnNacionalidad.Text = "Nacionalidad";
            btnNacionalidad.UseVisualStyleBackColor = true;
            btnNacionalidad.Click += btnNacionalidad_Click;
            // 
            // btnCancion
            // 
            btnCancion.Location = new Point(533, 37);
            btnCancion.Name = "btnCancion";
            btnCancion.Size = new Size(94, 29);
            btnCancion.TabIndex = 8;
            btnCancion.Text = "Canción";
            btnCancion.UseVisualStyleBackColor = true;
            btnCancion.Click += btnCancion_Click;
            // 
            // btnPuntuacion
            // 
            btnPuntuacion.Location = new Point(658, 37);
            btnPuntuacion.Name = "btnPuntuacion";
            btnPuntuacion.Size = new Size(94, 29);
            btnPuntuacion.TabIndex = 9;
            btnPuntuacion.Text = "Puntuación";
            btnPuntuacion.UseVisualStyleBackColor = true;
            btnPuntuacion.Click += btnPuntuacion_Click;
            // 
            // dgOrdenar
            // 
            dgOrdenar.AllowUserToAddRows = false;
            dgOrdenar.AllowUserToDeleteRows = false;
            dgOrdenar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrdenar.Location = new Point(12, 72);
            dgOrdenar.Name = "dgOrdenar";
            dgOrdenar.ReadOnly = true;
            dgOrdenar.RowHeadersWidth = 51;
            dgOrdenar.Size = new Size(776, 366);
            dgOrdenar.TabIndex = 10;
            // 
            // FormOrdenar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgOrdenar);
            Controls.Add(btnPuntuacion);
            Controls.Add(btnCancion);
            Controls.Add(btnNacionalidad);
            Controls.Add(btnGenero);
            Controls.Add(menuStrip1);
            Controls.Add(btnEdad);
            Controls.Add(btnNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormOrdenar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrdenar";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgOrdenar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNombre;
        private Button btnEdad;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem ordenarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnGenero;
        private Button btnNacionalidad;
        private Button btnCancion;
        private Button btnPuntuacion;
        private DataGridView dgOrdenar;
    }
}