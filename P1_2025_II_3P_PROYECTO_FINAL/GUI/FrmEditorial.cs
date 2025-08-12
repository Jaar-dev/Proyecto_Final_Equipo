using System;
using System.Linq;
using System.Windows.Forms;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmEditorial : Form
    {
        private DataManager dataManager;
        private Editorial editorialActual;
        private bool modoEdicion = false;

        public FrmEditorial()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                dtpAñoFundacion.Format = DateTimePickerFormat.Custom;
                dtpAñoFundacion.CustomFormat = "yyyy";
                dtpAñoFundacion.ShowUpDown = true;
                dtpAñoFundacion.Value = new DateTime(2000, 1, 1);
                txtCodigoEditorial.Enabled = false;

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
            toolTip.SetToolTip(txtNombre, "Ingrese el nombre de la editorial (3-100 caracteres)");
            toolTip.SetToolTip(txtDireccion, "Ingrese la dirección de la editorial");
            toolTip.SetToolTip(txtTelefono, "Formato: ####-####");
            toolTip.SetToolTip(txtCorreoElectronico, "Ingrese un correo electrónico válido");
            toolTip.SetToolTip(txtSitioWeb, "Ingrese la URL del sitio web (debe comenzar con http)");
            toolTip.SetToolTip(dtpAñoFundacion, "Seleccione el año de fundación");
        }

        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            ActualizarCodigoEditorial();
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
                    Editorial nuevaEditorial = new Editorial();
                    AsignarDatosEditorial(nuevaEditorial);
                    nuevaEditorial.Id = dataManager.Editoriales.Any() ?
                        dataManager.Editoriales.Max(ed => ed.Id) + 1 : 1;

                    dataManager.Editoriales.Add(nuevaEditorial);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Editorial guardada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigoEditorial();
                }
                else
                {
                    if (editorialActual != null)
                    {
                        AsignarDatosEditorial(editorialActual);
                        editorialActual.ActualizarFechaModificación();

                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Editorial actualizada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoEditorial();
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
                    "Ingrese el código o nombre de la editorial a buscar:",
                    "Buscar Editorial", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                Editorial editorialEncontrada = null;

                if (int.TryParse(busqueda, out int codigo))
                {
                    editorialEncontrada = dataManager.Editoriales.FirstOrDefault(ed => ed.Id == codigo);
                }

                if (editorialEncontrada == null)
                {
                    editorialEncontrada = dataManager.Editoriales.FirstOrDefault(
                        ed => ed.Nombre != null && ed.Nombre.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                if (editorialEncontrada != null)
                {
                    CargarEditorialEnFormulario(editorialEncontrada);
                    modoEdicion = true;
                    editorialActual = editorialEncontrada;
                    MessageBox.Show("Editorial encontrada.", "Búsqueda exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Editorial no encontrada.", "Búsqueda",
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
            if (editorialActual == null)
            {
                MessageBox.Show("Primero debe buscar una editorial para modificar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            modoEdicion = true;
            txtCodigoEditorial.Enabled = false;
            MessageBox.Show("Modo edición activado. Modifique los campos y presione Guardar.",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editorialActual == null)
                {
                    MessageBox.Show("Primero debe buscar una editorial para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var librosEditorial = dataManager.Libros.Where(
                    l => l.Editorial == editorialActual.Nombre && l.Activo).ToList();

                if (librosEditorial.Any())
                {
                    MessageBox.Show($"No se puede eliminar la editorial porque tiene {librosEditorial.Count} libros asociados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar la editorial '{editorialActual.Nombre}'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    editorialActual.Activo = false;
                    editorialActual.Estado = "Eliminado";
                    editorialActual.ActualizarFechaModificación();

                    dataManager.GuardarTodosLosDatos();

                    LimpiarFormulario();
                    modoEdicion = false;
                    editorialActual = null;

                    MessageBox.Show("Editorial eliminada exitosamente.", "Éxito",
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
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
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

            if (!string.IsNullOrWhiteSpace(txtSitioWeb.Text) && !txtSitioWeb.Text.StartsWith("http"))
            {
                MessageBox.Show("El sitio web debe comenzar con 'http'", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int año = dtpAñoFundacion.Value.Year;
            if (año < 1450 || año > DateTime.Now.Year)
            {
                MessageBox.Show($"El año de fundación debe estar entre 1450 y {DateTime.Now.Year}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AsignarDatosEditorial(Editorial editorial)
        {
            editorial.Nombre = txtNombre.Text.Trim();
            editorial.Direccion = txtDireccion.Text.Trim();
            editorial.Telefono = txtTelefono.Text.Trim();
            editorial.Correo = txtCorreoElectronico.Text.Trim();
            editorial.SitioWeb = txtSitioWeb.Text.Trim();
            editorial.AñoFundacion = dtpAñoFundacion.Value.Year;
            editorial.Pais = "Honduras";
            editorial.LibrosPublicados = 0;
        }

        private void CargarEditorialEnFormulario(Editorial editorial)
        {
            txtCodigoEditorial.Text = editorial.Id.ToString();
            txtNombre.Text = editorial.Nombre;
            txtDireccion.Text = editorial.Direccion;
            txtTelefono.Text = editorial.Telefono;
            txtCorreoElectronico.Text = editorial.Correo;
            txtSitioWeb.Text = editorial.SitioWeb;
            dtpAñoFundacion.Value = new DateTime(editorial.AñoFundacion, 1, 1);
        }

        private void LimpiarFormulario()
        {
            txtCodigoEditorial.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreoElectronico.Clear();
            txtSitioWeb.Clear();
            dtpAñoFundacion.Value = new DateTime(2000, 1, 1);

            modoEdicion = false;
            editorialActual = null;
            txtCodigoEditorial.Enabled = false;
        }

        private void ActualizarCodigoEditorial()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Editoriales.Any() ?
                    dataManager.Editoriales.Max(e => e.Id) + 1 : 1;
                txtCodigoEditorial.Text = proximoId.ToString();
            }
        }
    }
}