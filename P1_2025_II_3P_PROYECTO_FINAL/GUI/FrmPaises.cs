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
    public partial class FrmPaises : Form
    {
        private DataManager dataManager;
        private Pais paisActual;
        private bool modoEdicion = false;

        public FrmPaises()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                txtCodigoISO.Enabled = false;
                dtpFechaIngreso.Format = DateTimePickerFormat.Short;
                dtpFechaIngreso.Value = DateTime.Now;

                CargarCombos();

                ConfigurarDataGridView();

                ConfigurarTooltips();

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
            cmbNombrePais.Items.Clear();
            cmbNombrePais.Items.Add("Seleccione...");

            cmbNombrePais.Items.Add("Honduras");
            cmbNombrePais.Items.Add("Guatemala");
            cmbNombrePais.Items.Add("El Salvador");
            cmbNombrePais.Items.Add("Nicaragua");
            cmbNombrePais.Items.Add("Costa Rica");
            cmbNombrePais.Items.Add("Panamá");
            cmbNombrePais.Items.Add("Belice");
            cmbNombrePais.Items.Add("México");
            cmbNombrePais.Items.Add("Estados Unidos");
            cmbNombrePais.Items.Add("Colombia");
            cmbNombrePais.Items.Add("España");
            cmbNombrePais.Items.Add("Argentina");
            cmbNombrePais.Items.Add("Chile");
            cmbNombrePais.Items.Add("Brasil");
            cmbNombrePais.Items.Add("Perú");
            cmbNombrePais.Items.Add("Ecuador");
            cmbNombrePais.Items.Add("Venezuela");
            cmbNombrePais.Items.Add("Uruguay");
            cmbNombrePais.Items.Add("Paraguay");
            cmbNombrePais.Items.Add("Bolivia");

            cmbNombrePais.SelectedIndex = 0;

            cmbContinente.Items.Clear();
            cmbContinente.Items.Add("Seleccione...");
            cmbContinente.Items.Add("América del Norte");
            cmbContinente.Items.Add("América Central");
            cmbContinente.Items.Add("América del Sur");
            cmbContinente.Items.Add("Europa");
            cmbContinente.Items.Add("Asia");
            cmbContinente.Items.Add("África");
            cmbContinente.Items.Add("Oceanía");
            cmbContinente.SelectedIndex = 0;

            cmbIdiomaPrincipal.Items.Clear();
            cmbIdiomaPrincipal.Items.Add("Seleccione...");
            cmbIdiomaPrincipal.Items.Add("Español");
            cmbIdiomaPrincipal.Items.Add("Inglés");
            cmbIdiomaPrincipal.Items.Add("Portugués");
            cmbIdiomaPrincipal.Items.Add("Francés");
            cmbIdiomaPrincipal.Items.Add("Alemán");
            cmbIdiomaPrincipal.Items.Add("Italiano");
            cmbIdiomaPrincipal.Items.Add("Chino Mandarín");
            cmbIdiomaPrincipal.Items.Add("Japonés");
            cmbIdiomaPrincipal.Items.Add("Árabe");
            cmbIdiomaPrincipal.Items.Add("Ruso");
            cmbIdiomaPrincipal.Items.Add("Hindi");
            cmbIdiomaPrincipal.SelectedIndex = 0;

            cmbMoneda.Items.Clear();
            cmbMoneda.Items.Add("Seleccione...");
            cmbMoneda.Items.Add("Lempira (HNL)");
            cmbMoneda.Items.Add("Dólar (USD)");
            cmbMoneda.Items.Add("Euro (EUR)");
            cmbMoneda.Items.Add("Peso Mexicano (MXN)");
            cmbMoneda.Items.Add("Quetzal (GTQ)");
            cmbMoneda.Items.Add("Colón Costarricense (CRC)");
            cmbMoneda.Items.Add("Córdoba (NIO)");
            cmbMoneda.Items.Add("Balboa (PAB)");
            cmbMoneda.Items.Add("Peso Colombiano (COP)");
            cmbMoneda.Items.Add("Sol (PEN)");
            cmbMoneda.Items.Add("Peso Argentino (ARS)");
            cmbMoneda.Items.Add("Peso Chileno (CLP)");
            cmbMoneda.Items.Add("Real (BRL)");
            cmbMoneda.Items.Add("Bolívar (VES)");
            cmbMoneda.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            dgvPaises.AutoGenerateColumns = false;
            dgvPaises.Columns.Clear();

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Codigo",
                Width = 80
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "País",
                DataPropertyName = "Nombre",
                Width = 150
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Continente",
                HeaderText = "Continente",
                DataPropertyName = "Continente",
                Width = 120
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Capital",
                HeaderText = "Capital",
                DataPropertyName = "Capital",
                Width = 120
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdiomaPrincipal",
                HeaderText = "Idioma",
                DataPropertyName = "IdiomaPrincipal",
                Width = 100
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Poblacion",
                HeaderText = "Población",
                DataPropertyName = "Poblacion",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            dgvPaises.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Moneda",
                HeaderText = "Moneda",
                DataPropertyName = "Moneda",
                Width = 100
            });

            dgvPaises.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaises.MultiSelect = false;
            dgvPaises.ReadOnly = true;
            dgvPaises.AllowUserToAddRows = false;
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cmbNombrePais, "Seleccione el nombre del país");
            toolTip.SetToolTip(txtCodigoISO, "Ingrese el código ISO del país (ej: HN, US, ES)");
            toolTip.SetToolTip(cmbContinente, "Seleccione el continente");
            toolTip.SetToolTip(cmbIdiomaPrincipal, "Seleccione el idioma principal");
            toolTip.SetToolTip(txtCapital, "Ingrese el nombre de la capital");
            toolTip.SetToolTip(numPoblacion, "Ingrese la población aproximada");
            toolTip.SetToolTip(numPIB, "Ingrese el PIB en millones de dólares");
            toolTip.SetToolTip(cmbMoneda, "Seleccione la moneda oficial");
            toolTip.SetToolTip(btnGuardar, "Guardar información del país");
            toolTip.SetToolTip(btnBuscar, "Buscar país");
        }

        private void FrmPaises_Load(object sender, EventArgs e)
        {
            ActualizarCodigoPais();
            CargarDatos();
            ActualizarEstadisticas();
        }

        private void CargarDatos()
        {
            try
            {
                var paises = dataManager.Paises
                    .Where(p => p.Activo)
                    .OrderBy(p => p.Nombre)
                    .ToList();

                dgvPaises.DataSource = null;
                dgvPaises.DataSource = paises;

                lblTotalRegistros.Text = $"Total Países registrados: {paises.Count}";
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
                    if (dataManager.Paises.Any(p => p.Nombre == cmbNombrePais.Text && p.Activo))
                    {
                        MessageBox.Show("Este país ya está registrado.", "Duplicado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Pais nuevoPais = new Pais();
                    AsignarDatosPais(nuevoPais);
                    nuevoPais.Id = dataManager.Paises.Any() ?
                        dataManager.Paises.Max(p => p.Id) + 1 : 1;

                    dataManager.Paises.Add(nuevoPais);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("País guardado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AsignarDatosPais(paisActual);
                    paisActual.ActualizarFechaModificación();

                    var index = dataManager.Paises.FindIndex(p => p.Id == paisActual.Id);
                    if (index >= 0)
                    {
                        dataManager.Paises[index] = paisActual;
                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("País actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LimpiarFormulario();
                CargarDatos();
                ActualizarEstadisticas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPaises.SelectedRows.Count > 0)
            {
                paisActual = (Pais)dgvPaises.SelectedRows[0].DataBoundItem;
                CargarPaisEnFormulario(paisActual);
                modoEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("Seleccione un país para modificar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaises.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("¿Está seguro de eliminar este país?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var pais = (Pais)dgvPaises.SelectedRows[0].DataBoundItem;

                    var autoresDelPais = dataManager.Autores.Where(a =>
                        a.Nacionalidad == pais.Nombre && a.Activo).ToList();

                    if (autoresDelPais.Any())
                    {
                        MessageBox.Show($"No se puede eliminar el país porque tiene {autoresDelPais.Count} autor(es) asociado(s).",
                            "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    pais.Activo = false;
                    pais.Estado = "Inactivo";
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("País eliminado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                    ActualizarEstadisticas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un país para eliminar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese nombre del país, código o continente:", "Buscar País", "");

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                var paisesEncontrados = dataManager.Paises.Where(p =>
                    p.Activo &&
                    (p.Nombre.ToLower().Contains(busqueda.ToLower()) ||
                     p.Codigo.ToLower().Contains(busqueda.ToLower()) ||
                     p.Continente.ToLower().Contains(busqueda.ToLower()) ||
                     p.Capital.ToLower().Contains(busqueda.ToLower()))).ToList();

                if (paisesEncontrados.Any())
                {
                    dgvPaises.DataSource = null;
                    dgvPaises.DataSource = paisesEncontrados;
                }
                else
                {
                    MessageBox.Show("No se encontraron países con ese criterio.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarFormulario()
        {
            if (cmbNombrePais.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un país.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNombrePais.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoISO.Text))
            {
                MessageBox.Show("Ingrese el código ISO del país.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoISO.Focus();
                return false;
            }

            if (txtCodigoISO.Text.Length != 2)
            {
                MessageBox.Show("El código ISO debe tener exactamente 2 caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoISO.Focus();
                return false;
            }

            if (cmbContinente.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un continente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbContinente.Focus();
                return false;
            }

            if (cmbIdiomaPrincipal.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un idioma principal.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIdiomaPrincipal.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCapital.Text))
            {
                MessageBox.Show("Ingrese el nombre de la capital.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapital.Focus();
                return false;
            }

            if (cmbMoneda.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione una moneda.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMoneda.Focus();
                return false;
            }

            return true;
        }

        private void AsignarDatosPais(Pais pais)
        {
            pais.Nombre = cmbNombrePais.Text;
            pais.Codigo = txtCodigoISO.Text.Trim().ToUpper();
            pais.Continente = cmbContinente.SelectedItem.ToString();
            pais.IdiomaPrincipal = cmbIdiomaPrincipal.SelectedItem.ToString();
            pais.Capital = txtCapital.Text.Trim();
            pais.Poblacion = (long)numPoblacion.Value;
            pais.PIB = numPIB.Value;
            pais.Moneda = cmbMoneda.SelectedItem.ToString();
            pais.ModificadoPor = "Sistema";
        }

        private void CargarPaisEnFormulario(Pais pais)
        {
            txtCodigoISO.Text = pais.Id.ToString();

            for (int i = 0; i < cmbNombrePais.Items.Count; i++)
            {
                if (cmbNombrePais.Items[i].ToString() == pais.Nombre)
                {
                    cmbNombrePais.SelectedIndex = i;
                    break;
                }
            }

            txtCodigoISO.Text = pais.Codigo;

            for (int i = 0; i < cmbContinente.Items.Count; i++)
            {
                if (cmbContinente.Items[i].ToString() == pais.Continente)
                {
                    cmbContinente.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbIdiomaPrincipal.Items.Count; i++)
            {
                if (cmbIdiomaPrincipal.Items[i].ToString() == pais.IdiomaPrincipal)
                {
                    cmbIdiomaPrincipal.SelectedIndex = i;
                    break;
                }
            }

            txtCapital.Text = pais.Capital;
            numPoblacion.Value = pais.Poblacion;
            numPIB.Value = pais.PIB;

            for (int i = 0; i < cmbMoneda.Items.Count; i++)
            {
                if (cmbMoneda.Items[i].ToString() == pais.Moneda)
                {
                    cmbMoneda.SelectedIndex = i;
                    break;
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigoISO.Clear();
            cmbNombrePais.SelectedIndex = 0;
            txtCodigoISO.Clear();
            cmbContinente.SelectedIndex = 0;
            cmbIdiomaPrincipal.SelectedIndex = 0;
            txtCapital.Clear();
            numPoblacion.Value = 0;
            numPIB.Value = 0;
            cmbMoneda.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;

            modoEdicion = false;
            paisActual = null;
            btnGuardar.Text = "Guardar";

            ActualizarCodigoPais();
        }

        private void ActualizarCodigoPais()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Paises.Any() ?
                    dataManager.Paises.Max(p => p.Id) + 1 : 1;
                txtCodigoISO.Text = proximoId.ToString();
            }
        }

        private void cmbNombrePais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombrePais.SelectedIndex > 0 && !modoEdicion)
            {
                switch (cmbNombrePais.Text)
                {
                    case "Honduras":
                        txtCodigoISO.Text = "HN";
                        cmbContinente.Text = "América Central";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Tegucigalpa";
                        cmbMoneda.Text = "Lempira (HNL)";
                        numPoblacion.Value = 10000000;
                        break;
                    case "Guatemala":
                        txtCodigoISO.Text = "GT";
                        cmbContinente.Text = "América Central";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Ciudad de Guatemala";
                        cmbMoneda.Text = "Quetzal (GTQ)";
                        numPoblacion.Value = 18000000;
                        break;
                    case "El Salvador":
                        txtCodigoISO.Text = "SV";
                        cmbContinente.Text = "América Central";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "San Salvador";
                        cmbMoneda.Text = "Dólar (USD)";
                        numPoblacion.Value = 6500000;
                        break;
                    case "Nicaragua":
                        txtCodigoISO.Text = "NI";
                        cmbContinente.Text = "América Central";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Managua";
                        cmbMoneda.Text = "Córdoba (NIO)";
                        numPoblacion.Value = 6700000;
                        break;
                    case "Costa Rica":
                        txtCodigoISO.Text = "CR";
                        cmbContinente.Text = "América Central";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "San José";
                        cmbMoneda.Text = "Colón Costarricense (CRC)";
                        numPoblacion.Value = 5200000;
                        break;
                    case "Panamá":
                        txtCodigoISO.Text = "PA";
                        cmbContinente.Text = "América Central";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Ciudad de Panamá";
                        cmbMoneda.Text = "Balboa (PAB)";
                        numPoblacion.Value = 4400000;
                        break;
                    case "México":
                        txtCodigoISO.Text = "MX";
                        cmbContinente.Text = "América del Norte";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Ciudad de México";
                        cmbMoneda.Text = "Peso Mexicano (MXN)";
                        numPoblacion.Value = 130000000;
                        break;
                    case "Estados Unidos":
                        txtCodigoISO.Text = "US";
                        cmbContinente.Text = "América del Norte";
                        cmbIdiomaPrincipal.Text = "Inglés";
                        txtCapital.Text = "Washington D.C.";
                        cmbMoneda.Text = "Dólar (USD)";
                        numPoblacion.Value = 335000000;
                        break;
                    case "España":
                        txtCodigoISO.Text = "ES";
                        cmbContinente.Text = "Europa";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Madrid";
                        cmbMoneda.Text = "Euro (EUR)";
                        numPoblacion.Value = 47000000;
                        break;
                    case "Argentina":
                        txtCodigoISO.Text = "AR";
                        cmbContinente.Text = "América del Sur";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Buenos Aires";
                        cmbMoneda.Text = "Peso Argentino (ARS)";
                        numPoblacion.Value = 46000000;
                        break;
                    case "Colombia":
                        txtCodigoISO.Text = "CO";
                        cmbContinente.Text = "América del Sur";
                        cmbIdiomaPrincipal.Text = "Español";
                        txtCapital.Text = "Bogotá";
                        cmbMoneda.Text = "Peso Colombiano (COP)";
                        numPoblacion.Value = 52000000;
                        break;
                    case "Brasil":
                        txtCodigoISO.Text = "BR";
                        cmbContinente.Text = "América del Sur";
                        cmbIdiomaPrincipal.Text = "Portugués";
                        txtCapital.Text = "Brasilia";
                        cmbMoneda.Text = "Real (BRL)";
                        numPoblacion.Value = 216000000;
                        break;
                }
            }
        }

        private void ActualizarEstadisticas()
        {
            try
            {
                var paises = dataManager.Paises.Where(p => p.Activo).ToList();

                var paisesPorContinente = paises
                    .GroupBy(p => p.Continente)
                    .Select(g => new { Continente = g.Key, Cantidad = g.Count() })
                    .OrderByDescending(x => x.Cantidad);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Países por Continente:");
                foreach (var item in paisesPorContinente)
                {
                    sb.AppendLine($"• {item.Continente}: {item.Cantidad}");
                }

                lblEstadisticas.Text = sb.ToString();

                var paisesPorIdioma = paises
                    .GroupBy(p => p.IdiomaPrincipal)
                    .OrderByDescending(g => g.Count())
                    .FirstOrDefault();

                if (paisesPorIdioma != null)
                {
                    lblIdiomaMasComun.Text = $"Idioma más común: {paisesPorIdioma.Key} ({paisesPorIdioma.Count()} países)";
                }

                long poblacionTotal = paises.Sum(p => p.Poblacion);
                lblPoblacionTotal.Text = $"Población Total: {poblacionTotal:N0}";

                var paisMayorPoblacion = paises.OrderByDescending(p => p.Poblacion).FirstOrDefault();
                if (paisMayorPoblacion != null)
                {
                    lblPaisMayorPoblacion.Text = $"Mayor Población: {paisMayorPoblacion.Nombre} ({paisMayorPoblacion.Poblacion:N0})";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en estadísticas: {ex.Message}");
            }
        }

        private void dgvPaises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                paisActual = (Pais)dgvPaises.Rows[e.RowIndex].DataBoundItem;
                CargarPaisEnFormulario(paisActual);
                modoEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivo CSV (*.csv)|*.csv|Archivo de texto (*.txt)|*.txt";
                saveDialog.Title = "Exportar Países";
                saveDialog.FileName = $"Paises_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine("ID,Código,País,Continente,Capital,Idioma,Población,PIB,Moneda");

                    foreach (var pais in dataManager.Paises.Where(p => p.Activo))
                    {
                        sb.AppendLine($"{pais.Id},{pais.Codigo},{pais.Nombre}," +
                                    $"{pais.Continente},{pais.Capital},{pais.IdiomaPrincipal}," +
                                    $"{pais.Poblacion},{pais.PIB},{pais.Moneda}");
                    }

                    System.IO.File.WriteAllText(saveDialog.FileName, sb.ToString());

                    MessageBox.Show("Países exportados exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}