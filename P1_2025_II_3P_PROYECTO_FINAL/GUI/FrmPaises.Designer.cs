namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    partial class FrmPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaises));
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lblVentasLibros = new System.Windows.Forms.Label();
            this.lblIdiomaPricipal = new System.Windows.Forms.Label();
            this.lblContinente = new System.Windows.Forms.Label();
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.lblICódigoPais = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigoISO = new System.Windows.Forms.TextBox();
            this.cmbNombrePais = new System.Windows.Forms.ComboBox();
            this.cmbContinente = new System.Windows.Forms.ComboBox();
            this.cmbIdiomaPrincipal = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.lblCapital = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.numPoblacion = new System.Windows.Forms.NumericUpDown();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblPIB = new System.Windows.Forms.Label();
            this.numPIB = new System.Windows.Forms.NumericUpDown();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.lblIdiomaMasComun = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblPoblacionTotal = new System.Windows.Forms.Label();
            this.lblPaisMayorPoblacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPIB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(47, 38);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(195, 138);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            // 
            // lblVentasLibros
            // 
            this.lblVentasLibros.AutoSize = true;
            this.lblVentasLibros.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVentasLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasLibros.Location = new System.Drawing.Point(282, 108);
            this.lblVentasLibros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentasLibros.Name = "lblVentasLibros";
            this.lblVentasLibros.Size = new System.Drawing.Size(109, 33);
            this.lblVentasLibros.TabIndex = 25;
            this.lblVentasLibros.Text = "Países";
            // 
            // lblIdiomaPricipal
            // 
            this.lblIdiomaPricipal.AutoSize = true;
            this.lblIdiomaPricipal.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIdiomaPricipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaPricipal.Location = new System.Drawing.Point(44, 396);
            this.lblIdiomaPricipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdiomaPricipal.Name = "lblIdiomaPricipal";
            this.lblIdiomaPricipal.Size = new System.Drawing.Size(134, 20);
            this.lblIdiomaPricipal.TabIndex = 29;
            this.lblIdiomaPricipal.Text = "Idioma Pricipal";
            // 
            // lblContinente
            // 
            this.lblContinente.AutoSize = true;
            this.lblContinente.BackColor = System.Drawing.Color.BurlyWood;
            this.lblContinente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinente.Location = new System.Drawing.Point(44, 358);
            this.lblContinente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContinente.Name = "lblContinente";
            this.lblContinente.Size = new System.Drawing.Size(99, 20);
            this.lblContinente.TabIndex = 28;
            this.lblContinente.Text = "Continente";
            // 
            // lblNombrePais
            // 
            this.lblNombrePais.AutoSize = true;
            this.lblNombrePais.BackColor = System.Drawing.Color.BurlyWood;
            this.lblNombrePais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePais.Location = new System.Drawing.Point(44, 284);
            this.lblNombrePais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePais.Name = "lblNombrePais";
            this.lblNombrePais.Size = new System.Drawing.Size(146, 20);
            this.lblNombrePais.TabIndex = 27;
            this.lblNombrePais.Text = "Nombre del país";
            // 
            // lblICódigoPais
            // 
            this.lblICódigoPais.AutoSize = true;
            this.lblICódigoPais.BackColor = System.Drawing.Color.BurlyWood;
            this.lblICódigoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICódigoPais.Location = new System.Drawing.Point(44, 248);
            this.lblICódigoPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblICódigoPais.Name = "lblICódigoPais";
            this.lblICódigoPais.Size = new System.Drawing.Size(134, 20);
            this.lblICódigoPais.TabIndex = 26;
            this.lblICódigoPais.Text = "Código de país";
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
            this.menuStrip1.Size = new System.Drawing.Size(1563, 35);
            this.menuStrip1.TabIndex = 77;
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
            // txtCodigoISO
            // 
            this.txtCodigoISO.Location = new System.Drawing.Point(204, 248);
            this.txtCodigoISO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoISO.Name = "txtCodigoISO";
            this.txtCodigoISO.Size = new System.Drawing.Size(180, 26);
            this.txtCodigoISO.TabIndex = 78;
            // 
            // cmbNombrePais
            // 
            this.cmbNombrePais.FormattingEnabled = true;
            this.cmbNombrePais.Items.AddRange(new object[] {
            "Honduras",
            "Guatemala",
            "Salvador",
            "Costarica ",
            "Nicaragua",
            "Belice",
            "Estados Unidos",
            "Mexico",
            "Brasil",
            "Francia",
            "Canada"});
            this.cmbNombrePais.Location = new System.Drawing.Point(204, 284);
            this.cmbNombrePais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNombrePais.Name = "cmbNombrePais";
            this.cmbNombrePais.Size = new System.Drawing.Size(180, 28);
            this.cmbNombrePais.TabIndex = 79;
            this.cmbNombrePais.SelectedIndexChanged += new System.EventHandler(this.cmbNombrePais_SelectedIndexChanged);
            // 
            // cmbContinente
            // 
            this.cmbContinente.FormattingEnabled = true;
            this.cmbContinente.Items.AddRange(new object[] {
            "Asia",
            "America",
            "Africa",
            "Europa",
            "Oceania",
            "Artantida"});
            this.cmbContinente.Location = new System.Drawing.Point(204, 358);
            this.cmbContinente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbContinente.Name = "cmbContinente";
            this.cmbContinente.Size = new System.Drawing.Size(180, 28);
            this.cmbContinente.TabIndex = 80;
            // 
            // cmbIdiomaPrincipal
            // 
            this.cmbIdiomaPrincipal.FormattingEnabled = true;
            this.cmbIdiomaPrincipal.Items.AddRange(new object[] {
            "Inlgles ",
            "Español",
            "Frances",
            "Chino"});
            this.cmbIdiomaPrincipal.Location = new System.Drawing.Point(204, 396);
            this.cmbIdiomaPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIdiomaPrincipal.Name = "cmbIdiomaPrincipal";
            this.cmbIdiomaPrincipal.Size = new System.Drawing.Size(180, 28);
            this.cmbIdiomaPrincipal.TabIndex = 81;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(50, 615);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 71);
            this.btnGuardar.TabIndex = 87;
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
            this.btnEliminar.Location = new System.Drawing.Point(740, 615);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 71);
            this.btnEliminar.TabIndex = 86;
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
            this.btnBuscar.Location = new System.Drawing.Point(394, 615);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 71);
            this.btnBuscar.TabIndex = 85;
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
            this.btnModificar.Location = new System.Drawing.Point(224, 615);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 71);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToOrderColumns = true;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Location = new System.Drawing.Point(591, 248);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.RowHeadersWidth = 62;
            this.dgvPaises.RowTemplate.Height = 28;
            this.dgvPaises.Size = new System.Drawing.Size(584, 267);
            this.dgvPaises.TabIndex = 90;
            this.dgvPaises.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaises_CellDoubleClick);
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(44, 322);
            this.lblCapital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(140, 20);
            this.lblCapital.TabIndex = 91;
            this.lblCapital.Text = "Capital del país";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(204, 322);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(180, 26);
            this.txtCapital.TabIndex = 92;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(39, 559);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(144, 20);
            this.lblFechaIngreso.TabIndex = 88;
            this.lblFechaIngreso.Text = "Feha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(191, 559);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(330, 26);
            this.dtpFechaIngreso.TabIndex = 89;
            // 
            // numPoblacion
            // 
            this.numPoblacion.Location = new System.Drawing.Point(204, 432);
            this.numPoblacion.Name = "numPoblacion";
            this.numPoblacion.Size = new System.Drawing.Size(74, 26);
            this.numPoblacion.TabIndex = 93;
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(44, 432);
            this.lblPoblacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(97, 20);
            this.lblPoblacion.TabIndex = 94;
            this.lblPoblacion.Text = "Poblacion:";
            // 
            // lblPIB
            // 
            this.lblPIB.AutoSize = true;
            this.lblPIB.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIB.Location = new System.Drawing.Point(44, 467);
            this.lblPIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPIB.Name = "lblPIB";
            this.lblPIB.Size = new System.Drawing.Size(117, 20);
            this.lblPIB.TabIndex = 96;
            this.lblPIB.Text = "PIB del pais:";
            // 
            // numPIB
            // 
            this.numPIB.Location = new System.Drawing.Point(204, 467);
            this.numPIB.Name = "numPIB";
            this.numPIB.Size = new System.Drawing.Size(74, 26);
            this.numPIB.TabIndex = 95;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Items.AddRange(new object[] {
            "Asia",
            "America",
            "Africa",
            "Europa",
            "Oceania",
            "Artantida"});
            this.cmbMoneda.Location = new System.Drawing.Point(204, 501);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(180, 28);
            this.cmbMoneda.TabIndex = 98;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.BackColor = System.Drawing.Color.BurlyWood;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(44, 501);
            this.lblMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(154, 20);
            this.lblMoneda.TabIndex = 97;
            this.lblMoneda.Text = "Moneda del Pais:";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.Location = new System.Drawing.Point(587, 209);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(137, 20);
            this.lblTotalRegistros.TabIndex = 101;
            this.lblTotalRegistros.Text = "Total de Paises:";
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas.Location = new System.Drawing.Point(587, 176);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(112, 20);
            this.lblEstadisticas.TabIndex = 100;
            this.lblEstadisticas.Text = "Estadisticas:";
            // 
            // lblIdiomaMasComun
            // 
            this.lblIdiomaMasComun.AutoSize = true;
            this.lblIdiomaMasComun.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdiomaMasComun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaMasComun.Location = new System.Drawing.Point(761, 209);
            this.lblIdiomaMasComun.Name = "lblIdiomaMasComun";
            this.lblIdiomaMasComun.Size = new System.Drawing.Size(167, 20);
            this.lblIdiomaMasComun.TabIndex = 99;
            this.lblIdiomaMasComun.Text = "Idioma mas Comun:";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(565, 615);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(148, 71);
            this.btnExportar.TabIndex = 102;
            this.btnExportar.Text = "Exportar reporte pais";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblPoblacionTotal
            // 
            this.lblPoblacionTotal.AutoSize = true;
            this.lblPoblacionTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoblacionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacionTotal.Location = new System.Drawing.Point(943, 176);
            this.lblPoblacionTotal.Name = "lblPoblacionTotal";
            this.lblPoblacionTotal.Size = new System.Drawing.Size(137, 20);
            this.lblPoblacionTotal.TabIndex = 103;
            this.lblPoblacionTotal.Text = "Poblacion Total:";
            // 
            // lblPaisMayorPoblacion
            // 
            this.lblPaisMayorPoblacion.AutoSize = true;
            this.lblPaisMayorPoblacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaisMayorPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisMayorPoblacion.Location = new System.Drawing.Point(943, 209);
            this.lblPaisMayorPoblacion.Name = "lblPaisMayorPoblacion";
            this.lblPaisMayorPoblacion.Size = new System.Drawing.Size(217, 20);
            this.lblPaisMayorPoblacion.TabIndex = 104;
            this.lblPaisMayorPoblacion.Text = "Pais con mayor poblacion:";
            // 
            // FrmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1563, 710);
            this.Controls.Add(this.lblPaisMayorPoblacion);
            this.Controls.Add(this.lblPoblacionTotal);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.lblIdiomaMasComun);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblPIB);
            this.Controls.Add(this.numPIB);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.numPoblacion);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.dgvPaises);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbIdiomaPrincipal);
            this.Controls.Add(this.cmbContinente);
            this.Controls.Add(this.cmbNombrePais);
            this.Controls.Add(this.txtCodigoISO);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblIdiomaPricipal);
            this.Controls.Add(this.lblContinente);
            this.Controls.Add(this.lblNombrePais);
            this.Controls.Add(this.lblICódigoPais);
            this.Controls.Add(this.lblVentasLibros);
            this.Controls.Add(this.pictureBox13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPaises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paises";
            this.Load += new System.EventHandler(this.FrmPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPoblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPIB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label lblVentasLibros;
        private System.Windows.Forms.Label lblIdiomaPricipal;
        private System.Windows.Forms.Label lblContinente;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.Label lblICódigoPais;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodigoISO;
        private System.Windows.Forms.ComboBox cmbNombrePais;
        private System.Windows.Forms.ComboBox cmbContinente;
        private System.Windows.Forms.ComboBox cmbIdiomaPrincipal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.NumericUpDown numPoblacion;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblPIB;
        private System.Windows.Forms.NumericUpDown numPIB;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.Label lblIdiomaMasComun;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblPoblacionTotal;
        private System.Windows.Forms.Label lblPaisMayorPoblacion;
    }
}