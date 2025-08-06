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
            this.txtFechaprestamo = new System.Windows.Forms.TextBox();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.txtFechadevolucion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
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
            this.lblPrestamo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblPrestamo.Location = new System.Drawing.Point(175, 53);
            this.lblPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(124, 29);
            this.lblPrestamo.TabIndex = 1;
            this.lblPrestamo.Text = "Prestamo";
            // 
            // lblIDprestamo
            // 
            this.lblIDprestamo.AutoSize = true;
            this.lblIDprestamo.BackColor = System.Drawing.Color.PeachPuff;
            this.lblIDprestamo.Location = new System.Drawing.Point(80, 120);
            this.lblIDprestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDprestamo.Name = "lblIDprestamo";
            this.lblIDprestamo.Size = new System.Drawing.Size(79, 13);
            this.lblIDprestamo.TabIndex = 2;
            this.lblIDprestamo.Text = "ID prestamo:";
            // 
            // txtIDprestamo
            // 
            this.txtIDprestamo.Location = new System.Drawing.Point(166, 120);
            this.txtIDprestamo.Name = "txtIDprestamo";
            this.txtIDprestamo.Size = new System.Drawing.Size(134, 20);
            this.txtIDprestamo.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.PeachPuff;
            this.lblUsuario.Location = new System.Drawing.Point(81, 156);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.Color.PeachPuff;
            this.lblLibro.Location = new System.Drawing.Point(81, 190);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(39, 13);
            this.lblLibro.TabIndex = 5;
            this.lblLibro.Text = "Libro:";
            // 
            // lblFechaPrestmo
            // 
            this.lblFechaPrestmo.AutoSize = true;
            this.lblFechaPrestmo.BackColor = System.Drawing.Color.PeachPuff;
            this.lblFechaPrestmo.Location = new System.Drawing.Point(80, 224);
            this.lblFechaPrestmo.Name = "lblFechaPrestmo";
            this.lblFechaPrestmo.Size = new System.Drawing.Size(119, 13);
            this.lblFechaPrestmo.TabIndex = 6;
            this.lblFechaPrestmo.Text = "Fecha de prestamo:";
            // 
            // lblFcehaVencimiento
            // 
            this.lblFcehaVencimiento.AutoSize = true;
            this.lblFcehaVencimiento.BackColor = System.Drawing.Color.PeachPuff;
            this.lblFcehaVencimiento.Location = new System.Drawing.Point(81, 262);
            this.lblFcehaVencimiento.Name = "lblFcehaVencimiento";
            this.lblFcehaVencimiento.Size = new System.Drawing.Size(133, 13);
            this.lblFcehaVencimiento.TabIndex = 7;
            this.lblFcehaVencimiento.Text = "fecha de vencimiento:";
            // 
            // lblFcehaDevolucion
            // 
            this.lblFcehaDevolucion.AutoSize = true;
            this.lblFcehaDevolucion.BackColor = System.Drawing.Color.PeachPuff;
            this.lblFcehaDevolucion.Location = new System.Drawing.Point(79, 298);
            this.lblFcehaDevolucion.Name = "lblFcehaDevolucion";
            this.lblFcehaDevolucion.Size = new System.Drawing.Size(130, 13);
            this.lblFcehaDevolucion.TabIndex = 8;
            this.lblFcehaDevolucion.Text = "Fecha de devolucion:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.PeachPuff;
            this.lblEstado.Location = new System.Drawing.Point(80, 339);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(141, 153);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(159, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(141, 187);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(160, 20);
            this.txtLibro.TabIndex = 11;
            // 
            // txtFechaprestamo
            // 
            this.txtFechaprestamo.Location = new System.Drawing.Point(201, 220);
            this.txtFechaprestamo.Name = "txtFechaprestamo";
            this.txtFechaprestamo.Size = new System.Drawing.Size(100, 20);
            this.txtFechaprestamo.TabIndex = 12;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(216, 255);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(85, 20);
            this.txtFechaVencimiento.TabIndex = 13;
            this.txtFechaVencimiento.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtFechadevolucion
            // 
            this.txtFechadevolucion.Location = new System.Drawing.Point(211, 292);
            this.txtFechadevolucion.Name = "txtFechadevolucion";
            this.txtFechadevolucion.Size = new System.Drawing.Size(90, 20);
            this.txtFechadevolucion.TabIndex = 14;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(141, 331);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(159, 20);
            this.txtEstado.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.Location = new System.Drawing.Point(74, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 32);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnModificar.Location = new System.Drawing.Point(185, 385);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 32);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightGreen;
            this.btnEliminar.Location = new System.Drawing.Point(294, 385);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 32);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar.Location = new System.Drawing.Point(298, 426);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 32);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(933, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFechadevolucion);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtFechaprestamo);
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
        private System.Windows.Forms.TextBox txtFechaprestamo;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.TextBox txtFechadevolucion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}