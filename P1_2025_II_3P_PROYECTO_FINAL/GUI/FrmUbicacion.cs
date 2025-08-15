using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmUbicacion : Form
    {
        private DataManager dataManager;
        private Ubicacion ubicacionActual;
        private bool modoEdicion = false;

        public FrmUbicacion()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                txtIDUbicacion.Enabled = false;

                CargarCombos();

                ConfigurarTooltips();

                ConfigurarDataGridView();

                LimpiarFormulario();

                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar formulario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            cmbSeccion.Items.Clear();
            cmbSeccion.Items.Add("Seleccione...");
            cmbSeccion.Items.Add("Literatura");
            cmbSeccion.Items.Add("Ciencias");
            cmbSeccion.Items.Add("Historia");
            cmbSeccion.Items.Add("Arte");
            cmbSeccion.Items.Add("Tecnología");
            cmbSeccion.Items.Add("Referencia");
            cmbSeccion.Items.Add("Infantil");
            cmbSeccion.Items.Add("Revistas");
            cmbSeccion.SelectedIndex = 0;

            cmbPiso.Items.Clear();
            cmbPiso.Items.Add("Seleccione...");
            cmbPiso.Items.Add("Planta Baja");
            cmbPiso.Items.Add("Primer Piso");
            cmbPiso.Items.Add("Segundo Piso");
            cmbPiso.Items.Add("Tercer Piso");
            cmbPiso.SelectedIndex = 0;

            cmbTipoMaterial.Items.Clear();
            cmbTipoMaterial.Items.Add("Seleccione...");
            cmbTipoMaterial.Items.Add("Libros");
            cmbTipoMaterial.Items.Add("Revistas");
            cmbTipoMaterial.Items.Add("DVDs");
            cmbTipoMaterial.Items.Add("CDs");
            cmbTipoMaterial.Items.Add("Audiobooks");
            cmbTipoMaterial.Items.Add("Material Digital");
            cmbTipoMaterial.Items.Add("Mapas");
            cmbTipoMaterial.Items.Add("Documentos");
            cmbTipoMaterial.SelectedIndex = 0;
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtEstanteria, "Ingrese el código de la estantería (ej: A1, B2, C3)");
            toolTip.SetToolTip(numPasillo, "Número del pasillo donde se encuentra la estantería");
            toolTip.SetToolTip(cmbSeccion, "Seleccione la sección de la biblioteca");
            toolTip.SetToolTip(cmbPiso, "Seleccione el piso donde se encuentra");
            toolTip.SetToolTip(numCapacidadTotal, "Capacidad máxima de libros");
            toolTip.SetToolTip(numEspaciosOcupados, "Espacios actualmente ocupados");
            toolTip.SetToolTip(btnGuardar, "Guardar ubicación");
            toolTip.SetToolTip(btnBuscar, "Buscar ubicación existente");
        }

        private void ConfigurarDataGridView()
        {
            dgvUbicaciones.AutoGenerateColumns = false;
            dgvUbicaciones.Columns.Clear();

            dgvUbicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvUbicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estanteria",
                HeaderText = "Estantería",
                DataPropertyName = "Estanteria",
                Width = 100
            });

            dgvUbicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Pasillo",
                HeaderText = "Pasillo",
                DataPropertyName = "Pasillo",
                Width = 80
            });

            dgvUbicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Seccion",
                HeaderText = "Sección",
                DataPropertyName = "Seccion",
                Width = 120
            });

            dgvUbicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Piso",
                HeaderText = "Piso",
                DataPropertyName = "Piso",
                Width = 100
            });

            dgvUbicaciones.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Ocupacion",
                HeaderText = "Ocupación",
                Width = 100
            });

            dgvUbicaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUbicaciones.MultiSelect = false;
            dgvUbicaciones.ReadOnly = true;
        }

        private void FrmUbicacion_Load(object sender, EventArgs e)
        {
            ActualizarCodigoUbicacion();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dgvUbicaciones.DataSource = null;
                var ubicaciones = dataManager.Ubicaciones.Where(u => u.Activo).ToList();
                dgvUbicaciones.DataSource = ubicaciones;

                foreach (DataGridViewRow row in dgvUbicaciones.Rows)
                {
                    var ubicacion = (Ubicacion)row.DataBoundItem;
                    row.Cells["Ocupacion"].Value = $"{ubicacion.EspaciosOcupados}/{ubicacion.CapacidadTotal}";
                }

                lblTotalRegistros.Text = $"Total Ubicaciones: {ubicaciones.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    Ubicacion nuevaUbicacion = new Ubicacion();
                    AsignarDatosUbicacion(nuevaUbicacion);
                    nuevaUbicacion.Id = dataManager.Ubicaciones.Any() ?
                        dataManager.Ubicaciones.Max(u => u.Id) + 1 : 1;

                    dataManager.Ubicaciones.Add(nuevaUbicacion);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Ubicación guardada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AsignarDatosUbicacion(ubicacionActual);
                    ubicacionActual.ActualizarFechaModificación();

                    var index = dataManager.Ubicaciones.FindIndex(u => u.Id == ubicacionActual.Id);
                    if (index >= 0)
                    {
                        dataManager.Ubicaciones[index] = ubicacionActual;
                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Ubicación actualizada exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LimpiarFormulario();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUbicaciones.SelectedRows.Count > 0)
            {
                ubicacionActual = (Ubicacion)dgvUbicaciones.SelectedRows[0].DataBoundItem;
                CargarUbicacionEnFormulario(ubicacionActual);
                modoEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("Seleccione una ubicación para modificar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUbicaciones.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("¿Está seguro de eliminar esta ubicación?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var ubicacion = (Ubicacion)dgvUbicaciones.SelectedRows[0].DataBoundItem;

                    var librosEnUbicacion = dataManager.Libros.Where(l =>
                        l.Ubicacion == $"{ubicacion.Estanteria}-{ubicacion.Pasillo}-{ubicacion.Seccion}").ToList();

                    if (librosEnUbicacion.Any())
                    {
                        MessageBox.Show($"No se puede eliminar la ubicación porque tiene {librosEnUbicacion.Count} libro(s) asignado(s).",
                            "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ubicacion.Activo = false;
                    ubicacion.Estado = "Inactivo";
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Ubicación eliminada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ubicación para eliminar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese estantería, sección o piso a buscar:", "Buscar Ubicación", "");

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                var ubicacionesEncontradas = dataManager.Ubicaciones.Where(u =>
                    u.Activo &&
                    (u.Estanteria.ToLower().Contains(busqueda.ToLower()) ||
                     u.Seccion.ToLower().Contains(busqueda.ToLower()) ||
                     u.Piso.ToLower().Contains(busqueda.ToLower()) ||
                     u.DescripcionUbicacion.ToLower().Contains(busqueda.ToLower()))).ToList();

                if (ubicacionesEncontradas.Any())
                {
                    dgvUbicaciones.DataSource = null;
                    dgvUbicaciones.DataSource = ubicacionesEncontradas;

                    foreach (DataGridViewRow row in dgvUbicaciones.Rows)
                    {
                        var ubicacion = (Ubicacion)row.DataBoundItem;
                        row.Cells["Ocupacion"].Value = $"{ubicacion.EspaciosOcupados}/{ubicacion.CapacidadTotal}";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron ubicaciones con ese criterio.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarDatos();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtEstanteria.Text))
            {
                MessageBox.Show("Ingrese el código de estantería.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstanteria.Focus();
                return false;
            }

            if (cmbSeccion.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione una sección.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSeccion.Focus();
                return false;
            }

            if (cmbPiso.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un piso.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPiso.Focus();
                return false;
            }

            if (numEspaciosOcupados.Value > numCapacidadTotal.Value)
            {
                MessageBox.Show("Los espacios ocupados no pueden ser mayores que la capacidad total.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numEspaciosOcupados.Focus();
                return false;
            }

            return true;
        }

        private void AsignarDatosUbicacion(Ubicacion ubicacion)
        {
            ubicacion.Estanteria = txtEstanteria.Text.Trim().ToUpper();
            ubicacion.Pasillo = (int)numPasillo.Value;
            ubicacion.Seccion = cmbSeccion.SelectedItem.ToString();
            ubicacion.Piso = cmbPiso.SelectedItem.ToString();
            ubicacion.CapacidadTotal = (int)numCapacidadTotal.Value;
            ubicacion.EspaciosOcupados = (int)numEspaciosOcupados.Value;
            ubicacion.TipoMaterial = cmbTipoMaterial.SelectedIndex > 0 ?
                cmbTipoMaterial.SelectedItem.ToString() : "Libros";
            ubicacion.ModificadoPor = "Sistema";
        }

        private void CargarUbicacionEnFormulario(Ubicacion ubicacion)
        {
            txtIDUbicacion.Text = ubicacion.Id.ToString();
            txtEstanteria.Text = ubicacion.Estanteria;
            numPasillo.Value = ubicacion.Pasillo;

            for (int i = 0; i < cmbSeccion.Items.Count; i++)
            {
                if (cmbSeccion.Items[i].ToString() == ubicacion.Seccion)
                {
                    cmbSeccion.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbPiso.Items.Count; i++)
            {
                if (cmbPiso.Items[i].ToString() == ubicacion.Piso)
                {
                    cmbPiso.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbTipoMaterial.Items.Count; i++)
            {
                if (cmbTipoMaterial.Items[i].ToString() == ubicacion.TipoMaterial)
                {
                    cmbTipoMaterial.SelectedIndex = i;
                    break;
                }
            }

            numCapacidadTotal.Value = ubicacion.CapacidadTotal;
            numEspaciosOcupados.Value = ubicacion.EspaciosOcupados;

            ActualizarDisponibilidad();
        }

        private void LimpiarFormulario()
        {
            txtIDUbicacion.Clear();
            txtEstanteria.Clear();
            numPasillo.Value = 1;
            cmbSeccion.SelectedIndex = 0;
            cmbPiso.SelectedIndex = 0;
            cmbTipoMaterial.SelectedIndex = 0;
            numCapacidadTotal.Value = 100;
            numEspaciosOcupados.Value = 0;
            modoEdicion = false;
            ubicacionActual = null;
            btnGuardar.Text = "Guardar";

            ActualizarCodigoUbicacion();
            ActualizarDisponibilidad();
        }

        private void ActualizarCodigoUbicacion()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Ubicaciones.Any() ?
                    dataManager.Ubicaciones.Max(u => u.Id) + 1 : 1;
                txtIDUbicacion.Text = proximoId.ToString();
            }
        }

        private void ActualizarDisponibilidad()
        {
            int disponibles = (int)(numCapacidadTotal.Value - numEspaciosOcupados.Value);
            lblEspaciosDisponibles.Text = $"Espacios Disponibles: {disponibles}";

            if (disponibles < 10)
            {
                lblEspaciosDisponibles.ForeColor = Color.Red;
            }
            else if (disponibles < 30)
            {
                lblEspaciosDisponibles.ForeColor = Color.Orange;
            }
            else
            {
                lblEspaciosDisponibles.ForeColor = Color.Green;
            }
        }

        private void numCapacidadTotal_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDisponibilidad();
        }

        private void numEspaciosOcupados_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDisponibilidad();
        }

        private void dgvUbicaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ubicacionActual = (Ubicacion)dgvUbicaciones.Rows[e.RowIndex].DataBoundItem;
                CargarUbicacionEnFormulario(ubicacionActual);
                modoEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
        }
    }
}