using System;
using System.Linq;
using System.Windows.Forms;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmCategoria : Form
    {
        private DataManager dataManager;
        private Categoria categoriaActual;
        private bool modoEdicion = false;

        public FrmCategoria()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                dtpFechaCreacion.Format = DateTimePickerFormat.Short;
                dtpFechaCreacion.Value = DateTime.Now;
                dtpFechaCreacion.Enabled = false;
                rbActiva.Checked = true;

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
                cmbAreaTematica.Items.Clear();
                cmbAreaTematica.Items.AddRange(new string[] {
                    "-- Seleccione --",
                    "Literatura",
                    "Ciencias",
                    "Tecnología",
                    "Historia",
                    "Arte",
                    "Filosofía",
                    "Psicología",
                    "Economía",
                    "Derecho",
                    "Medicina",
                    "Infantil",
                    "Juvenil"
                });
                cmbAreaTematica.SelectedIndex = 0;
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
            toolTip.SetToolTip(txtNombreCategoria, "Ingrese el nombre de la categoría (máximo 50 caracteres)");
            toolTip.SetToolTip(txtDescripcion, "Descripción de la categoría");
            toolTip.SetToolTip(txtCodigoCategoria, "Formato: AAA000 (3 letras mayúsculas y 3 números)");
            toolTip.SetToolTip(cmbAreaTematica, "Seleccione el área temática");
            toolTip.SetToolTip(txtTipo, "Tipo de categoría");
            toolTip.SetToolTip(txtNivelPrioridad, "Nivel de prioridad de la categoría");
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            ActualizarCodigoCategoria();
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
                    Categoria nuevaCategoria = new Categoria();
                    AsignarDatosCategoria(nuevaCategoria);
                    nuevaCategoria.Id = dataManager.Categorias.Any() ?
                        dataManager.Categorias.Max(c => c.Id) + 1 : 1;

                    dataManager.Categorias.Add(nuevaCategoria);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Categoría guardada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigoCategoria();
                }
                else
                {
                    if (categoriaActual != null)
                    {
                        AsignarDatosCategoria(categoriaActual);
                        categoriaActual.ActualizarFechaModificación();

                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Categoría actualizada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoCategoria();
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
                    "Ingrese el código o nombre de la categoría a buscar:",
                    "Buscar Categoría", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                Categoria categoriaEncontrada = null;

                categoriaEncontrada = dataManager.Categorias.FirstOrDefault(
                    c => c.CodigoCategoria.Equals(busqueda, StringComparison.OrdinalIgnoreCase));

                if (categoriaEncontrada == null)
                {
                    categoriaEncontrada = dataManager.Categorias.FirstOrDefault(
                        c => c.Nombre != null && c.Nombre.ToLower().Contains(busqueda.ToLower()));
                }

                if (categoriaEncontrada != null)
                {
                    CargarCategoriaEnFormulario(categoriaEncontrada);
                    modoEdicion = true;
                    categoriaActual = categoriaEncontrada;
                    MessageBox.Show("Categoría encontrada.", "Búsqueda exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Categoría no encontrada.", "Búsqueda",
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
            if (categoriaActual == null)
            {
                MessageBox.Show("Primero debe buscar una categoría para modificar.",
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
                if (categoriaActual == null)
                {
                    MessageBox.Show("Primero debe buscar una categoría para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var librosEnCategoria = dataManager.Libros.Where(
                    l => l.Categoria == categoriaActual.Nombre && l.Activo).ToList();

                if (librosEnCategoria.Any())
                {
                    MessageBox.Show($"No se puede eliminar la categoría porque tiene {librosEnCategoria.Count} libros asociados.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar la categoría '{categoriaActual.Nombre}'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    categoriaActual.Activo = false;
                    categoriaActual.Estado = "Eliminado";
                    categoriaActual.ActualizarFechaModificación();

                    dataManager.GuardarTodosLosDatos();

                    LimpiarFormulario();
                    modoEdicion = false;
                    categoriaActual = null;

                    MessageBox.Show("Categoría eliminada exitosamente.", "Éxito",
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
            if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoCategoria.Text) ||
                cmbAreaTematica.SelectedIndex <= 0)
            {
                return false;
            }

            string codigo = txtCodigoCategoria.Text.Trim();
            if (!System.Text.RegularExpressions.Regex.IsMatch(codigo, @"^[A-Z]{3}\d{3}$"))
            {
                MessageBox.Show("El código debe tener el formato AAA000 (3 letras mayúsculas y 3 números).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!modoEdicion)
            {
                if (dataManager.Categorias.Any(c => c.CodigoCategoria == codigo && c.Activo))
                {
                    MessageBox.Show("El código de categoría ya existe.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void AsignarDatosCategoria(Categoria categoria)
        {
            categoria.Nombre = txtNombreCategoria.Text.Trim();
            categoria.Descripcion = txtDescripcion.Text.Trim();
            categoria.CodigoCategoria = txtCodigoCategoria.Text.Trim().ToUpper();

            if (cmbAreaTematica.SelectedIndex > 0)
                categoria.UbicacionEstanteria = cmbAreaTematica.SelectedItem.ToString();

            categoria.NivelDemanda = txtNivelPrioridad.Text.Trim();

            if (!string.IsNullOrWhiteSpace(txtTipo.Text))
                categoria.Observaciones = $"Tipo: {txtTipo.Text.Trim()}";

            categoria.Activo = rbActiva.Checked;
            categoria.Estado = rbActiva.Checked ? "Activo" : "Inactivo";
            categoria.ParaAdultos = false;
        }

        private void CargarCategoriaEnFormulario(Categoria categoria)
        {
            txtNombreCategoria.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
            txtCodigoCategoria.Text = categoria.CodigoCategoria;

            for (int i = 0; i < cmbAreaTematica.Items.Count; i++)
            {
                if (cmbAreaTematica.Items[i].ToString() == categoria.UbicacionEstanteria)
                {
                    cmbAreaTematica.SelectedIndex = i;
                    break;
                }
            }

            txtNivelPrioridad.Text = categoria.NivelDemanda;

            if (!string.IsNullOrWhiteSpace(categoria.Observaciones) &&
                categoria.Observaciones.StartsWith("Tipo:"))
            {
                txtTipo.Text = categoria.Observaciones.Replace("Tipo:", "").Trim();
            }

            rbActiva.Checked = categoria.Activo;
            rbInactiva.Checked = !categoria.Activo;

            dtpFechaCreacion.Value = categoria.FechaCreación;
        }

        private void LimpiarFormulario()
        {
            txtNombreCategoria.Clear();
            txtDescripcion.Clear();
            txtCodigoCategoria.Clear();
            cmbAreaTematica.SelectedIndex = 0;
            txtTipo.Clear();
            txtNivelPrioridad.Clear();
            rbActiva.Checked = true;
            dtpFechaCreacion.Value = DateTime.Now;

            modoEdicion = false;
            categoriaActual = null;
        }

        private void ActualizarCodigoCategoria()
        {
            if (!modoEdicion)
            {
                string prefijo = "CAT";
                int numero = dataManager.Categorias.Any() ?
                    dataManager.Categorias.Count() + 1 : 1;
                txtCodigoCategoria.Text = $"{prefijo}{numero:D3}";
            }
        }
    }
}