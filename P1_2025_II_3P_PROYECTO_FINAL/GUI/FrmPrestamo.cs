using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmPrestamo : Form
    {
        private DataManager dataManager;
        private Prestamo prestamoActual;
        private Usuario usuarioSeleccionado;
        private Libro libroSeleccionado;
        private Bibliotecario bibliotecarioActual;
        private bool modoEdicion = false;

        public FrmPrestamo()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaPrestamo.Enabled = false;

            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.Value = DateTime.Now.AddDays(14);
            dtpFechaVencimiento.MinDate = DateTime.Now.AddDays(1);

            dtpFechaEvolucion.Format = DateTimePickerFormat.Short;
            dtpFechaEvolucion.Enabled = false;

            txtIDprestamo.Enabled = false;

            txtEstado.Text = "Activo";
            txtEstado.Enabled = false;

            ConfigurarTooltips();
            ConfigurarBibliotecario();
            LimpiarFormulario();
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtUsuario, "Ingrese el código o nombre del usuario");
            toolTip.SetToolTip(txtLibro, "Ingrese el código, ISBN o título del libro");
            toolTip.SetToolTip(dtpFechaVencimiento, "Fecha límite para devolver el libro");
            toolTip.SetToolTip(btnGuardar, "Registrar nuevo préstamo");
            toolTip.SetToolTip(btnBuscar, "Buscar préstamo existente");
        }

        private void ConfigurarBibliotecario()
        {
            if (dataManager.Bibliotecarios.Any())
            {
                bibliotecarioActual = dataManager.Bibliotecarios.First(b => b.Activo);
                tbxBiblioteca.Text = bibliotecarioActual.NombreCompleto;
            }
            else
            {
                bibliotecarioActual = new Bibliotecario
                {
                    Id = 1,
                    Nombre = "Admin",
                    Apellido = "Sistema",
                    Correo = "admin@biblioteca.com",
                    Telefono = "0000-0000",
                    Direccion = "Biblioteca Central",
                    CodigoEmpleado = "EMP001",
                    NivelAcceso = "Administrador"
                };
                tbxBiblioteca.Text = bibliotecarioActual.NombreCompleto;
            }
            tbxBiblioteca.Enabled = false;
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            ActualizarCodigoPrestamo();
            ActualizarEstadisticas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos correctamente.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!modoEdicion)
                {
                    dataManager.CrearPrestamo
                    (
                        usuarioSeleccionado.Id,
                        libroSeleccionado.Id,
                        bibliotecarioActual.Id
                    );

                    MessageBox.Show($"Préstamo registrado exitosamente.\n\n" +
                                  $"Usuario: {usuarioSeleccionado.NombreCompleto}\n" +
                                  $"Libro: {libroSeleccionado.Titulo}\n" +
                                  $"Fecha de vencimiento: {dtpFechaVencimiento.Value:dd/MM/yyyy}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("¿Desea imprimir el comprobante del préstamo?",
                        "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ImprimirComprobante();
                    }

                    LimpiarFormulario();
                    ActualizarCodigoPrestamo();
                    ActualizarEstadisticas();
                }
                else
                {
                    if (prestamoActual != null && prestamoActual.EstadoPrestamo == "Activo")
                    {
                        prestamoActual.FechaVencimiento = dtpFechaVencimiento.Value;
                        prestamoActual.ActualizarFechaModificación();

                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Préstamo actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoPrestamo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el código del préstamo a buscar:",
                    "Buscar Préstamo", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                if (int.TryParse(busqueda, out int codigo))
                {
                    Prestamo prestamoEncontrado = dataManager.Prestamos.FirstOrDefault(p => p.Id == codigo);

                    if (prestamoEncontrado != null)
                    {
                        CargarPrestamoEnFormulario(prestamoEncontrado);
                        modoEdicion = true;
                        prestamoActual = prestamoEncontrado;
                        MessageBox.Show("Préstamo encontrado.", "Búsqueda exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Préstamo no encontrado.", "Búsqueda",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un código válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prestamoActual == null)
                {
                    MessageBox.Show("Primero debe buscar un préstamo para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show($"¿Está seguro que desea cancelar el préstamo ID: {prestamoActual.Id}?",
                    "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    prestamoActual.EstadoPrestamo = "Cancelado";
                    prestamoActual.ActualizarFechaModificación();

                    if (libroSeleccionado != null)
                    {
                        libroSeleccionado.CantidadDisponible++;
                    }

                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Préstamo cancelado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    modoEdicion = false;
                    ActualizarCodigoPrestamo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            modoEdicion = false;
            ActualizarCodigoPrestamo();
        }

        private bool ValidarFormulario()
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un usuario válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (libroSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un libro válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLibro.Focus();
                return false;
            }

            if (bibliotecarioActual == null)
            {
                MessageBox.Show("No hay bibliotecario asignado.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpFechaVencimiento.Value <= DateTime.Now)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a hoy.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CargarPrestamoEnFormulario(Prestamo prestamo)
        {
            txtIDprestamo.Text = prestamo.Id.ToString();

            var usuario = dataManager.BuscarUsuario(prestamo.UsuarioId);
            if (usuario != null)
            {
                usuarioSeleccionado = usuario;
                txtUsuario.Text = $"{usuario.Id} - {usuario.NombreCompleto}";
            }

            var libro = dataManager.BuscarLibro(prestamo.LibroId);
            if (libro != null)
            {
                libroSeleccionado = libro;
                txtLibro.Text = $"{libro.Id} - {libro.Titulo}";
            }

            dtpFechaPrestamo.Value = prestamo.FechaPrestamo;
            dtpFechaVencimiento.Value = prestamo.FechaVencimiento;

            if (prestamo.FechaDevolucion.HasValue)
            {
                dtpFechaEvolucion.Value = prestamo.FechaDevolucion.Value;
                dtpFechaEvolucion.Enabled = true;
            }

            txtEstado.Text = prestamo.EstadoPrestamo;

            var bibliotecario = dataManager.Bibliotecarios.FirstOrDefault(b => b.Id == prestamo.BibliotecarioId);
            if (bibliotecario != null)
            {
                tbxBiblioteca.Text = bibliotecario.NombreCompleto;
            }
        }

        private void LimpiarFormulario()
        {
            txtIDprestamo.Clear();
            txtUsuario.Clear();
            txtLibro.Clear();
            txtEstado.Text = "Activo";
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaVencimiento.Value = DateTime.Now.AddDays(14);
            dtpFechaEvolucion.Value = DateTime.Now;
            dtpFechaEvolucion.Enabled = false;

            usuarioSeleccionado = null;
            libroSeleccionado = null;
            prestamoActual = null;
            modoEdicion = false;

            lblUsuario.Text = "Usuario";
            lblLibro.Text = "Libro";
        }

        private void ActualizarCodigoPrestamo()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Prestamos.Any() ?
                    dataManager.Prestamos.Max(p => p.Id) + 1 : 1;
                txtIDprestamo.Text = proximoId.ToString();
            }
        }

        private void ActualizarEstadisticas()
        {
            try
            {
                int prestamosActivos = dataManager.Prestamos.Count(p => p.EstadoPrestamo == "Activo");
                int prestamosVencidos = dataManager.Prestamos.Count(p =>
                    p.EstadoPrestamo == "Activo" && p.FechaVencimiento < DateTime.Now);

                if (lblUsuario != null)
                    lblUsuario.Text = $"Préstamos Activos: {prestamosActivos}";
                if (lblLibro != null)
                    lblLibro.Text = $"Préstamos Vencidos: {prestamosVencidos}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar estadísticas: {ex.Message}");
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarUsuario();
                txtLibro.Focus();
            }
        }

        private void BuscarUsuario()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                    return;

                Usuario usuario = null;

                if (int.TryParse(txtUsuario.Text, out int id))
                {
                    usuario = dataManager.BuscarUsuario(id);
                }

                if (usuario == null)
                {
                    var usuarios = dataManager.Usuarios.Where(u =>
                        u.NombreCompleto.ToLower().Contains(txtUsuario.Text.ToLower())).ToList();

                    if (usuarios.Count == 1)
                    {
                        usuario = usuarios.First();
                    }
                    else if (usuarios.Count > 1)
                    {
                        usuario = MostrarListaSeleccionUsuarios(usuarios);
                    }
                }

                if (usuario != null)
                {
                    if (!usuario.Activo)
                    {
                        MessageBox.Show("El usuario está inactivo.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Clear();
                        usuarioSeleccionado = null;
                        return;
                    }

                    usuarioSeleccionado = usuario;
                    txtUsuario.Text = $"{usuario.Id} - {usuario.NombreCompleto}";
                    lblUsuario.Text = $"Usuario: {usuario.NombreCompleto}";
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Clear();
                    usuarioSeleccionado = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLibro_Leave(object sender, EventArgs e)
        {
            BuscarLibro();
        }

        private void txtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarLibro();
                dtpFechaVencimiento.Focus();
            }
        }

        private void BuscarLibro()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLibro.Text))
                    return;

                Libro libro = null;

                if (int.TryParse(txtLibro.Text, out int id))
                {
                    libro = dataManager.BuscarLibro(id);
                }

                if (libro == null)
                {
                    libro = dataManager.BuscarLibroPorISBN(txtLibro.Text);
                }

                if (libro == null)
                {
                    var librosPorTitulo = dataManager.BuscarLibrosPorTitulo(txtLibro.Text);
                    if (librosPorTitulo.Count == 1)
                    {
                        libro = librosPorTitulo.First();
                    }
                    else if (librosPorTitulo.Count > 1)
                    {
                        libro = MostrarListaSeleccionLibros(librosPorTitulo);
                    }
                }

                if (libro != null)
                {
                    if (!libro.Activo)
                    {
                        MessageBox.Show("El libro está inactivo.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLibro.Clear();
                        libroSeleccionado = null;
                        return;
                    }

                    if (libro.CantidadDisponible <= 0)
                    {
                        MessageBox.Show("No hay ejemplares disponibles.", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLibro.Clear();
                        libroSeleccionado = null;
                        return;
                    }

                    libroSeleccionado = libro;
                    txtLibro.Text = $"{libro.Id} - {libro.Titulo}";
                    lblLibro.Text = $"Libro: {libro.Titulo} (Disponibles: {libro.CantidadDisponible})";
                }
                else
                {
                    MessageBox.Show("Libro no encontrado.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLibro.Clear();
                    libroSeleccionado = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar libro: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario MostrarListaSeleccionUsuarios(List<Usuario> usuarios)
        {
            Form formSeleccion = new Form();
            formSeleccion.Text = "Seleccionar Usuario";
            formSeleccion.Size = new Size(400, 300);
            formSeleccion.StartPosition = FormStartPosition.CenterParent;

            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.DisplayMember = "NombreCompleto";
            listBox.ValueMember = "Id";
            listBox.DataSource = usuarios;

            Button btnSeleccionar = new Button();
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.Dock = DockStyle.Bottom;
            btnSeleccionar.DialogResult = DialogResult.OK;

            formSeleccion.Controls.Add(listBox);
            formSeleccion.Controls.Add(btnSeleccionar);

            Usuario usuarioSeleccionado = null;
            if (formSeleccion.ShowDialog() == DialogResult.OK && listBox.SelectedItem != null)
            {
                usuarioSeleccionado = (Usuario)listBox.SelectedItem;
            }

            return usuarioSeleccionado;
        }

        private Libro MostrarListaSeleccionLibros(List<Libro> libros)
        {
            Form formSeleccion = new Form();
            formSeleccion.Text = "Seleccionar Libro";
            formSeleccion.Size = new Size(500, 300);
            formSeleccion.StartPosition = FormStartPosition.CenterParent;

            ListBox listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;
            listBox.DisplayMember = "TituloCompleto";
            listBox.ValueMember = "Id";
            listBox.DataSource = libros;

            Button btnSeleccionar = new Button();
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.Dock = DockStyle.Bottom;
            btnSeleccionar.DialogResult = DialogResult.OK;

            formSeleccion.Controls.Add(listBox);
            formSeleccion.Controls.Add(btnSeleccionar);

            Libro libroSeleccionado = null;
            if (formSeleccion.ShowDialog() == DialogResult.OK && listBox.SelectedItem != null)
            {
                libroSeleccionado = (Libro)listBox.SelectedItem;
            }

            return libroSeleccionado;
        }

        private void ImprimirComprobante()
        {
            try
            {
                string comprobante = $@"
BIBLIOTECA UJCV - COMPROBANTE DE PRÉSTAMO
=========================================

Código de Préstamo: {txtIDprestamo.Text}
Fecha de Préstamo: {dtpFechaPrestamo.Value:dd/MM/yyyy}
Fecha de Vencimiento: {dtpFechaVencimiento.Value:dd/MM/yyyy}

USUARIO:
ID: {usuarioSeleccionado.Id}
Nombre: {usuarioSeleccionado.NombreCompleto}
Teléfono: {usuarioSeleccionado.Telefono}

LIBRO:
ID: {libroSeleccionado.Id}
Título: {libroSeleccionado.Titulo}
Autor: {libroSeleccionado.Autor}
ISBN: {libroSeleccionado.ISBN}

BIBLIOTECARIO:
{bibliotecarioActual.NombreCompleto}

Fecha de Emisión: {DateTime.Now:dd/MM/yyyy HH:mm:ss}

NOTA: Este libro debe ser devuelto antes de la fecha de vencimiento.
";

                // Aquí puedes implementar la impresión real o mostrar en un formulario
                MessageBox.Show(comprobante, "Comprobante de Préstamo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar comprobante: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}