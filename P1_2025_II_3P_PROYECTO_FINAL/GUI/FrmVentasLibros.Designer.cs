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
            this.lblLibros = new System.Windows.Forms.Label();
            this.lblCódigoVenta = new System.Windows.Forms.Label();
            this.lblVentasLibros = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEstadoVenta = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtInfoLibro = new System.Windows.Forms.TextBox();
            this.lblLibroMasVendido = new System.Windows.Forms.Label();
            this.lblVentasMes = new System.Windows.Forms.Label();
            this.lblVentasHoy = new System.Windows.Forms.Label();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(48, 412);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(48, 362);
            this.lblPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(132, 20);
            this.lblPrecioUnitario.TabIndex = 12;
            this.lblPrecioUnitario.Text = "Precio unitario";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(48, 315);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 20);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblLibros
            // 
            this.lblLibros.AutoSize = true;
            this.lblLibros.BackColor = System.Drawing.Color.BurlyWood;
            this.lblLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(48, 274);
            this.lblLibros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(68, 20);
            this.lblLibros.TabIndex = 10;
            this.lblLibros.Text = "Libros:";
            // 
            // lblCódigoVenta
            // 
            this.lblCódigoVenta.AutoSize = true;
            this.lblCódigoVenta.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCódigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigoVenta.Location = new System.Drawing.Point(48, 226);
            this.lblCódigoVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCódigoVenta.Name = "lblCódigoVenta";
            this.lblCódigoVenta.Size = new System.Drawing.Size(144, 20);
            this.lblCódigoVenta.TabIndex = 9;
            this.lblCódigoVenta.Text = "Código de venta";
            // 
            // lblVentasLibros
            // 
            this.lblVentasLibros.AutoSize = true;
            this.lblVentasLibros.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVentasLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasLibros.Location = new System.Drawing.Point(278, 108);
            this.lblVentasLibros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasLibros.Name = "lblVentasLibros";
            this.lblVentasLibros.Size = new System.Drawing.Size(254, 33);
            this.lblVentasLibros.TabIndex = 21;
            this.lblVentasLibros.Text = "Ventas De Libros";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(48, 463);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(140, 20);
            this.lblFechaVenta.TabIndex = 22;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(48, 511);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 20);
            this.lblCliente.TabIndex = 23;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEstadoVenta
            // 
            this.lblEstadoVenta.AutoSize = true;
            this.lblEstadoVenta.BackColor = System.Drawing.Color.BurlyWood;
            this.lblEstadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVenta.Location = new System.Drawing.Point(48, 558);
            this.lblEstadoVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoVenta.Name = "lblEstadoVenta";
            this.lblEstadoVenta.Size = new System.Drawing.Size(168, 20);
            this.lblEstadoVenta.TabIndex = 24;
            this.lblEstadoVenta.Text = "Estado de la Venta";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(196, 226);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(180, 26);
            this.txtIdVenta.TabIndex = 25;
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(196, 274);
            this.cmbLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(180, 28);
            this.cmbLibro.TabIndex = 26;
            this.cmbLibro.SelectedIndexChanged += new System.EventHandler(this.cmbLibro_SelectedIndexChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(196, 412);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(180, 26);
            this.txtTotal.TabIndex = 29;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(196, 463);
            this.dtpFechaVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(306, 26);
            this.dtpFechaVenta.TabIndex = 30;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(196, 511);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(280, 26);
            this.txtCliente.TabIndex = 31;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Activa",
            "Cancelada",
            "Devuelta",
            "Pendiente",
            "Finalizada"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(224, 558);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(180, 28);
            this.cmbMetodoPago.TabIndex = 32;
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
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 76;
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(37, 662);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 71);
            this.btnGuardar.TabIndex = 75;
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
            this.btnEliminar.Location = new System.Drawing.Point(787, 662);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 72);
            this.btnEliminar.TabIndex = 74;
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
            this.btnBuscar.Location = new System.Drawing.Point(197, 662);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 71);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarFactura.Image")));
            this.btnGenerarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarFactura.Location = new System.Drawing.Point(352, 662);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(195, 72);
            this.btnGenerarFactura.TabIndex = 72;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(56, 55);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(212, 132);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(602, 226);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 62;
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.Size = new System.Drawing.Size(574, 382);
            this.dgvVentas.TabIndex = 77;
            this.dgvVentas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellDoubleClick);
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(196, 315);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(58, 26);
            this.numCantidad.TabIndex = 78;
            this.numCantidad.ValueChanged += new System.EventHandler(this.numCantidad_ValueChanged);
            // 
            // numPrecioUnitario
            // 
            this.numPrecioUnitario.Location = new System.Drawing.Point(196, 362);
            this.numPrecioUnitario.Name = "numPrecioUnitario";
            this.numPrecioUnitario.Size = new System.Drawing.Size(58, 26);
            this.numPrecioUnitario.TabIndex = 79;
            this.numPrecioUnitario.ValueChanged += new System.EventHandler(this.numPrecioUnitario_ValueChanged);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(597, 189);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(141, 20);
            this.lblTotalRegistros.TabIndex = 80;
            this.lblTotalRegistros.Text = "Total de Ventas:";
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(555, 662);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(224, 72);
            this.btnReporte.TabIndex = 81;
            this.btnReporte.Text = "Generar Reporte de Ventas";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtInfoLibro
            // 
            this.txtInfoLibro.Location = new System.Drawing.Point(384, 274);
            this.txtInfoLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfoLibro.Multiline = true;
            this.txtInfoLibro.Name = "txtInfoLibro";
            this.txtInfoLibro.Size = new System.Drawing.Size(180, 62);
            this.txtInfoLibro.TabIndex = 82;
            // 
            // lblLibroMasVendido
            // 
            this.lblLibroMasVendido.AutoSize = true;
            this.lblLibroMasVendido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLibroMasVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibroMasVendido.Location = new System.Drawing.Point(900, 132);
            this.lblLibroMasVendido.Name = "lblLibroMasVendido";
            this.lblLibroMasVendido.Size = new System.Drawing.Size(163, 20);
            this.lblLibroMasVendido.TabIndex = 83;
            this.lblLibroMasVendido.Text = "Libro mas Vendido:";
            // 
            // lblVentasMes
            // 
            this.lblVentasMes.AutoSize = true;
            this.lblVentasMes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVentasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasMes.Location = new System.Drawing.Point(746, 132);
            this.lblVentasMes.Name = "lblVentasMes";
            this.lblVentasMes.Size = new System.Drawing.Size(134, 20);
            this.lblVentasMes.TabIndex = 84;
            this.lblVentasMes.Text = "Ventas de Mes:";
            // 
            // lblVentasHoy
            // 
            this.lblVentasHoy.AutoSize = true;
            this.lblVentasHoy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVentasHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasHoy.Location = new System.Drawing.Point(597, 132);
            this.lblVentasHoy.Name = "lblVentasHoy";
            this.lblVentasHoy.Size = new System.Drawing.Size(132, 20);
            this.lblVentasHoy.TabIndex = 85;
            this.lblVentasHoy.Text = "Ventas del Dia:";
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeneral.Location = new System.Drawing.Point(900, 189);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(123, 20);
            this.lblTotalGeneral.TabIndex = 86;
            this.lblTotalGeneral.Text = "Total General:";
            // 
            // FrmVentasLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 803);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.lblVentasHoy);
            this.Controls.Add(this.lblVentasMes);
            this.Controls.Add(this.lblLibroMasVendido);
            this.Controls.Add(this.txtInfoLibro);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.numPrecioUnitario);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.lblEstadoVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFechaVenta);
            this.Controls.Add(this.lblVentasLibros);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblLibros);
            this.Controls.Add(this.lblCódigoVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVentasLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas De Libros";
            this.Load += new System.EventHandler(this.FrmVentasLibros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.Label lblCódigoVenta;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label lblVentasLibros;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEstadoVenta;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numPrecioUnitario;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtInfoLibro;
        private System.Windows.Forms.Label lblLibroMasVendido;
        private System.Windows.Forms.Label lblVentasMes;
        private System.Windows.Forms.Label lblVentasHoy;
        private System.Windows.Forms.Label lblTotalGeneral;
    }
}