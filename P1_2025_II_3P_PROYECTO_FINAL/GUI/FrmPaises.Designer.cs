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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIdiomaPricipal = new System.Windows.Forms.Label();
            this.lblContinente = new System.Windows.Forms.Label();
            this.lblNombrePais = new System.Windows.Forms.Label();
            this.lblICódigoPais = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.cmbNombrePais = new System.Windows.Forms.ComboBox();
            this.cmbContinente = new System.Windows.Forms.ComboBox();
            this.cmbIdiomaPrincipal = new System.Windows.Forms.ComboBox();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(70, 58);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(39, 555);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 20);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Estado";
            // 
            // lblIdiomaPricipal
            // 
            this.lblIdiomaPricipal.AutoSize = true;
            this.lblIdiomaPricipal.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIdiomaPricipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaPricipal.Location = new System.Drawing.Point(39, 425);
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
            this.lblContinente.Location = new System.Drawing.Point(44, 369);
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
            this.lblNombrePais.Location = new System.Drawing.Point(44, 305);
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
            this.lblICódigoPais.Location = new System.Drawing.Point(44, 254);
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
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
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
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(204, 248);
            this.txtCodigoPais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(193, 26);
            this.txtCodigoPais.TabIndex = 78;
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
            this.cmbNombrePais.Location = new System.Drawing.Point(204, 300);
            this.cmbNombrePais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNombrePais.Name = "cmbNombrePais";
            this.cmbNombrePais.Size = new System.Drawing.Size(180, 28);
            this.cmbNombrePais.TabIndex = 79;
            this.cmbNombrePais.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.cmbContinente.Location = new System.Drawing.Point(160, 360);
            this.cmbContinente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbContinente.Name = "cmbContinente";
            this.cmbContinente.Size = new System.Drawing.Size(223, 28);
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
            this.cmbIdiomaPrincipal.Location = new System.Drawing.Point(188, 415);
            this.cmbIdiomaPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIdiomaPrincipal.Name = "cmbIdiomaPrincipal";
            this.cmbIdiomaPrincipal.Size = new System.Drawing.Size(196, 28);
            this.cmbIdiomaPrincipal.TabIndex = 81;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbActivo.Location = new System.Drawing.Point(130, 551);
            this.rbActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(77, 24);
            this.rbActivo.TabIndex = 82;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = false;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbInactivo.Location = new System.Drawing.Point(232, 548);
            this.rbInactivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(89, 24);
            this.rbInactivo.TabIndex = 83;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(50, 616);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 71);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(571, 616);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 71);
            this.btnEliminar.TabIndex = 86;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(395, 616);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(148, 71);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(223, 616);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 71);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.BackColor = System.Drawing.Color.BurlyWood;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(39, 483);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(144, 20);
            this.lblFechaIngreso.TabIndex = 88;
            this.lblFechaIngreso.Text = "Feha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(204, 483);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(330, 26);
            this.dtpFechaIngreso.TabIndex = 89;
            // 
            // FrmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 774);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.cmbIdiomaPrincipal);
            this.Controls.Add(this.cmbContinente);
            this.Controls.Add(this.cmbNombrePais);
            this.Controls.Add(this.txtCodigoPais);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblIdiomaPricipal);
            this.Controls.Add(this.lblContinente);
            this.Controls.Add(this.lblNombrePais);
            this.Controls.Add(this.lblICódigoPais);
            this.Controls.Add(this.lblVentasLibros);
            this.Controls.Add(this.pictureBox13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPaises";
            this.Text = "Paises";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label lblVentasLibros;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIdiomaPricipal;
        private System.Windows.Forms.Label lblContinente;
        private System.Windows.Forms.Label lblNombrePais;
        private System.Windows.Forms.Label lblICódigoPais;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.ComboBox cmbNombrePais;
        private System.Windows.Forms.ComboBox cmbContinente;
        private System.Windows.Forms.ComboBox cmbIdiomaPrincipal;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
    }
}