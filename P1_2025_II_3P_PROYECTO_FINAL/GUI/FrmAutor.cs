using System;
using System.Linq;
using System.Windows.Forms;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmAutor : Form
    {
        private DataManager dataManager;
        private Autor autorActual;
        private bool modoEdicion = false;

        public FrmAutor()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
                dtpFechaNacimiento.MaxDate = DateTime.Now.AddYears(-18);
                dtpFechaNacimiento.Value = DateTime.Now.AddYears(-30);
                dtpFechaRegistro.Format = DateTimePickerFormat.Short;
                dtpFechaRegistro.Value = DateTime.Now;
                dtpFechaRegistro.Enabled = false;
                txtIDAutor.Enabled = false;

                CargarCombos();

                ConfigurarTooltips();

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            try
            {
                cmbGenero.Items.Clear();
                cmbGenero.Items.AddRange(new string[] {
                    "-- Seleccione --",
                    "Ficción",
                    "No Ficción",
                    "Poesía",
                    "Drama",
                    "Ensayo",
                    "Ciencia Ficción",
                    "Fantasía",
                    "Misterio",
                    "Romance",
                    "Histórico"
                });
                cmbGenero.SelectedIndex = 0;

                if (cmbNacionalidad.Items.Count > 0)
                    cmbNacionalidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtNombre, "Ingrese el nombre del autor");
            toolTip.SetToolTip(txtApellido, "Ingrese el apellido del autor");
            toolTip.SetToolTip(txtBiografia, "Biografía del autor (mínimo 30 caracteres)");
            toolTip.SetToolTip(cmbGenero, "Seleccione el género literario principal");
            toolTip.SetToolTip(cmbNacionalidad, "Seleccione la nacionalidad del autor");
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            ActualizarCodigoAutor();
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
                    Autor nuevoAutor = new Autor();
                    AsignarDatosAutor(nuevoAutor);
                    nuevoAutor.Id = dataManager.Autores.Any() ?
                        dataManager.Autores.Max(a => a.Id) + 1 : 1;

                    dataManager.Autores.Add(nuevoAutor);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Autor guardado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigoAutor();
                }
                else
                {
                    if (autorActual != null)
                    {
                        AsignarDatosAutor(autorActual);
                        autorActual.ActualizarFechaModificación();

                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Autor actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoAutor();
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
                    "Ingrese el código o nombre del autor a buscar:",
                    "Buscar Autor", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                Autor autorEncontrado = null;

                if (int.TryParse(busqueda, out int codigo))
                {
                    autorEncontrado = dataManager.Autores.FirstOrDefault(a => a.Id == codigo);
                }

                if (autorEncontrado == null)
                {
                    autorEncontrado = dataManager.Autores.FirstOrDefault(
                        a => a.NombreCompleto != null && a.NombreCompleto.ToLower().Contains(busqueda.ToLower()));
                    autorActual = autorEncontrado;
                    MessageBox.Show("Autor encontrado.", "Búsqueda exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (autorEncontrado != null)
                {
                    CargarAutorEnFormulario(autorEncontrado);
                    modoEdicion = true;
                }
                else
                {
                    MessageBox.Show("Autor no encontrado.", "Búsqueda",
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
            if (autorActual == null)
            {
                MessageBox.Show("Primero debe buscar un autor para modificar.",
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
                if (autorActual == null)
                {
                    MessageBox.Show("Primero debe buscar un autor para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar al autor {autorActual.NombreCompleto}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    autorActual.Activo = false;
                    autorActual.AutorActivo = false;
                    autorActual.Estado = "Eliminado";
                    autorActual.ActualizarFechaModificación();

                    dataManager.GuardarTodosLosDatos();

                    LimpiarFormulario();
                    modoEdicion = false;
                    autorActual = null;

                    MessageBox.Show("Autor eliminado exitosamente.", "Éxito",
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
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                cmbNacionalidad.SelectedIndex < 0 ||
                cmbGenero.SelectedIndex <= 0)
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtBiografia.Text) && txtBiografia.Text.Length < 30)
            {
                MessageBox.Show("La biografía debe tener al menos 30 caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AsignarDatosAutor(Autor autor)
        {
            autor.Nombre = txtNombre.Text.Trim();
            autor.Apellido = txtApellido.Text.Trim();
            autor.FechaNacimiento = dtpFechaNacimiento.Value;

            if (cmbNacionalidad.SelectedIndex >= 0)
                autor.Nacionalidad = cmbNacionalidad.SelectedItem.ToString();

            if (cmbGenero.SelectedIndex > 0)
                autor.GeneroLiterario = cmbGenero.SelectedItem.ToString();

            autor.Biografia = txtBiografia.Text.Trim();

            autor.Telefono = "0000-0000";
            autor.Correo = $"{autor.Nombre.ToLower()}.{autor.Apellido.ToLower()}@autor.com";
            autor.Direccion = "Dirección no especificada";
            autor.Identificacion = "0000000000000";
            autor.Genero = "No especificado";
        }

        private void CargarAutorEnFormulario(Autor autor)
        {
            txtIDAutor.Text = autor.Id.ToString();
            txtNombre.Text = autor.Nombre;
            txtApellido.Text = autor.Apellido;
            dtpFechaNacimiento.Value = autor.FechaNacimiento;

            for (int i = 0; i < cmbNacionalidad.Items.Count; i++)
            {
                if (cmbNacionalidad.Items[i].ToString() == autor.Nacionalidad)
                {
                    cmbNacionalidad.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbGenero.Items.Count; i++)
            {
                if (cmbGenero.Items[i].ToString() == autor.GeneroLiterario)
                {
                    cmbGenero.SelectedIndex = i;
                    break;
                }
            }

            txtBiografia.Text = autor.Biografia;
            dtpFechaRegistro.Value = autor.FechaCreación;
        }

        private void LimpiarFormulario()
        {
            txtIDAutor.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtBiografia.Clear();
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-30);
            dtpFechaRegistro.Value = DateTime.Now;
            cmbNacionalidad.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;

            modoEdicion = false;
            autorActual = null;
        }

        private void ActualizarCodigoAutor()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Autores.Any() ?
                    dataManager.Autores.Max(a => a.Id) + 1 : 1;
                txtIDAutor.Text = proximoId.ToString();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Método vacío, puede implementar validación en tiempo real si se desea
        }
    }
}