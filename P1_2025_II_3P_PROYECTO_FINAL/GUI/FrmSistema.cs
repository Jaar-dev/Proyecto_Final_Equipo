using Newtonsoft.Json;
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
            AgregarEfectosHover();
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
            pbPrestamo.Click += (s, e) => AbrirFormulario(ref frmPrestamo);
            pbDevolucion.Click += (s, e) => AbrirFormulario(ref frmDevolucion);
            pbBibliotecario.Click += (s, e) => AbrirFormulario(ref frmBibliotecario);
            pbCategoria.Click += (s, e) => AbrirFormulario(ref frmCategoria);
            pbEditorial.Click += (s, e) => AbrirFormulario(ref frmEditorial);
            pbHistorial.Click += (s, e) => AbrirFormulario(ref frmHistorial);
            pbVentasLibros.Click += (s, e) => AbrirFormulario(ref frmVentasLibros);
            pbUbicacion.Click += (s, e) => AbrirFormulario(ref frmUbicacion);
            pbPaises.Click += (s, e) => AbrirFormulario(ref frmPaises);
        }

        private void ConfigurarCursores()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl && lbl.Name.StartsWith("lbl"))
                    lbl.Cursor = Cursors.Hand;
                if (ctrl is PictureBox pb && pb.Name.StartsWith("pb"))
                    pb.Cursor = Cursors.Hand;
            }
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
                lblFecha.Text = $"Fecha: {DateTime.Now:dd/MM/yyyy}";
                lblHora.Text = $"Hora: {DateTime.Now:HH:mm:ss}";
            };
            timer.Start();
        }

        private void MostrarEstadisticas()
        {
            try
            {
                var usuarios = ContarRegistros("usuarios.json");
                var libros = ContarRegistros("libros.json");
                var prestamos = ContarRegistros("prestamos.json");
                var bibliotecarios = ContarRegistros("bibliotecarios.json");
                var autores = ContarRegistros("autores.json");
                var categorias = ContarRegistros("categorias.json");

                string estadisticas = $"ESTADÍSTICAS DEL SISTEMA\n========================\n\n" +
                                      $"Usuarios registrados: {usuarios}\n" +
                                      $"Libros en catálogo: {libros}\n" +
                                      $"Préstamos activos: {prestamos}\n" +
                                      $"Bibliotecarios: {bibliotecarios}\n" +
                                      $"Autores: {autores}\n" +
                                      $"Categorías: {categorias}\n";

                lblUsuarios.Text = $"Usuarios Registrados: {usuarios}";
                lblLibrosR.Text = $"Libros Registrados: {libros}";
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
                    dynamic lista = JsonConvert.DeserializeObject(json);
                    if (lista != null && lista.Count != null)
                        return lista.Count;
                }
            }
            catch { }
            return 0;
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
                base.OnFormClosing(e);
            }
        }

        private void CerrarTodosLosFormularios()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void AgregarEfectosHover()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is PictureBox pb && pb.Name.StartsWith("pb"))
                {
                    pb.MouseEnter += (s, e) => CambiarBorde(pb, true);
                    pb.MouseLeave += (s, e) => CambiarBorde(pb, false);
                }
            }
        }

        private void CambiarBorde(PictureBox pictureBox, bool resaltar)
        {
            pictureBox.BorderStyle = resaltar ? BorderStyle.Fixed3D : BorderStyle.None;
            pictureBox.BackColor = resaltar ? Color.LightBlue : Color.Transparent;
        }
    }
}
