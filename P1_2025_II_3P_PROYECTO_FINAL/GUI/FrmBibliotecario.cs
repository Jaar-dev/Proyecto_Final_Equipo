using System;
using System.Linq;
using System.Windows.Forms;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmBibliotecario : Form
    {
        private DataManager dataManager;
        private Bibliotecario bibliotecarioActual;
        private bool modoEdicion = false;

        public FrmBibliotecario()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                dtpFechaIngreso.Format = DateTimePickerFormat.Short;
                dtpFechaIngreso.Value = DateTime.Now;

                txtIdBibliotecario.Enabled = false;

                rbMatutino.Checked = true;

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
            toolTip.SetToolTip(txtNombre, "Ingrese el nombre completo del bibliotecario");
            toolTip.SetToolTip(txtCorreoElectronico, "Ingrese un correo electrónico válido");
            toolTip.SetToolTip(txtTelefono, "Formato: ####-####");
            toolTip.SetToolTip(txtDireccion, "Ingrese la dirección completa");
            toolTip.SetToolTip(dtpFechaIngreso, "Seleccione la fecha de ingreso");
        }

        private void FrmBibliotecario_Load(object sender, EventArgs e)
        {
            ActualizarCodigoBibliotecario();
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
                    Bibliotecario nuevoBibliotecario = new Bibliotecario();
                    AsignarDatosBibliotecario(nuevoBibliotecario);
                    nuevoBibliotecario.Id = dataManager.Bibliotecarios.Any() ?
                        dataManager.Bibliotecarios.Max(b => b.Id) + 1 : 1;

                    dataManager.Bibliotecarios.Add(nuevoBibliotecario);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Bibliotecario guardado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigoBibliotecario();
                }
                else
                {
                    if (bibliotecarioActual != null)
                    {
                        AsignarDatosBibliotecario(bibliotecarioActual);
                        bibliotecarioActual.ActualizarFechaModificación();

                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Bibliotecario actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoBibliotecario();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error de validación: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    "Ingrese el código de empleado o nombre del bibliotecario a buscar:",
                    "Buscar Bibliotecario", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                Bibliotecario bibliotecarioEncontrado = null;

                bibliotecarioEncontrado = dataManager.Bibliotecarios.FirstOrDefault(
                    b => b.CodigoEmpleado.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

                if (bibliotecarioEncontrado == null)
                {
                    bibliotecarioEncontrado = dataManager.Bibliotecarios.FirstOrDefault(
                        b => b.NombreCompleto != null && b.NombreCompleto.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                if (bibliotecarioEncontrado != null)
                {
                    CargarBibliotecarioEnFormulario(bibliotecarioEncontrado);
                    modoEdicion = true;
                    bibliotecarioActual = bibliotecarioEncontrado;
                    MessageBox.Show("Bibliotecario encontrado.", "Búsqueda exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bibliotecario no encontrado.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (bibliotecarioActual == null)
            {
                MessageBox.Show("Primero debe buscar un bibliotecario para modificar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modoEdicion = true;
            MessageBox.Show("Modo edición activado. Modifique los campos y presione Guardar.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bibliotecarioActual == null)
                {
                    MessageBox.Show("Primero debe buscar un bibliotecario para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var prestamosActivos = dataManager.Prestamos.Where(
                    p => p.BibliotecarioId == bibliotecarioActual.Id &&
                    p.EstadoPrestamo == "Activo").ToList();

                if (prestamosActivos.Any())
                {
                    MessageBox.Show($"No se puede eliminar el bibliotecario porque tiene {prestamosActivos.Count} préstamos activos gestionados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar al bibliotecario {bibliotecarioActual.NombreCompleto}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    bibliotecarioActual.Activo = false;
                    bibliotecarioActual.Estado = "Eliminado";
                    bibliotecarioActual.ActualizarFechaModificación();

                    dataManager.GuardarTodosLosDatos();

                    LimpiarFormulario();
                    modoEdicion = false;
                    bibliotecarioActual = null;

                    MessageBox.Show("Bibliotecario eliminado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d{4}-\d{4}$"))
            {
                MessageBox.Show("El formato del teléfono debe ser: ####-####", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreoElectronico.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del correo electrónico es inválido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rbMatutino.Checked && !rbVespertino.Checked && !rbNocturno.Checked)
            {
                MessageBox.Show("Debe seleccionar un turno.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AsignarDatosBibliotecario(Bibliotecario bibliotecario)
        {
            string[] partesNombre = txtNombre.Text.Trim().Split(' ');
            if (partesNombre.Length >= 2)
            {
                bibliotecario.Nombre = string.Join(" ", partesNombre.Take(partesNombre.Length - 1));
                bibliotecario.Apellido = partesNombre.Last();
            }
            else
            {
                bibliotecario.Nombre = txtNombre.Text.Trim();
                bibliotecario.Apellido = "Apellido";
            }

            bibliotecario.Correo = txtCorreoElectronico.Text.Trim();
            bibliotecario.Telefono = txtTelefono.Text.Trim();
            bibliotecario.Direccion = txtDireccion.Text.Trim();
            bibliotecario.FechaContratacion = dtpFechaIngreso.Value;

            if (rbMatutino.Checked)
                bibliotecario.Turno = "Matutino";
            else if (rbVespertino.Checked)
                bibliotecario.Turno = "Vespertino";
            else if (rbNocturno.Checked)
                bibliotecario.Turno = "Nocturno";

            if (string.IsNullOrWhiteSpace(bibliotecario.CodigoEmpleado))
            {
                bibliotecario.CodigoEmpleado = GenerarCodigoEmpleado();
            }

            bibliotecario.Salario = 15000;
            bibliotecario.Departamento = "Biblioteca";
            bibliotecario.NivelAcceso = "Intermedio";
            bibliotecario.Especialidad = "General";
            bibliotecario.Identificacion = "0000000000000";
            bibliotecario.FechaNacimiento = DateTime.Now.AddYears(-25);
            bibliotecario.Genero = "No especificado";
        }

        private void CargarBibliotecarioEnFormulario(Bibliotecario bibliotecario)
        {
            txtIdBibliotecario.Text = bibliotecario.Id.ToString();
            txtNombre.Text = bibliotecario.NombreCompleto;
            txtCorreoElectronico.Text = bibliotecario.Correo;
            txtTelefono.Text = bibliotecario.Telefono;
            txtDireccion.Text = bibliotecario.Direccion;
            dtpFechaIngreso.Value = bibliotecario.FechaContratacion;

            // Seleccionar turno
            switch (bibliotecario.Turno)
            {
                case "Matutino":
                    rbMatutino.Checked = true;
                    break;
                case "Vespertino":
                    rbVespertino.Checked = true;
                    break;
                case "Nocturno":
                    rbNocturno.Checked = true;
                    break;
            }
        }

        private void LimpiarFormulario()
        {
            txtIdBibliotecario.Clear();
            txtNombre.Clear();
            txtCorreoElectronico.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
            rbMatutino.Checked = true;

            modoEdicion = false;
            bibliotecarioActual = null;
        }

        private void ActualizarCodigoBibliotecario()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Bibliotecarios.Any() ?
                    dataManager.Bibliotecarios.Max(b => b.Id) + 1 : 1;
                txtIdBibliotecario.Text = proximoId.ToString();
            }
        }

        private string GenerarCodigoEmpleado()
        {
            int numero = dataManager.Bibliotecarios.Count() + 1;
            return $"BIB{numero:D4}";
        }
    }
}