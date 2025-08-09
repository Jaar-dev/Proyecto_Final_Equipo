namespace P1_2025_II_3P_PROYECTO_FINAL
{
    partial class FrmLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibro));
            this.lblLibro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblNumeroPaginas = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIDLibro = new System.Windows.Forms.Label();
            this.txtIDLibro = new System.Windows.Forms.TextBox();
            this.clbTitulo = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.clbIdioma = new System.Windows.Forms.CheckedListBox();
            this.dtpAño = new System.Windows.Forms.DateTimePicker();
            this.nmdNumeroPaginas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdNumeroPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(178, 72);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(57, 24);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.BurlyWood;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 193);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.BurlyWood;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(27, 275);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(37, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.BurlyWood;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(27, 323);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.BurlyWood;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(27, 397);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 7;
            this.lblAño.Text = "Año";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.BurlyWood;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(30, 436);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(36, 13);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(31, 482);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(44, 13);
            this.lblIdioma.TabIndex = 10;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblNumeroPaginas
            // 
            this.lblNumeroPaginas.AutoSize = true;
            this.lblNumeroPaginas.BackColor = System.Drawing.Color.BurlyWood;
            this.lblNumeroPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPaginas.Location = new System.Drawing.Point(12, 547);
            this.lblNumeroPaginas.Name = "lblNumeroPaginas";
            this.lblNumeroPaginas.Size = new System.Drawing.Size(116, 13);
            this.lblNumeroPaginas.TabIndex = 11;
            this.lblNumeroPaginas.Text = "Numero de paginas";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(80, 272);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(195, 20);
            this.txtAutor.TabIndex = 13;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(86, 429);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(189, 20);
            this.txtISBN.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(361, 588);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 43);
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
            this.btnBuscar.Location = new System.Drawing.Point(251, 586);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 46);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(129, 585);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 47);
            this.btnModificar.TabIndex = 66;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 69;
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
            // lblIDLibro
            // 
            this.lblIDLibro.AutoSize = true;
            this.lblIDLibro.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIDLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLibro.Location = new System.Drawing.Point(27, 155);
            this.lblIDLibro.Name = "lblIDLibro";
            this.lblIDLibro.Size = new System.Drawing.Size(48, 13);
            this.lblIDLibro.TabIndex = 70;
            this.lblIDLibro.Text = "ID libro";
            // 
            // txtIDLibro
            // 
            this.txtIDLibro.Location = new System.Drawing.Point(90, 155);
            this.txtIDLibro.Name = "txtIDLibro";
            this.txtIDLibro.Size = new System.Drawing.Size(185, 20);
            this.txtIDLibro.TabIndex = 71;
            // 
            // clbTitulo
            // 
            this.clbTitulo.FormattingEnabled = true;
            this.clbTitulo.Items.AddRange(new object[] {
            "Novela",
            "Cuento",
            "Poesía",
            "Teatro",
            "Física",
            "Biología",
            "Informática",
            "Ingeniería",
            "Biblia",
            "Catequesis",
            "Meditación"});
            this.clbTitulo.Location = new System.Drawing.Point(90, 193);
            this.clbTitulo.Name = "clbTitulo";
            this.clbTitulo.Size = new System.Drawing.Size(120, 64);
            this.clbTitulo.TabIndex = 72;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Literatura",
            "Infantil y juvenil",
            "Científicos y técnicos",
            "Educativos",
            "Religiosos y espirituales"});
            this.checkedListBox2.Location = new System.Drawing.Point(98, 309);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox2.TabIndex = 73;
            // 
            // clbIdioma
            // 
            this.clbIdioma.FormattingEnabled = true;
            this.clbIdioma.Items.AddRange(new object[] {
            "Inglés",
            "Chino mandarín",
            "Español",
            "Francés"});
            this.clbIdioma.Location = new System.Drawing.Point(98, 460);
            this.clbIdioma.Name = "clbIdioma";
            this.clbIdioma.Size = new System.Drawing.Size(112, 64);
            this.clbIdioma.TabIndex = 74;
            // 
            // dtpAño
            // 
            this.dtpAño.Location = new System.Drawing.Point(75, 390);
            this.dtpAño.Name = "dtpAño";
            this.dtpAño.Size = new System.Drawing.Size(200, 20);
            this.dtpAño.TabIndex = 75;
            // 
            // nmdNumeroPaginas
            // 
            this.nmdNumeroPaginas.Location = new System.Drawing.Point(155, 542);
            this.nmdNumeroPaginas.Name = "nmdNumeroPaginas";
            this.nmdNumeroPaginas.Size = new System.Drawing.Size(132, 20);
            this.nmdNumeroPaginas.TabIndex = 76;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 77;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nmdNumeroPaginas);
            this.Controls.Add(this.dtpAño);
            this.Controls.Add(this.clbIdioma);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.clbTitulo);
            this.Controls.Add(this.txtIDLibro);
            this.Controls.Add(this.lblIDLibro);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblNumeroPaginas);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLibro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLibro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdNumeroPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblNumeroPaginas;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label lblIDLibro;
        private System.Windows.Forms.TextBox txtIDLibro;
        private System.Windows.Forms.CheckedListBox clbTitulo;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox clbIdioma;
        private System.Windows.Forms.DateTimePicker dtpAño;
        private System.Windows.Forms.NumericUpDown nmdNumeroPaginas;
        private System.Windows.Forms.Button button1;
    }
}