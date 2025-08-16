namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    partial class FrmUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUbicacion));
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1300, 970);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblIDUbicacion = new System.Windows.Forms.Label();
            this.lblEstanteria = new System.Windows.Forms.Label();
            this.lblPasillo = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.txtIDUbicacion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.numPasillo = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.txtEstanteria = new System.Windows.Forms.TextBox();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.dgvUbicaciones = new System.Windows.Forms.DataGridView();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.lblTipoMaterial = new System.Windows.Forms.Label();
            this.numCapacidadTotal = new System.Windows.Forms.NumericUpDown();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.numEspaciosOcupados = new System.Windows.Forms.NumericUpDown();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.lblEspaciosDisponibles = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspaciosOcupados)).BeginInit();
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
            this.menuStrip1.TabIndex = 2;
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
            this.pictureBox1.Location = new System.Drawing.Point(114, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(290, 106);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(153, 33);
            this.lblUbicacion.TabIndex = 4;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblIDUbicacion
            // 
            this.lblIDUbicacion.AutoSize = true;
            this.lblIDUbicacion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIDUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUbicacion.Location = new System.Drawing.Point(62, 229);
            this.lblIDUbicacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDUbicacion.Name = "lblIDUbicacion";
            this.lblIDUbicacion.Size = new System.Drawing.Size(114, 20);
            this.lblIDUbicacion.TabIndex = 5;
            this.lblIDUbicacion.Text = "ID ubicación";
            // 
            // lblEstanteria
            // 
            this.lblEstanteria.AutoSize = true;
            this.lblEstanteria.BackColor = System.Drawing.Color.BurlyWood;
            this.lblEstanteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstanteria.Location = new System.Drawing.Point(62, 272);
            this.lblEstanteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstanteria.Name = "lblEstanteria";
            this.lblEstanteria.Size = new System.Drawing.Size(95, 20);
            this.lblEstanteria.TabIndex = 6;
            this.lblEstanteria.Text = "Estanteria";
            // 
            // lblPasillo
            // 
            this.lblPasillo.AutoSize = true;
            this.lblPasillo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPasillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasillo.Location = new System.Drawing.Point(62, 318);
            this.lblPasillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasillo.Name = "lblPasillo";
            this.lblPasillo.Size = new System.Drawing.Size(66, 20);
            this.lblPasillo.TabIndex = 7;
            this.lblPasillo.Text = "Pasillo";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(63, 357);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(76, 20);
            this.lblSeccion.TabIndex = 9;
            this.lblSeccion.Text = "Sección";
            // 
            // txtIDUbicacion
            // 
            this.txtIDUbicacion.Location = new System.Drawing.Point(195, 225);
            this.txtIDUbicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDUbicacion.Name = "txtIDUbicacion";
            this.txtIDUbicacion.Size = new System.Drawing.Size(247, 26);
            this.txtIDUbicacion.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(616, 603);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 66);
            this.btnEliminar.TabIndex = 68;
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
            this.btnBuscar.Location = new System.Drawing.Point(460, 603);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 71);
            this.btnBuscar.TabIndex = 67;
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
            this.btnModificar.Location = new System.Drawing.Point(284, 602);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 72);
            this.btnModificar.TabIndex = 66;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // numPasillo
            // 
            this.numPasillo.Location = new System.Drawing.Point(180, 317);
            this.numPasillo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPasillo.Name = "numPasillo";
            this.numPasillo.Size = new System.Drawing.Size(180, 26);
            this.numPasillo.TabIndex = 70;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(122, 602);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 71);
            this.btnGuardar.TabIndex = 74;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(180, 354);
            this.cmbSeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(180, 28);
            this.cmbSeccion.TabIndex = 75;
            // 
            // txtEstanteria
            // 
            this.txtEstanteria.Location = new System.Drawing.Point(195, 266);
            this.txtEstanteria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstanteria.Name = "txtEstanteria";
            this.txtEstanteria.Size = new System.Drawing.Size(247, 26);
            this.txtEstanteria.TabIndex = 76;
            // 
            // cmbPiso
            // 
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Location = new System.Drawing.Point(180, 392);
            this.cmbPiso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(180, 28);
            this.cmbPiso.TabIndex = 78;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(63, 395);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(46, 20);
            this.lblPiso.TabIndex = 77;
            this.lblPiso.Text = "Piso";
            // 
            // dgvUbicaciones
            // 
            this.dgvUbicaciones.AllowUserToOrderColumns = true;
            this.dgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUbicaciones.Location = new System.Drawing.Point(592, 223);
            this.dgvUbicaciones.Name = "dgvUbicaciones";
            this.dgvUbicaciones.RowHeadersWidth = 62;
            this.dgvUbicaciones.RowTemplate.Height = 28;
            this.dgvUbicaciones.Size = new System.Drawing.Size(484, 195);
            this.dgvUbicaciones.TabIndex = 79;
            this.dgvUbicaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUbicaciones_CellDoubleClick);
            // 
            // cmbTipoMaterial
            // 
            this.cmbTipoMaterial.FormattingEnabled = true;
            this.cmbTipoMaterial.Location = new System.Drawing.Point(262, 431);
            this.cmbTipoMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoMaterial.Name = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size = new System.Drawing.Size(180, 28);
            this.cmbTipoMaterial.TabIndex = 81;
            // 
            // lblTipoMaterial
            // 
            this.lblTipoMaterial.AutoSize = true;
            this.lblTipoMaterial.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTipoMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMaterial.Location = new System.Drawing.Point(63, 432);
            this.lblTipoMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMaterial.Name = "lblTipoMaterial";
            this.lblTipoMaterial.Size = new System.Drawing.Size(145, 20);
            this.lblTipoMaterial.TabIndex = 80;
            this.lblTipoMaterial.Text = "Tipo de Material";
            // 
            // numCapacidadTotal
            // 
            this.numCapacidadTotal.Location = new System.Drawing.Point(262, 468);
            this.numCapacidadTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCapacidadTotal.Name = "numCapacidadTotal";
            this.numCapacidadTotal.Size = new System.Drawing.Size(180, 26);
            this.numCapacidadTotal.TabIndex = 83;
            this.numCapacidadTotal.ValueChanged += new System.EventHandler(this.numCapacidadTotal_ValueChanged);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(62, 469);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(182, 20);
            this.lblCapacidad.TabIndex = 82;
            this.lblCapacidad.Text = "Capacidad de Libros";
            // 
            // numEspaciosOcupados
            // 
            this.numEspaciosOcupados.Location = new System.Drawing.Point(264, 505);
            this.numEspaciosOcupados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numEspaciosOcupados.Name = "numEspaciosOcupados";
            this.numEspaciosOcupados.Size = new System.Drawing.Size(180, 26);
            this.numEspaciosOcupados.TabIndex = 85;
            this.numEspaciosOcupados.ValueChanged += new System.EventHandler(this.numEspaciosOcupados_ValueChanged);
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.BackColor = System.Drawing.Color.BurlyWood;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidad.Location = new System.Drawing.Point(64, 505);
            this.lblDisponibilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(121, 20);
            this.lblDisponibilidad.TabIndex = 84;
            this.lblDisponibilidad.Text = "Disponibilidad";
            // 
            // lblEspaciosDisponibles
            // 
            this.lblEspaciosDisponibles.AutoSize = true;
            this.lblEspaciosDisponibles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEspaciosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaciosDisponibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEspaciosDisponibles.Location = new System.Drawing.Point(303, 535);
            this.lblEspaciosDisponibles.Name = "lblEspaciosDisponibles";
            this.lblEspaciosDisponibles.Size = new System.Drawing.Size(64, 20);
            this.lblEspaciosDisponibles.TabIndex = 86;
            this.lblEspaciosDisponibles.Text = "Estado:";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegistros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalRegistros.Location = new System.Drawing.Point(612, 191);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(48, 20);
            this.lblTotalRegistros.TabIndex = 87;
            this.lblTotalRegistros.Text = "Total:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(766, 602);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 66);
            this.btnLimpiar.TabIndex = 88;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1253, 804);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.lblEspaciosDisponibles);
            this.Controls.Add(this.numEspaciosOcupados);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.numCapacidadTotal);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.cmbTipoMaterial);
            this.Controls.Add(this.lblTipoMaterial);
            this.Controls.Add(this.dgvUbicaciones);
            this.Controls.Add(this.cmbPiso);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.txtEstanteria);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numPasillo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtIDUbicacion);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.lblPasillo);
            this.Controls.Add(this.lblEstanteria);
            this.Controls.Add(this.lblIDUbicacion);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicacion";
            this.Load += new System.EventHandler(this.FrmUbicacion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPasillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUbicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidadTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspaciosOcupados)).EndInit();
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
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblIDUbicacion;
        private System.Windows.Forms.Label lblEstanteria;
        private System.Windows.Forms.Label lblPasillo;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.TextBox txtIDUbicacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.NumericUpDown numPasillo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.TextBox txtEstanteria;
        private System.Windows.Forms.ComboBox cmbPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.DataGridView dgvUbicaciones;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.Label lblTipoMaterial;
        private System.Windows.Forms.NumericUpDown numCapacidadTotal;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.NumericUpDown numEspaciosOcupados;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Label lblEspaciosDisponibles;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnLimpiar;
    }
}