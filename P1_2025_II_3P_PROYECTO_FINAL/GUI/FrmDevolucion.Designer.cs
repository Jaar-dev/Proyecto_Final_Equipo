namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    partial class FrmDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDevolucion));
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1300, 970);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.txtMultaAplicada = new System.Windows.Forms.TextBox();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
            this.txtIDdevolucion = new System.Windows.Forms.TextBox();
            this.lblMultaAplicada = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIDdevolucion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.numericUsuario = new System.Windows.Forms.NumericUpDown();
            this.numericULibro = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaObservacion = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericULibro)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1253, 35);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(90, 62);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(152, 138);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.Location = new System.Drawing.Point(250, 122);
            this.lblDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(170, 33);
            this.lblDevolucion.TabIndex = 84;
            this.lblDevolucion.Text = "Devolución";
            // 
            // txtMultaAplicada
            // 
            this.txtMultaAplicada.Location = new System.Drawing.Point(254, 585);
            this.txtMultaAplicada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMultaAplicada.Name = "txtMultaAplicada";
            this.txtMultaAplicada.Size = new System.Drawing.Size(397, 26);
            this.txtMultaAplicada.TabIndex = 78;
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Location = new System.Drawing.Point(232, 446);
            this.txtFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaDevolucion.Multiline = true;
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.PasswordChar = '*';
            this.txtFechaDevolucion.Size = new System.Drawing.Size(400, 41);
            this.txtFechaDevolucion.TabIndex = 76;
            // 
            // txtIDdevolucion
            // 
            this.txtIDdevolucion.Location = new System.Drawing.Point(254, 232);
            this.txtIDdevolucion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDdevolucion.Name = "txtIDdevolucion";
            this.txtIDdevolucion.Size = new System.Drawing.Size(352, 26);
            this.txtIDdevolucion.TabIndex = 73;
            // 
            // lblMultaAplicada
            // 
            this.lblMultaAplicada.AutoSize = true;
            this.lblMultaAplicada.BackColor = System.Drawing.Color.BurlyWood;
            this.lblMultaAplicada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultaAplicada.Location = new System.Drawing.Point(99, 595);
            this.lblMultaAplicada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMultaAplicada.Name = "lblMultaAplicada";
            this.lblMultaAplicada.Size = new System.Drawing.Size(133, 20);
            this.lblMultaAplicada.TabIndex = 72;
            this.lblMultaAplicada.Text = "Multa Aplicada";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.BurlyWood;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(99, 526);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(134, 20);
            this.lblObservaciones.TabIndex = 71;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(102, 403);
            this.lblFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(181, 20);
            this.lblFechaDevolucion.TabIndex = 69;
            this.lblFechaDevolucion.Text = "Fecha de devolución";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCondicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicion.Location = new System.Drawing.Point(102, 463);
            this.lblCondicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(92, 20);
            this.lblCondicion.TabIndex = 70;
            this.lblCondicion.Text = "Condición";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.Color.BurlyWood;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(102, 342);
            this.lblLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(52, 20);
            this.lblLibro.TabIndex = 68;
            this.lblLibro.Text = "Libro";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(102, 294);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 20);
            this.lblUsuario.TabIndex = 67;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblIDdevolucion
            // 
            this.lblIDdevolucion.AutoSize = true;
            this.lblIDdevolucion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIDdevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDdevolucion.Location = new System.Drawing.Point(102, 238);
            this.lblIDdevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDdevolucion.Name = "lblIDdevolucion";
            this.lblIDdevolucion.Size = new System.Drawing.Size(123, 20);
            this.lblIDdevolucion.TabIndex = 66;
            this.lblIDdevolucion.Text = "ID devolución";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(596, 668);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 66);
            this.btnEliminar.TabIndex = 88;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(430, 666);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 71);
            this.btnBuscar.TabIndex = 87;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(254, 665);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 72);
            this.btnModificar.TabIndex = 86;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // numericUsuario
            // 
            this.numericUsuario.Location = new System.Drawing.Point(206, 291);
            this.numericUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUsuario.Name = "numericUsuario";
            this.numericUsuario.Size = new System.Drawing.Size(140, 26);
            this.numericUsuario.TabIndex = 89;
            this.numericUsuario.ValueChanged += new System.EventHandler(this.numericUsuario_ValueChanged);
            // 
            // numericULibro
            // 
            this.numericULibro.Location = new System.Drawing.Point(206, 335);
            this.numericULibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericULibro.Name = "numericULibro";
            this.numericULibro.Size = new System.Drawing.Size(140, 26);
            this.numericULibro.TabIndex = 90;
            this.numericULibro.ValueChanged += new System.EventHandler(this.numericULibro_ValueChanged);
            // 
            // dtpFechaObservacion
            // 
            this.dtpFechaObservacion.Location = new System.Drawing.Point(309, 392);
            this.dtpFechaObservacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaObservacion.Name = "dtpFechaObservacion";
            this.dtpFechaObservacion.Size = new System.Drawing.Size(324, 26);
            this.dtpFechaObservacion.TabIndex = 91;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(250, 511);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '*';
            this.txtObservacion.Size = new System.Drawing.Size(400, 41);
            this.txtObservacion.TabIndex = 92;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(87, 666);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 71);
            this.btnGuardar.TabIndex = 93;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1253, 804);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.dtpFechaObservacion);
            this.Controls.Add(this.numericULibro);
            this.Controls.Add(this.numericUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblDevolucion);
            this.Controls.Add(this.txtMultaAplicada);
            this.Controls.Add(this.txtFechaDevolucion);
            this.Controls.Add(this.txtIDdevolucion);
            this.Controls.Add(this.lblMultaAplicada);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIDdevolucion);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.FrmDevolucion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericULibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.TextBox txtMultaAplicada;
        private System.Windows.Forms.TextBox txtFechaDevolucion;
        private System.Windows.Forms.TextBox txtIDdevolucion;
        private System.Windows.Forms.Label lblMultaAplicada;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIDdevolucion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.NumericUpDown numericUsuario;
        private System.Windows.Forms.NumericUpDown numericULibro;
        private System.Windows.Forms.DateTimePicker dtpFechaObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}