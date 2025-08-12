using System;
using System.Linq;
using System.Windows.Forms;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmDevolucion : Form
    {
        private DataManager dataManager;
        private Devolucion devolucionActual;
        private Prestamo prestamoSeleccionado;
        private bool modoEdicion = false;

        public FrmDevolucion()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                dtpFechaObservacion.Format = DateTimePickerFormat.Short;
                dtpFechaObservacion.Value = DateTime.Now;
                dtpFechaObservacion.Enabled = false;

                txtIDdevolucion.Enabled = false;
                txtFechaDevolucion.Enabled = false;

                numericUsuario.Minimum = 1;
                numericUsuario.Maximum = 9999;
                numericULibro.Minimum = 1;
                numericULibro.Maximum = 9999;

                ConfigurarTooltips();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(numericUsuario, "ID del usuario que devuelve el libro");
            toolTip.SetToolTip(numericULibro, "ID del libro a devolver");
            toolTip.SetToolTip(txtFechaDevolucion, "Condición del libro: Excelente, Bueno, Regular, Malo, Perdido");
            toolTip.SetToolTip(txtObservacion, "Observaciones sobre la devolución");
            toolTip.SetToolTip(txtMultaAplicada, "Multa aplicada por retraso o daño");
        }

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            ActualizarCodigoDevolucion();
            CargarPrestamosActivos();
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

                var prestamo = dataManager.Prestamos.FirstOrDefault(
                    p => p.UsuarioId == (int)numericUsuario.Value &&
                         p.LibroId == (int)numericULibro.Value &&
                         p.EstadoPrestamo == "Activo");

                if (prestamo == null)
                {
                    MessageBox.Show("No se encontró un préstamo activo para este usuario y libro.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string condicion = txtFechaDevolucion.Text.Trim();
                if (string.IsNullOrWhiteSpace(condicion))
                    condicion = "Bueno";

                var condicionesValidas = new[] { "Excelente", "Bueno", "Regular", "Malo", "Perdido" };
                if (!condicionesValidas.Contains(condicion))
                {
                    MessageBox.Show("La condición debe ser: Excelente, Bueno, Regular, Malo o Perdido",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var bibliotecario = dataManager.Bibliotecarios.FirstOrDefault(b => b.Activo);
                int bibliotecarioId = bibliotecario?.Id ?? 1;

                dataManager.DevolverPrestamo(prestamo.Id, condicion, bibliotecarioId);

                if (!string.IsNullOrWhiteSpace(txtObservacion.Text))
                {
                    var devolucion = dataManager.Devoluciones.LastOrDefault();
                    if (devolucion != null)
                    {
                        devolucion.ObservacionesDevolucion = txtObservacion.Text.Trim();
                        dataManager.GuardarTodosLosDatos();
                    }
                }

                MessageBox.Show($"Devolución procesada exitosamente.\n" +
                              $"Multa aplicada: L. {prestamo.MultaAcumulada:F2}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarPrestamosActivos();
                ActualizarCodigoDevolucion();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error de operación: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar devolución: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID de la devolución o del préstamo a buscar:",
                    "Buscar Devolución", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                if (int.TryParse(busqueda, out int id))
                {
                    var devolucion = dataManager.Devoluciones.FirstOrDefault(d => d.Id == id);

                    if (devolucion != null)
                    {
                        CargarDevolucionEnFormulario(devolucion);
                        MessageBox.Show("Devolución encontrada.", "Búsqueda exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var prestamo = dataManager.Prestamos.FirstOrDefault(
                            p => p.Id == id && p.EstadoPrestamo == "Activo");

                        if (prestamo != null)
                        {
                            numericUsuario.Value = prestamo.UsuarioId;
                            numericULibro.Value = prestamo.LibroId;

                            prestamo.ActualizarEstado();
                            if (prestamo.DiasRetraso > 0)
                            {
                                txtMultaAplicada.Text = prestamo.MultaPorRetraso.ToString("F2");
                                MessageBox.Show($"Préstamo vencido. Días de retraso: {prestamo.DiasRetraso}\n" +
                                              $"Multa por retraso: L. {prestamo.MultaPorRetraso:F2}",
                                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            MessageBox.Show("Préstamo encontrado. Complete la información de devolución.",
                                "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró devolución o préstamo activo con ese ID.",
                                "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las devoluciones no pueden ser modificadas una vez procesadas.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las devoluciones no pueden ser eliminadas por integridad del sistema.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidarFormulario()
        {
            if (numericUsuario.Value <= 0 || numericULibro.Value <= 0)
            {
                return false;
            }

            var usuario = dataManager.BuscarUsuario((int)numericUsuario.Value);
            if (usuario == null)
            {
                MessageBox.Show("El usuario especificado no existe.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var libro = dataManager.BuscarLibro((int)numericULibro.Value);
            if (libro == null)
            {
                MessageBox.Show("El libro especificado no existe.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CargarDevolucionEnFormulario(Devolucion devolucion)
        {
            txtIDdevolucion.Text = devolucion.Id.ToString();
            numericUsuario.Value = devolucion.UsuarioId;
            numericULibro.Value = devolucion.LibroId;
            dtpFechaObservacion.Value = devolucion.FechaDevolucion;
            txtFechaDevolucion.Text = devolucion.CondicionLibro;
            txtObservacion.Text = devolucion.ObservacionesDevolucion;
            txtMultaAplicada.Text = devolucion.MultaAplicada.ToString("F2");

            devolucionActual = devolucion;
        }

        private void LimpiarFormulario()
        {
            txtIDdevolucion.Clear();
            numericUsuario.Value = 1;
            numericULibro.Value = 1;
            dtpFechaObservacion.Value = DateTime.Now;
            txtFechaDevolucion.Text = "Bueno";
            txtObservacion.Clear();
            txtMultaAplicada.Text = "0.00";

            devolucionActual = null;
            prestamoSeleccionado = null;
        }

        private void ActualizarCodigoDevolucion()
        {
            int proximoId = dataManager.Devoluciones.Any() ?
                dataManager.Devoluciones.Max(d => d.Id) + 1 : 1;
            txtIDdevolucion.Text = proximoId.ToString();
        }

        private void CargarPrestamosActivos()
        {
            try
            {
                var prestamosActivos = dataManager.Prestamos.Where(p => p.EstadoPrestamo == "Activo").ToList();

                if (prestamosActivos.Any())
                {
                    foreach (var prestamo in prestamosActivos)
                    {
                        prestamo.ActualizarEstado();
                    }
                    dataManager.GuardarTodosLosDatos();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar préstamos activos: {ex.Message}");
            }
        }

        private void numericUsuario_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var usuario = dataManager.BuscarUsuario((int)numericUsuario.Value);
                if (usuario != null)
                {
                    this.Text = $"Devolución - Usuario: {usuario.NombreCompleto}";
                }
            }
            catch { }
        }

        private void numericULibro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var libro = dataManager.BuscarLibro((int)numericULibro.Value);
                if (libro != null)
                {
                    var prestamo = dataManager.Prestamos.FirstOrDefault(
                        p => p.UsuarioId == (int)numericUsuario.Value &&
                             p.LibroId == (int)numericULibro.Value &&
                             p.EstadoPrestamo == "Activo");
                    if (prestamo != null)
                    {
                        prestamo.ActualizarEstado();
                        if (prestamo.DiasRetraso > 0)
                        {
                            txtMultaAplicada.Text = prestamo.MultaPorRetraso.ToString("F2");
                        }
                    }
                }
            }
            catch { }
        }
    }
}