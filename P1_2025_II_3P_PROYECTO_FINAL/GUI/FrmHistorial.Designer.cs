namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    partial class FrmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHistrorial = new System.Windows.Forms.Label();
            this.lblIDHistorial = new System.Windows.Forms.Label();
            this.lblBibliotecario = new System.Windows.Forms.Label();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.lblFechaActividad = new System.Windows.Forms.Label();
            this.lblTablaAfectada = new System.Windows.Forms.Label();
            this.txtIDHistorial = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbTipoAccion = new System.Windows.Forms.ComboBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbTablaAfectada = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.lblAccionesHoy = new System.Windows.Forms.Label();
            this.lblTablaMasActiva = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1200, 36);
            this.menuStrip1.TabIndex = 1;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblHistrorial
            // 
            this.lblHistrorial.AutoSize = true;
            this.lblHistrorial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHistrorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistrorial.Location = new System.Drawing.Point(334, 122);
            this.lblHistrorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistrorial.Name = "lblHistrorial";
            this.lblHistrorial.Size = new System.Drawing.Size(131, 33);
            this.lblHistrorial.TabIndex = 3;
            this.lblHistrorial.Text = "Historial";
            // 
            // lblIDHistorial
            // 
            this.lblIDHistorial.AutoSize = true;
            this.lblIDHistorial.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIDHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDHistorial.Location = new System.Drawing.Point(57, 237);
            this.lblIDHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDHistorial.Name = "lblIDHistorial";
            this.lblIDHistorial.Size = new System.Drawing.Size(102, 20);
            this.lblIDHistorial.TabIndex = 4;
            this.lblIDHistorial.Text = "ID historial";
            // 
            // lblBibliotecario
            // 
            this.lblBibliotecario.AutoSize = true;
            this.lblBibliotecario.BackColor = System.Drawing.Color.BurlyWood;
            this.lblBibliotecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibliotecario.Location = new System.Drawing.Point(57, 292);
            this.lblBibliotecario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBibliotecario.Name = "lblBibliotecario";
            this.lblBibliotecario.Size = new System.Drawing.Size(115, 20);
            this.lblBibliotecario.TabIndex = 5;
            this.lblBibliotecario.Text = "Bibliotecario";
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTipoActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoActividad.Location = new System.Drawing.Point(57, 335);
            this.lblTipoActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(152, 20);
            this.lblTipoActividad.TabIndex = 6;
            this.lblTipoActividad.Text = "Tipo de actividad";
            // 
            // lblFechaActividad
            // 
            this.lblFechaActividad.AutoSize = true;
            this.lblFechaActividad.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActividad.Location = new System.Drawing.Point(56, 411);
            this.lblFechaActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaActividad.Name = "lblFechaActividad";
            this.lblFechaActividad.Size = new System.Drawing.Size(198, 20);
            this.lblFechaActividad.TabIndex = 7;
            this.lblFechaActividad.Text = "Fecha de actividad del";
            // 
            // lblTablaAfectada
            // 
            this.lblTablaAfectada.AutoSize = true;
            this.lblTablaAfectada.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTablaAfectada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaAfectada.Location = new System.Drawing.Point(57, 373);
            this.lblTablaAfectada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTablaAfectada.Name = "lblTablaAfectada";
            this.lblTablaAfectada.Size = new System.Drawing.Size(179, 20);
            this.lblTablaAfectada.TabIndex = 8;
            this.lblTablaAfectada.Text = "Formulario Afectado";
            // 
            // txtIDHistorial
            // 
            this.txtIDHistorial.Location = new System.Drawing.Point(203, 237);
            this.txtIDHistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDHistorial.Name = "txtIDHistorial";
            this.txtIDHistorial.Size = new System.Drawing.Size(221, 26);
            this.txtIDHistorial.TabIndex = 9;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Location = new System.Drawing.Point(597, 597);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(163, 71);
            this.btnRefrescar.TabIndex = 68;
            this.btnRefrescar.Text = "Refrescar Historial";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MistyRose;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(432, 597);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(157, 71);
            this.btnExportar.TabIndex = 67;
            this.btnExportar.Text = "Exportar Historial";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(218, 597);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(206, 71);
            this.btnLimpiarFiltros.TabIndex = 66;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(262, 411);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(326, 26);
            this.dtpFechaInicio.TabIndex = 69;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(75, 597);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(134, 71);
            this.btnFiltrar.TabIndex = 71;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbTipoAccion
            // 
            this.cmbTipoAccion.FormattingEnabled = true;
            this.cmbTipoAccion.Location = new System.Drawing.Point(244, 335);
            this.cmbTipoAccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoAccion.Name = "cmbTipoAccion";
            this.cmbTipoAccion.Size = new System.Drawing.Size(180, 28);
            this.cmbTipoAccion.TabIndex = 76;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToOrderColumns = true;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(629, 242);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 62;
            this.dgvHistorial.RowTemplate.Height = 28;
            this.dgvHistorial.Size = new System.Drawing.Size(516, 226);
            this.dgvHistorial.TabIndex = 77;
            this.dgvHistorial.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellDoubleClick);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(244, 292);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(180, 28);
            this.cmbUsuario.TabIndex = 78;
            // 
            // cmbTablaAfectada
            // 
            this.cmbTablaAfectada.FormattingEnabled = true;
            this.cmbTablaAfectada.Location = new System.Drawing.Point(244, 373);
            this.cmbTablaAfectada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTablaAfectada.Name = "cmbTablaAfectada";
            this.cmbTablaAfectada.Size = new System.Drawing.Size(180, 28);
            this.cmbTablaAfectada.TabIndex = 79;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(263, 442);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(326, 26);
            this.dtpFechaFin.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "hasta la fecha";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(464, 384);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(125, 26);
            this.txtBuscar.TabIndex = 82;
            this.txtBuscar.Text = "Aplicar Fechas";
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(625, 208);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(136, 20);
            this.lblTotalRegistros.TabIndex = 83;
            this.lblTotalRegistros.Text = "Total Registros:";
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas.Location = new System.Drawing.Point(57, 482);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(193, 20);
            this.lblEstadisticas.TabIndex = 84;
            this.lblEstadisticas.Text = "Resumen de Acciones:";
            // 
            // lblAccionesHoy
            // 
            this.lblAccionesHoy.AutoSize = true;
            this.lblAccionesHoy.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAccionesHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionesHoy.Location = new System.Drawing.Point(56, 515);
            this.lblAccionesHoy.Name = "lblAccionesHoy";
            this.lblAccionesHoy.Size = new System.Drawing.Size(255, 20);
            this.lblAccionesHoy.TabIndex = 85;
            this.lblAccionesHoy.Text = "Registros de Acciones de Hoy:";
            // 
            // lblTablaMasActiva
            // 
            this.lblTablaMasActiva.AutoSize = true;
            this.lblTablaMasActiva.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTablaMasActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaMasActiva.Location = new System.Drawing.Point(56, 544);
            this.lblTablaMasActiva.Name = "lblTablaMasActiva";
            this.lblTablaMasActiva.Size = new System.Drawing.Size(179, 20);
            this.lblTablaMasActiva.TabIndex = 86;
            this.lblTablaMasActiva.Text = "Formulario mas visto:";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 748);
            this.Controls.Add(this.lblTablaMasActiva);
            this.Controls.Add(this.lblAccionesHoy);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTablaAfectada);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.cmbTipoAccion);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.txtIDHistorial);
            this.Controls.Add(this.lblTablaAfectada);
            this.Controls.Add(this.lblFechaActividad);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.lblBibliotecario);
            this.Controls.Add(this.lblIDHistorial);
            this.Controls.Add(this.lblHistrorial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHistrorial;
        private System.Windows.Forms.Label lblIDHistorial;
        private System.Windows.Forms.Label lblBibliotecario;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.Label lblFechaActividad;
        private System.Windows.Forms.Label lblTablaAfectada;
        private System.Windows.Forms.TextBox txtIDHistorial;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbTipoAccion;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbTablaAfectada;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.Label lblAccionesHoy;
        private System.Windows.Forms.Label lblTablaMasActiva;
    }
}