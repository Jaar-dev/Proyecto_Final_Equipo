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
            MostrarEstadisticas();
        }
        private void ConfigurarFormulario()
        {
            this.Text = "Sistema de Gestión de Biblioteca - Menú Principal";
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            ConfigurarEventosClick();
            ConfigurarCursores();
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

            pbLibro.Click += (s, e) => AbrirFormulario(ref frmLibro);
            pbUsuario.Click += (s, e) => AbrirFormulario(ref frmUsuario);
            pbAutor.Click += (s, e) => AbrirFormulario(ref frmAutor);
            pbPaises.Click += (s, e) => AbrirFormulario(ref frmPaises);
            pbPrestamo.Click += (s, e) => AbrirFormulario(ref frmPrestamo);
            pbDevolucion.Click += (s, e) => AbrirFormulario(ref frmDevolucion);
            pbBibliotecario.Click += (s, e) => AbrirFormulario(ref frmBibliotecario);
            pbCategoria.Click += (s, e) => AbrirFormulario(ref frmCategoria);
            pbEditorial.Click += (s, e) => AbrirFormulario(ref frmEditorial);
            pbHistorial.Click += (s, e) => AbrirFormulario(ref frmHistorial);
            pbVentasLibros.Click += (s, e) => AbrirFormulario(ref frmVentasLibros);
            pbUbicacion.Click += (s, e) => AbrirFormulario(ref frmUbicacion);
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

            pbLibro.Cursor = Cursors.Hand;
            pbAutor.Cursor = Cursors.Hand;
            pbUsuario.Cursor = Cursors.Hand;
            pbDevolucion.Cursor = Cursors.Hand;
            pbEditorial.Cursor = Cursors.Hand;
            pbPrestamo.Cursor = Cursors.Hand;
            pbBibliotecario.Cursor = Cursors.Hand;
            pbCategoria.Cursor = Cursors.Hand;
            pbHistorial.Cursor = Cursors.Hand;
            pbVentasLibros.Cursor = Cursors.Hand;
            pbUbicacion.Cursor = Cursors.Hand;
            pbPaises.Cursor = Cursors.Hand;
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
                if (lblFecha != null)
                    lblFecha.Text = $"Fecha: {DateTime.Now:dd/MM/yyyy}";
                if (lblHora != null)
                    lblHora.Text = $"Hora: {DateTime.Now:HH:mm:ss}";
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

                if (lblUsuarios != null)
                    lblUsuarios.Text = "Usuarios Registrados: " + ContarRegistros("usuarios.json");
                if (lblLibrosR != null)
                    lblLibrosR.Text = "Libros Registrados: " + ContarRegistros("libros.json");
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

            lblTitulo.Text = "Sistema de Biblioteca UJCV";
            lblBS.Text = "Bienvenido al Sistema";
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
            pbLibro.MouseEnter += (s, e) => CambiarBorde(pbLibro, true);
            pbLibro.MouseLeave += (s, e) => CambiarBorde(pbLibro, false);

            pbAutor.MouseEnter += (s, e) => CambiarBorde(pbAutor, true);
            pbAutor.MouseLeave += (s, e) => CambiarBorde(pbAutor, false);

            pbUsuario.MouseEnter += (s, e) => CambiarBorde(pbUsuario, true);
            pbUsuario.MouseLeave += (s, e) => CambiarBorde(pbUsuario, false);

            pbDevolucion.MouseEnter += (s, e) => CambiarBorde(pbDevolucion, true);
            pbDevolucion.MouseLeave += (s, e) => CambiarBorde(pbDevolucion, false);

            pbEditorial.MouseEnter += (s, e) => CambiarBorde(pbEditorial, true);
            pbEditorial.MouseLeave += (s, e) => CambiarBorde(pbEditorial, false);

            pbPrestamo.MouseEnter += (s, e) => CambiarBorde(pbPrestamo, true);
            pbPrestamo.MouseLeave += (s, e) => CambiarBorde(pbPrestamo, false);

            pbBibliotecario.MouseEnter += (s, e) => CambiarBorde(pbBibliotecario, true);
            pbBibliotecario.MouseLeave += (s, e) => CambiarBorde(pbBibliotecario, false);

            pbCategoria.MouseEnter += (s, e) => CambiarBorde(pbCategoria, true);
            pbCategoria.MouseLeave += (s, e) => CambiarBorde(pbCategoria, false);

            pbHistorial.MouseEnter += (s, e) => CambiarBorde(pbHistorial, true);
            pbHistorial.MouseLeave += (s, e) => CambiarBorde(pbHistorial, false);

            pbVentasLibros.MouseEnter += (s, e) => CambiarBorde(pbVentasLibros, true);
            pbVentasLibros.MouseLeave += (s, e) => CambiarBorde(pbVentasLibros, false);

            pbUbicacion.MouseEnter += (s, e) => CambiarBorde(pbUbicacion, true);
            pbUbicacion.MouseLeave += (s, e) => CambiarBorde(pbUbicacion, false);

            pbPaises.MouseEnter += (s, e) => CambiarBorde(pbPaises, true);
            pbPaises.MouseLeave += (s, e) => CambiarBorde(pbPaises, false);
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