namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    partial class FrmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblIDprestamo = new System.Windows.Forms.Label();
            this.txtIDprestamo = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblFechaPrestmo = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblFcehaDevolucion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEvolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblBibliotecario = new System.Windows.Forms.Label();
            this.tbxBiblioteca = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 0;
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
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblPrestamo.Location = new System.Drawing.Point(282, 108);
            this.lblPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(179, 40);
            this.lblPrestamo.TabIndex = 1;
            this.lblPrestamo.Text = "Préstamo";
            // 
            // lblIDprestamo
            // 
            this.lblIDprestamo.AutoSize = true;
            this.lblIDprestamo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIDprestamo.Location = new System.Drawing.Point(66, 229);
            this.lblIDprestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDprestamo.Name = "lblIDprestamo";
            this.lblIDprestamo.Size = new System.Drawing.Size(112, 20);
            this.lblIDprestamo.TabIndex = 2;
            this.lblIDprestamo.Text = "ID préstamo";
            // 
            // txtIDprestamo
            // 
            this.txtIDprestamo.Location = new System.Drawing.Point(289, 226);
            this.txtIDprestamo.Name = "txtIDprestamo";
            this.txtIDprestamo.Size = new System.Drawing.Size(212, 26);
            this.txtIDprestamo.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblUsuario.Location = new System.Drawing.Point(66, 264);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(74, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.Color.BurlyWood;
            this.lblLibro.Location = new System.Drawing.Point(66, 298);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(52, 20);
            this.lblLibro.TabIndex = 5;
            this.lblLibro.Text = "Libro";
            // 
            // lblFechaPrestmo
            // 
            this.lblFechaPrestmo.AutoSize = true;
            this.lblFechaPrestmo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaPrestmo.Location = new System.Drawing.Point(66, 334);
            this.lblFechaPrestmo.Name = "lblFechaPrestmo";
            this.lblFechaPrestmo.Size = new System.Drawing.Size(170, 20);
            this.lblFechaPrestmo.TabIndex = 6;
            this.lblFechaPrestmo.Text = "Fecha de préstamo";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(66, 365);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(192, 20);
            this.lblFechaVencimiento.TabIndex = 7;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // lblFcehaDevolucion
            // 
            this.lblFcehaDevolucion.AutoSize = true;
            this.lblFcehaDevolucion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFcehaDevolucion.Location = new System.Drawing.Point(66, 399);
            this.lblFcehaDevolucion.Name = "lblFcehaDevolucion";
            this.lblFcehaDevolucion.Size = new System.Drawing.Size(181, 20);
            this.lblFcehaDevolucion.TabIndex = 8;
            this.lblFcehaDevolucion.Text = "Fecha de devolución";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.BurlyWood;
            this.lblEstado.Location = new System.Drawing.Point(66, 432);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 20);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(289, 264);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(212, 26);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtLibro
            // 
            this.txtLibro.BackColor = System.Drawing.Color.SeaShell;
            this.txtLibro.Location = new System.Drawing.Point(289, 298);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(212, 26);
            this.txtLibro.TabIndex = 11;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(289, 432);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(212, 26);
            this.txtEstado.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(289, 334);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(362, 26);
            this.dtpFechaPrestamo.TabIndex = 73;
            // 
            // dtpFechaEvolucion
            // 
            this.dtpFechaEvolucion.Location = new System.Drawing.Point(289, 399);
            this.dtpFechaEvolucion.Name = "dtpFechaEvolucion";
            this.dtpFechaEvolucion.Size = new System.Drawing.Size(362, 26);
            this.dtpFechaEvolucion.TabIndex = 74;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(289, 365);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(362, 26);
            this.dtpFechaVencimiento.TabIndex = 75;
            // 
            // lblBibliotecario
            // 
            this.lblBibliotecario.AutoSize = true;
            this.lblBibliotecario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblBibliotecario.Location = new System.Drawing.Point(66, 463);
            this.lblBibliotecario.Name = "lblBibliotecario";
            this.lblBibliotecario.Size = new System.Drawing.Size(115, 20);
            this.lblBibliotecario.TabIndex = 76;
            this.lblBibliotecario.Text = "Bibliotecario";
            // 
            // tbxBiblioteca
            // 
            this.tbxBiblioteca.Location = new System.Drawing.Point(289, 463);
            this.tbxBiblioteca.Name = "tbxBiblioteca";
            this.tbxBiblioteca.Size = new System.Drawing.Size(212, 26);
            this.tbxBiblioteca.TabIndex = 77;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(62, 527);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 71);
            this.btnGuardar.TabIndex = 91;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(583, 527);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 71);
            this.btnEliminar.TabIndex = 90;
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
            this.btnBuscar.Location = new System.Drawing.Point(407, 527);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 71);
            this.btnBuscar.TabIndex = 89;
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
            this.btnModificar.Location = new System.Drawing.Point(235, 527);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 71);
            this.btnModificar.TabIndex = 88;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.tbxBiblioteca);
            this.Controls.Add(this.lblBibliotecario);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.dtpFechaEvolucion);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFcehaDevolucion);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblFechaPrestmo);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtIDprestamo);
            this.Controls.Add(this.lblIDprestamo);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblIDprestamo;
        private System.Windows.Forms.TextBox txtIDprestamo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblFechaPrestmo;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblFcehaDevolucion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaEvolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label lblBibliotecario;
        private System.Windows.Forms.TextBox tbxBiblioteca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
    }
}