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
            this.lblFcehaVencimiento = new System.Windows.Forms.Label();
            this.lblFcehaDevolucion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBiblioteca = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblPrestamo.Location = new System.Drawing.Point(196, 54);
            this.lblPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(124, 29);
            this.lblPrestamo.TabIndex = 1;
            this.lblPrestamo.Text = "Préstamo";
            // 
            // lblIDprestamo
            // 
            this.lblIDprestamo.AutoSize = true;
            this.lblIDprestamo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIDprestamo.Location = new System.Drawing.Point(27, 150);
            this.lblIDprestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDprestamo.Name = "lblIDprestamo";
            this.lblIDprestamo.Size = new System.Drawing.Size(75, 13);
            this.lblIDprestamo.TabIndex = 2;
            this.lblIDprestamo.Text = "ID préstamo";
            // 
            // txtIDprestamo
            // 
            this.txtIDprestamo.Location = new System.Drawing.Point(122, 149);
            this.txtIDprestamo.Name = "txtIDprestamo";
            this.txtIDprestamo.Size = new System.Drawing.Size(160, 20);
            this.txtIDprestamo.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblUsuario.Location = new System.Drawing.Point(27, 178);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.Color.BurlyWood;
            this.lblLibro.Location = new System.Drawing.Point(27, 212);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(35, 13);
            this.lblLibro.TabIndex = 5;
            this.lblLibro.Text = "Libro";
            // 
            // lblFechaPrestmo
            // 
            this.lblFechaPrestmo.AutoSize = true;
            this.lblFechaPrestmo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaPrestmo.Location = new System.Drawing.Point(27, 249);
            this.lblFechaPrestmo.Name = "lblFechaPrestmo";
            this.lblFechaPrestmo.Size = new System.Drawing.Size(115, 13);
            this.lblFechaPrestmo.TabIndex = 6;
            this.lblFechaPrestmo.Text = "Fecha de préstamo";
            // 
            // lblFcehaVencimiento
            // 
            this.lblFcehaVencimiento.AutoSize = true;
            this.lblFcehaVencimiento.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFcehaVencimiento.Location = new System.Drawing.Point(27, 281);
            this.lblFcehaVencimiento.Name = "lblFcehaVencimiento";
            this.lblFcehaVencimiento.Size = new System.Drawing.Size(129, 13);
            this.lblFcehaVencimiento.TabIndex = 7;
            this.lblFcehaVencimiento.Text = "fecha de vencimiento";
            // 
            // lblFcehaDevolucion
            // 
            this.lblFcehaDevolucion.AutoSize = true;
            this.lblFcehaDevolucion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFcehaDevolucion.Location = new System.Drawing.Point(27, 312);
            this.lblFcehaDevolucion.Name = "lblFcehaDevolucion";
            this.lblFcehaDevolucion.Size = new System.Drawing.Size(126, 13);
            this.lblFcehaDevolucion.TabIndex = 8;
            this.lblFcehaDevolucion.Text = "Fecha de devolución";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.BurlyWood;
            this.lblEstado.Location = new System.Drawing.Point(27, 345);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 175);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtLibro
            // 
            this.txtLibro.BackColor = System.Drawing.Color.SeaShell;
            this.txtLibro.Location = new System.Drawing.Point(84, 208);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(198, 20);
            this.txtLibro.TabIndex = 11;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(96, 342);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(238, 20);
            this.txtEstado.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(392, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 43);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(273, 413);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 46);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(142, 412);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 47);
            this.btnModificar.TabIndex = 70;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 20);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(171, 274);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(259, 20);
            this.dateTimePicker2.TabIndex = 74;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(169, 306);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(261, 20);
            this.dateTimePicker3.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(27, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Bibliotecario";
            // 
            // tbxBiblioteca
            // 
            this.tbxBiblioteca.Location = new System.Drawing.Point(122, 374);
            this.tbxBiblioteca.Name = "tbxBiblioteca";
            this.tbxBiblioteca.Size = new System.Drawing.Size(212, 20);
            this.tbxBiblioteca.TabIndex = 77;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(30, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 46);
            this.btnGuardar.TabIndex = 78;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxBiblioteca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFcehaDevolucion);
            this.Controls.Add(this.lblFcehaVencimiento);
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
        private System.Windows.Forms.Label lblFcehaVencimiento;
        private System.Windows.Forms.Label lblFcehaDevolucion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBiblioteca;
        private System.Windows.Forms.Button btnGuardar;
    }
}