namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    partial class FrmVentasLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasLibros));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblLibroVendido = new System.Windows.Forms.Label();
            this.lblICódigoVenta = new System.Windows.Forms.Label();
            this.lblVentasLibros = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEstadoVenta = new System.Windows.Forms.Label();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.cmbLibroVenta = new System.Windows.Forms.ComboBox();
            this.txtCantida = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitaro = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbEstadoVenta = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(34, 299);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(29, 261);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(89, 13);
            this.lblPrecioUnitario.TabIndex = 12;
            this.lblPrecioUnitario.Text = "Precio unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(32, 225);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblLibroVendido
            // 
            this.lblLibroVendido.AutoSize = true;
            this.lblLibroVendido.BackColor = System.Drawing.Color.BurlyWood;
            this.lblLibroVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroVendido.Location = new System.Drawing.Point(32, 183);
            this.lblLibroVendido.Name = "lblLibroVendido";
            this.lblLibroVendido.Size = new System.Drawing.Size(84, 13);
            this.lblLibroVendido.TabIndex = 10;
            this.lblLibroVendido.Text = "Libro vendido";
            // 
            // lblICódigoVenta
            // 
            this.lblICódigoVenta.AutoSize = true;
            this.lblICódigoVenta.BackColor = System.Drawing.Color.BurlyWood;
            this.lblICódigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICódigoVenta.Location = new System.Drawing.Point(32, 146);
            this.lblICódigoVenta.Name = "lblICódigoVenta";
            this.lblICódigoVenta.Size = new System.Drawing.Size(100, 13);
            this.lblICódigoVenta.TabIndex = 9;
            this.lblICódigoVenta.Text = "Código de venta";
            // 
            // lblVentasLibros
            // 
            this.lblVentasLibros.AutoSize = true;
            this.lblVentasLibros.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVentasLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasLibros.Location = new System.Drawing.Point(185, 70);
            this.lblVentasLibros.Name = "lblVentasLibros";
            this.lblVentasLibros.Size = new System.Drawing.Size(169, 24);
            this.lblVentasLibros.TabIndex = 21;
            this.lblVentasLibros.Text = "Ventas De Libros";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(29, 340);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(97, 13);
            this.lblFechaVenta.TabIndex = 22;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(34, 380);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 23;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEstadoVenta
            // 
            this.lblEstadoVenta.AutoSize = true;
            this.lblEstadoVenta.BackColor = System.Drawing.Color.BurlyWood;
            this.lblEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVenta.Location = new System.Drawing.Point(34, 421);
            this.lblEstadoVenta.Name = "lblEstadoVenta";
            this.lblEstadoVenta.Size = new System.Drawing.Size(115, 13);
            this.lblEstadoVenta.TabIndex = 24;
            this.lblEstadoVenta.Text = "Estado de la Venta";
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Location = new System.Drawing.Point(140, 143);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(179, 20);
            this.txtCodigoVenta.TabIndex = 25;
            // 
            // cmbLibroVenta
            // 
            this.cmbLibroVenta.FormattingEnabled = true;
            this.cmbLibroVenta.Location = new System.Drawing.Point(127, 178);
            this.cmbLibroVenta.Name = "cmbLibroVenta";
            this.cmbLibroVenta.Size = new System.Drawing.Size(121, 21);
            this.cmbLibroVenta.TabIndex = 26;
            // 
            // txtCantida
            // 
            this.txtCantida.Location = new System.Drawing.Point(100, 220);
            this.txtCantida.Name = "txtCantida";
            this.txtCantida.Size = new System.Drawing.Size(210, 20);
            this.txtCantida.TabIndex = 27;
            // 
            // txtPrecioUnitaro
            // 
            this.txtPrecioUnitaro.Location = new System.Drawing.Point(125, 256);
            this.txtPrecioUnitaro.Name = "txtPrecioUnitaro";
            this.txtPrecioUnitaro.Size = new System.Drawing.Size(188, 20);
            this.txtPrecioUnitaro.TabIndex = 28;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(79, 293);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(210, 20);
            this.txtTotal.TabIndex = 29;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(131, 334);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 30;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(86, 374);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(188, 20);
            this.txtCliente.TabIndex = 31;
            // 
            // cmbEstadoVenta
            // 
            this.cmbEstadoVenta.FormattingEnabled = true;
            this.cmbEstadoVenta.Items.AddRange(new object[] {
            "Activa",
            "Cancelada",
            "Devuelta",
            "Pendiente",
            "Finalizada"});
            this.cmbEstadoVenta.Location = new System.Drawing.Point(154, 413);
            this.cmbEstadoVenta.Name = "cmbEstadoVenta";
            this.cmbEstadoVenta.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoVenta.TabIndex = 32;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 76;
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(24, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 46);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(366, 463);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 43);
            this.btnEliminar.TabIndex = 74;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(260, 461);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 46);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(142, 460);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 47);
            this.btnModificar.TabIndex = 72;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(37, 36);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(141, 86);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            // 
            // FrmVentasLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbEstadoVenta);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrecioUnitaro);
            this.Controls.Add(this.txtCantida);
            this.Controls.Add(this.cmbLibroVenta);
            this.Controls.Add(this.txtCodigoVenta);
            this.Controls.Add(this.lblEstadoVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.lblVentasLibros);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblLibroVendido);
            this.Controls.Add(this.lblICódigoVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentasLibros";
            this.Text = "Ventas De Libros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblLibroVendido;
        private System.Windows.Forms.Label lblICódigoVenta;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblVentasLibros;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEstadoVenta;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.ComboBox cmbLibroVenta;
        private System.Windows.Forms.TextBox txtCantida;
        private System.Windows.Forms.TextBox txtPrecioUnitaro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbEstadoVenta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}