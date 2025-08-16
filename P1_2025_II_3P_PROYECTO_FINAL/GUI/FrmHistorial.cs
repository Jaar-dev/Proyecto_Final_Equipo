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
    public partial class FrmHistorial : Form
    {
        private DataManager dataManager;
        private List<Historial> historialFiltrado;

        public FrmHistorial()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                dtpFechaInicio.Format = DateTimePickerFormat.Short;
                dtpFechaFin.Format = DateTimePickerFormat.Short;
                dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
                dtpFechaFin.Value = DateTime.Now;

                CargarCombos();
                ConfigurarDataGridView();
                ConfigurarTooltips();
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
            cmbTipoAccion.Items.Clear();
            cmbTipoAccion.Items.Add("Todos");
            cmbTipoAccion.Items.Add("Crear");
            cmbTipoAccion.Items.Add("Actualizar");
            cmbTipoAccion.Items.Add("Eliminar");
            cmbTipoAccion.Items.Add("Renovar");
            cmbTipoAccion.Items.Add("Devolver");
            cmbTipoAccion.Items.Add("Prestar");
            cmbTipoAccion.Items.Add("Vender");
            cmbTipoAccion.SelectedIndex = 0;

            cmbTablaAfectada.Items.Clear();
            cmbTablaAfectada.Items.Add("Todas");
            cmbTablaAfectada.Items.Add("Usuario");
            cmbTablaAfectada.Items.Add("Libro");
            cmbTablaAfectada.Items.Add("Prestamo");
            cmbTablaAfectada.Items.Add("Devolucion");
            cmbTablaAfectada.Items.Add("Bibliotecario");
            cmbTablaAfectada.Items.Add("Autor");
            cmbTablaAfectada.Items.Add("Categoria");
            cmbTablaAfectada.Items.Add("Editorial");
            cmbTablaAfectada.Items.Add("VentaLibros");
            cmbTablaAfectada.Items.Add("Ubicacion");
            cmbTablaAfectada.Items.Add("Pais");
            cmbTablaAfectada.SelectedIndex = 0;

            cmbUsuario.Items.Clear();
            cmbUsuario.Items.Add("Todos");
            foreach (var bibliotecario in dataManager.Bibliotecarios.Where(b => b.Activo))
            {
                cmbUsuario.Items.Add(bibliotecario.Nombre);
            }
            cmbUsuario.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            dgvHistorial.AutoGenerateColumns = false;
            dgvHistorial.Columns.Clear();

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaAccion",
                HeaderText = "Fecha/Hora",
                DataPropertyName = "FechaAccion",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm:ss" }
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TipoAccion",
                HeaderText = "Tipo Acción",
                DataPropertyName = "TipoAccion",
                Width = 100
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TablaAfectada",
                HeaderText = "Tabla",
                DataPropertyName = "TablaAfectada",
                Width = 100
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "RegistroAfectadoId",
                HeaderText = "Registro ID",
                DataPropertyName = "RegistroAfectadoId",
                Width = 80
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Descripcion",
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion",
                Width = 300
            });

            dgvHistorial.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UsuarioId",
                HeaderText = "Usuario ID",
                DataPropertyName = "UsuarioId",
                Width = 80
            });

            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(dtpFechaInicio, "Fecha inicial del período a consultar");
            toolTip.SetToolTip(dtpFechaFin, "Fecha final del período a consultar");
            toolTip.SetToolTip(cmbTipoAccion, "Filtrar por tipo de acción");
            toolTip.SetToolTip(cmbTablaAfectada, "Filtrar por tabla afectada");
            toolTip.SetToolTip(btnFiltrar, "Aplicar filtros seleccionados");
            toolTip.SetToolTip(btnLimpiarFiltros, "Limpiar todos los filtros");
            toolTip.SetToolTip(btnExportar, "Exportar historial a archivo");
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ActualizarEstadisticas();
        }

        private void CargarDatos()
        {
            try
            {
                historialFiltrado = dataManager.HistorialAcciones
                    .OrderByDescending(h => h.FechaAccion)
                    .ToList();

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = historialFiltrado;

                lblTotalRegistros.Text = $"Total Registros: {historialFiltrado.Count}";

                ColorearFilas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorearFilas()
        {
            foreach (DataGridViewRow row in dgvHistorial.Rows)
            {
                var historial = (Historial)row.DataBoundItem;
                if (historial == null) continue;

                switch (historial.TipoAccion?.ToLower())
                {
                    case "crear":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "actualizar":
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        break;
                    case "eliminar":
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                    case "prestar":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "devolver":
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                    case "vender":
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                        break;
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            try
            {
                IEnumerable<Historial> historialTemp = dataManager.HistorialAcciones;

                historialTemp = historialTemp.Where(h =>
                    h.FechaAccion.Date >= dtpFechaInicio.Value.Date &&
                    h.FechaAccion.Date <= dtpFechaFin.Value.Date);

                if (cmbTipoAccion.SelectedIndex > 0)
                {
                    string tipoAccion = cmbTipoAccion.SelectedItem.ToString();
                    historialTemp = historialTemp.Where(h =>
                        h.TipoAccion != null &&
                        h.TipoAccion.Equals(tipoAccion, StringComparison.OrdinalIgnoreCase));
                }

                if (cmbTablaAfectada.SelectedIndex > 0)
                {
                    string tabla = cmbTablaAfectada.SelectedItem.ToString();
                    historialTemp = historialTemp.Where(h =>
                        h.TablaAfectada != null &&
                        h.TablaAfectada.Equals(tabla, StringComparison.OrdinalIgnoreCase));
                }

                if (cmbUsuario.SelectedIndex > 0)
                {
                    string nombreUsuario = cmbUsuario.SelectedItem.ToString();
                    var usuario = dataManager.Bibliotecarios.FirstOrDefault(b => b.Nombre == nombreUsuario);
                    if (usuario != null)
                    {
                        historialTemp = historialTemp.Where(h => h.UsuarioId == usuario.Id);
                    }
                }

                historialFiltrado = historialTemp
                    .OrderByDescending(h => h.FechaAccion)
                    .ToList();

                dgvHistorial.DataSource = null;
                dgvHistorial.DataSource = historialFiltrado;

                lblTotalRegistros.Text = $"Total Registros: {historialFiltrado.Count}";

                ColorearFilas();
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar filtros: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;
            cmbTipoAccion.SelectedIndex = 0;
            cmbTablaAfectada.SelectedIndex = 0;
            cmbUsuario.SelectedIndex = 0;

            CargarDatos();
            ActualizarEstadisticas();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivo CSV (*.csv)|*.csv|Archivo de texto (*.txt)|*.txt";
                saveDialog.Title = "Exportar Historial";
                saveDialog.FileName = $"Historial_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("ID,Fecha,Tipo Acción,Tabla,Registro ID,Descripción,Usuario ID");

                    foreach (var item in historialFiltrado)
                    {
                        sb.AppendLine($"{item.Id},{item.FechaAccion:yyyy-MM-dd HH:mm:ss}," +
                                    $"{item.TipoAccion},{item.TablaAfectada}," +
                                    $"{item.RegistroAfectadoId},\"{item.Descripcion}\"," +
                                    $"{item.UsuarioId}");
                    }

                    System.IO.File.WriteAllText(saveDialog.FileName, sb.ToString());

                    MessageBox.Show("Historial exportado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadisticas()
        {
            try
            {
                if (historialFiltrado == null || historialFiltrado.Count == 0)
                {
                    lblEstadisticas.Text = "Resumen de Acciones:\nNo hay datos para mostrar";
                    lblAccionesHoy.Text = "Acciones Hoy: 0";
                    lblTablaMasActiva.Text = "Tabla más activa: N/A";
                    return;
                }

                var estadisticas = historialFiltrado.GroupBy(h => h.TipoAccion ?? "Sin tipo")
                    .Select(g => new { Tipo = g.Key, Cantidad = g.Count() })
                    .OrderByDescending(x => x.Cantidad);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Resumen de Acciones:");
                foreach (var est in estadisticas)
                {
                    sb.AppendLine($"• {est.Tipo}: {est.Cantidad}");
                }

                lblEstadisticas.Text = sb.ToString();

                var accionesHoy = historialFiltrado.Count(h => h.FechaAccion.Date == DateTime.Today);
                lblAccionesHoy.Text = $"Acciones Hoy: {accionesHoy}";

                var tablaMasModificada = historialFiltrado
                    .Where(h => !string.IsNullOrEmpty(h.TablaAfectada))
                    .GroupBy(h => h.TablaAfectada)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault();

                if (tablaMasModificada != null)
                {
                    lblTablaMasActiva.Text = $"Tabla más activa: {tablaMasModificada.Key} ({tablaMasModificada.Count()} acciones)";
                }
                else
                {
                    lblTablaMasActiva.Text = "Tabla más activa: N/A";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en estadísticas: {ex.Message}");
                lblEstadisticas.Text = "Error al calcular estadísticas";
            }
        }

        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHistorial.Rows.Count)
            {
                var historial = dgvHistorial.Rows[e.RowIndex].DataBoundItem as Historial;
                if (historial != null)
                {
                    MostrarDetallesHistorial(historial);
                }
            }
        }

        private void MostrarDetallesHistorial(Historial historial)
        {
            string detalles = $"ID: {historial.Id}\n" +
                            $"Fecha: {historial.FechaAccion:dd/MM/yyyy HH:mm:ss}\n" +
                            $"Tipo de Actividad: {historial.TipoAccion ?? "N/A"}\n" +
                            $"Formulario Afectado: {historial.TablaAfectada ?? "N/A"}\n" +
                            $"Registro ID: {historial.RegistroAfectadoId}\n" +
                            $"Usuario ID: {historial.UsuarioId}\n" +
                            $"Descripción: {historial.Descripcion ?? "Sin descripción"}\n";

            if (!string.IsNullOrEmpty(historial.ValorAnterior))
                detalles += $"Valor Anterior: {historial.ValorAnterior}\n";

            if (!string.IsNullOrEmpty(historial.ValorNuevo))
                detalles += $"Valor Nuevo: {historial.ValorNuevo}\n";

            MessageBox.Show(detalles, "Detalles del Historial",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AplicarFiltros();
                e.Handled = true;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            ActualizarEstadisticas();
            MessageBox.Show("Datos actualizados.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}