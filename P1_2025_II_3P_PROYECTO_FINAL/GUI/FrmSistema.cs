using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmSistema : Form
    {
        private FrmLibro frmLibro;
        private FrmUsuario frmUsuario;
        private FrmAutor frmAutor;
        private FrmPrestamo frmPrestamo;
        private FrmDevolucion frmDevolucion;
        private FrmBibliotecario frmBibliotecario;
        private FrmCategoria frmCategoria;
        private FrmEditorial frmEditorial;
        private FrmHistorial frmHistorial;
        private FrmVentasLibros frmVentasLibros;
        private FrmUbicacion frmUbicacion;
        private FrmPaises frmPaises;
        public FrmSistema()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void FrmSistema_Load(object sender, EventArgs e)
        {

        }
        private void ConfigurarFormulario()
        {
            this.Text = "Sistema de Gestión de Biblioteca - Menú Principal";
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            ConfigurarEventosClick();

            MostrarFechaHora();
        }

        private void ConfigurarEventosClick()
        {
            lblLibro.Click += (s, e) => AbrirFormulario(ref frmLibro);
            lblUsuario.Click += (s, e) => AbrirFormulario(ref frmUsuario);
            lblAutor.Click += (s, e) => AbrirFormulario(ref frmAutor);
            lblPrestamo.Click += (s, e) => AbrirFormulario(ref frmPrestamo);
            lblDevocion.Click += (s, e) => AbrirFormulario(ref frmDevolucion);
            lblBlbliotecario.Click += (s, e) => AbrirFormulario(ref frmBibliotecario);
            lblcategoria.Click += (s, e) => AbrirFormulario(ref frmCategoria);
            lblEditorial.Click += (s, e) => AbrirFormulario(ref frmEditorial);
            lblHistorial.Click += (s, e) => AbrirFormulario(ref frmHistorial);
            lblVentasLibros.Click += (s, e) => AbrirFormulario(ref frmVentasLibros);
            lblUbicacion.Click += (s, e) => AbrirFormulario(ref frmUbicacion);
            lblPaises.Click += (s, e) => AbrirFormulario(ref frmPaises);

            pictureBox1.Click += (s, e) => AbrirFormulario(ref frmLibro);
            pictureBox2.Click += (s, e) => AbrirFormulario(ref frmUsuario);
            pictureBox3.Click += (s, e) => AbrirFormulario(ref frmAutor);
            pictureBox4.Click += (s, e) => AbrirFormulario(ref frmPrestamo);
            pictureBox5.Click += (s, e) => AbrirFormulario(ref frmDevolucion);
            pictureBox6.Click += (s, e) => AbrirFormulario(ref frmBibliotecario);
            pictureBox7.Click += (s, e) => AbrirFormulario(ref frmCategoria);
            pictureBox8.Click += (s, e) => AbrirFormulario(ref frmEditorial);
            pictureBox9.Click += (s, e) => AbrirFormulario(ref frmHistorial);
            pictureBox10.Click += (s, e) => AbrirFormulario(ref frmVentasLibros);
            pictureBox11.Click += (s, e) => AbrirFormulario(ref frmUbicacion);
            pictureBox12.Click += (s, e) => AbrirFormulario(ref frmPaises);

            ConfigurarCursores();
        }

        private void ConfigurarCursores()
        {
            lblLibro.Cursor = Cursors.Hand;
            lblUsuario.Cursor = Cursors.Hand;
            lblAutor.Cursor = Cursors.Hand;
            lblPrestamo.Cursor = Cursors.Hand;
            lblDevocion.Cursor = Cursors.Hand;
            lblBlbliotecario.Cursor = Cursors.Hand;
            lblcategoria.Cursor = Cursors.Hand;
            lblEditorial.Cursor = Cursors.Hand;
            lblHistorial.Cursor = Cursors.Hand;
            lblVentasLibros.Cursor = Cursors.Hand;
            lblUbicacion.Cursor = Cursors.Hand;
            lblPaises.Cursor = Cursors.Hand;

            pictureBox1.Cursor = Cursors.Hand;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox8.Cursor = Cursors.Hand;
            pictureBox9.Cursor = Cursors.Hand;
            pictureBox10.Cursor = Cursors.Hand;
            pictureBox11.Cursor = Cursors.Hand;
            pictureBox12.Cursor = Cursors.Hand;
        }

        private void AbrirFormulario<T>(ref T formulario) where T : Form, new()
        {
            try
            {
                if (formulario == null || formulario.IsDisposed)
                {
                    formulario = new T();
                    formulario.MdiParent = this;
                    formulario.Show();
                }
                else
                {
                    formulario.BringToFront();
                    formulario.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarFechaHora()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                if (label2 != null)
                    label2.Text = $"Fecha: {DateTime.Now:dd/MM/yyyy}";
                if (label3 != null)
                    label3.Text = $"Hora: {DateTime.Now:HH:mm:ss}";
            };
            timer.Start();
        }

        private void MostrarEstadisticas()
        {
            try
            {
                string estadisticas = "ESTADÍSTICAS DEL SISTEMA\n";
                estadisticas += "========================\n\n";

                estadisticas += $"Usuarios registrados: {ContarRegistros("usuarios.json")}\n";
                estadisticas += $"Libros en catálogo: {ContarRegistros("libros.json")}\n";
                estadisticas += $"Préstamos activos: {ContarRegistros("prestamos.json")}\n";
                estadisticas += $"Bibliotecarios: {ContarRegistros("bibliotecarios.json")}\n";
                estadisticas += $"Autores: {ContarRegistros("autores.json")}\n";
                estadisticas += $"Categorías: {ContarRegistros("categorias.json")}\n";

                if (label4 != null)
                    label4.Text = "Usuarios: " + ContarRegistros("usuarios.json");
                if (label5 != null)
                    label5.Text = "Libros: " + ContarRegistros("libros.json");
                if (label6 != null)
                    label6.Text = "Préstamos: " + ContarRegistros("prestamos.json");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar estadísticas: {ex.Message}");
            }
        }

        private int ContarRegistros(string archivo)
        {
            try
            {
                if (System.IO.File.Exists(archivo))
                {
                    string json = System.IO.File.ReadAllText(archivo);
                    dynamic lista = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                    if (lista != null && lista.Count != null)
                        return lista.Count;
                }
            }
            catch
            {
            }
            return 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MostrarEstadisticas();

            label1.Text = "Sistema de Gestión de Biblioteca";
            label7.Text = "Bienvenido al Sistema";
        }

        private void CerrarTodosLosFormularios()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                CerrarTodosLosFormularios();
            }

            base.OnFormClosing(e);
        }

        private void AgregarEfectosHover()
        {
            pictureBox1.MouseEnter += (s, e) => CambiarBorde(pictureBox1, true);
            pictureBox1.MouseLeave += (s, e) => CambiarBorde(pictureBox1, false);

            pictureBox2.MouseEnter += (s, e) => CambiarBorde(pictureBox2, true);
            pictureBox2.MouseLeave += (s, e) => CambiarBorde(pictureBox2, false);

            pictureBox3.MouseEnter += (s, e) => CambiarBorde(pictureBox3, true);
            pictureBox3.MouseLeave += (s, e) => CambiarBorde(pictureBox3, false);

            pictureBox4.MouseEnter += (s, e) => CambiarBorde(pictureBox4, true);
            pictureBox4.MouseLeave += (s, e) => CambiarBorde(pictureBox4, false);

            pictureBox5.MouseEnter += (s, e) => CambiarBorde(pictureBox5, true);
            pictureBox5.MouseLeave += (s, e) => CambiarBorde(pictureBox5, false);

            pictureBox6.MouseEnter += (s, e) => CambiarBorde(pictureBox6, true);
            pictureBox6.MouseLeave += (s, e) => CambiarBorde(pictureBox6, false);

            pictureBox7.MouseEnter += (s, e) => CambiarBorde(pictureBox7, true);
            pictureBox7.MouseLeave += (s, e) => CambiarBorde(pictureBox7, false);

            pictureBox8.MouseEnter += (s, e) => CambiarBorde(pictureBox8, true);
            pictureBox8.MouseLeave += (s, e) => CambiarBorde(pictureBox8, false);

            pictureBox9.MouseEnter += (s, e) => CambiarBorde(pictureBox9, true);
            pictureBox9.MouseLeave += (s, e) => CambiarBorde(pictureBox9, false);

            pictureBox10.MouseEnter += (s, e) => CambiarBorde(pictureBox10, true);
            pictureBox10.MouseLeave += (s, e) => CambiarBorde(pictureBox10, false);

            pictureBox11.MouseEnter += (s, e) => CambiarBorde(pictureBox11, true);
            pictureBox11.MouseLeave += (s, e) => CambiarBorde(pictureBox11, false);

            pictureBox12.MouseEnter += (s, e) => CambiarBorde(pictureBox12, true);
            pictureBox12.MouseLeave += (s, e) => CambiarBorde(pictureBox12, false);
        }

        private void CambiarBorde(PictureBox pictureBox, bool resaltar)
        {
            if (resaltar)
            {
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictureBox.BackColor = Color.LightBlue;
            }
            else
            {
                pictureBox.BorderStyle = BorderStyle.None;
                pictureBox.BackColor = Color.Transparent;
            }
        }
    }
}