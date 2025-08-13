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
    public partial class FrmVentasLibros : Form
    {
        private DataManager dataManager;
        private VentaLibros ventaActual;
        private Libro libroSeleccionado;
        private bool modoEdicion = false;

        public FrmVentasLibros()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            try
            {
                // Configurar controles
                txtIdVenta.Enabled = false;
                dtpFechaVenta.Format = DateTimePickerFormat.Short;
                dtpFechaVenta.Value = DateTime.Now;

                // Cargar combos
                CargarCombos();

                // Configurar DataGridView
                ConfigurarDataGridView();

                // Configurar tooltips
                ConfigurarTooltips();

                // Limpiar formulario
                LimpiarFormulario();

                // Cargar datos
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
            // Cargar libros disponibles
            cmbLibro.Items.Clear();
            cmbLibro.Items.Add("Seleccione un libro...");
            foreach (var libro in dataManager.Libros.Where(l => l.Activo && l.CantidadDisponible > 0))
            {
                cmbLibro.Items.Add($"{libro.ISBN} - {libro.Titulo}");
            }
            cmbLibro.SelectedIndex = 0;

            // Cargar métodos de pago
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Seleccione...");
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta de Crédito");
            cmbMetodoPago.Items.Add("Tarjeta de Débito");
            cmbMetodoPago.Items.Add("Transferencia Bancaria");
            cmbMetodoPago.Items.Add("Cheque");
            cmbMetodoPago.Items.Add("PayPal");
            cmbMetodoPago.SelectedIndex = 0;

            // Cargar estados de venta
            cmbEstadoVenta.Items.Clear();
            cmbEstadoVenta.Items.Add("Completada");
            cmbEstadoVenta.Items.Add("Pendiente");
            cmbEstadoVenta.Items.Add("Cancelada");
            cmbEstadoVenta.Items.Add("Reembolsada");
            cmbEstadoVenta.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.Columns.Clear();

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaVenta",
                HeaderText = "Fecha",
                DataPropertyName = "FechaVenta",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cliente",
                HeaderText = "Cliente",
                DataPropertyName = "Cliente",
                Width = 150
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LibroId",
                HeaderText = "Libro ID",
                DataPropertyName = "LibroId",
                Width = 70
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Width = 80
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PrecioUnitario",
                HeaderText = "Precio Unit.",
                DataPropertyName = "PrecioUnitario",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total",
                DataPropertyName = "Total",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MetodoPago",
                HeaderText = "Método Pago",
                DataPropertyName = "MetodoPago",
                Width = 120
            });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EstadoVenta",
                HeaderText = "Estado",
                DataPropertyName = "EstadoVenta",
                Width = 100
            });

            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.AllowUserToAddRows = false;
        }

        private void ConfigurarTooltips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cmbLibro, "Seleccione el libro a vender");
            toolTip.SetToolTip(txtCliente, "Nombre del cliente");
            toolTip.SetToolTip(numCantidad, "Cantidad de libros a vender");
            toolTip.SetToolTip(numPrecioUnitario, "Precio por unidad");
            toolTip.SetToolTip(txtTotal, "Total de la venta");
            toolTip.SetToolTip(cmbMetodoPago, "Método de pago utilizado");
            toolTip.SetToolTip(btnGuardar, "Registrar venta");
            toolTip.SetToolTip(btnBuscar, "Buscar venta");
            toolTip.SetToolTip(btnGenerarFactura, "Generar factura de venta");
        }

        private void FrmVentasLibros_Load(object sender, EventArgs e)
        {
            ActualizarCodigoVenta();
            CargarDatos();
            ActualizarEstadisticas();
        }

        private void CargarDatos()
        {
            try
            {
                var ventas = dataManager.Ventas
                    .Where(v => v.Activo)
                    .OrderByDescending(v => v.FechaVenta)
                    .ToList();

                dgvVentas.DataSource = null;
                dgvVentas.DataSource = ventas;

                lblTotalRegistros.Text = $"Total Ventas: {ventas.Count}";

                // Colorear filas según estado
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
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                var venta = (VentaLibros)row.DataBoundItem;

                switch (venta.EstadoVenta.ToLower())
                {
                    case "completada":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "pendiente":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "cancelada":
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                    case "reembolsada":
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                }
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
                    // Verificar disponibilidad
                    if (libroSeleccionado.CantidadDisponible < numCantidad.Value)
                    {
                        MessageBox.Show($"No hay suficientes libros disponibles. Disponibles: {libroSeleccionado.CantidadDisponible}",
                            "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Crear nueva venta
                    VentaLibros nuevaVenta = new VentaLibros();
                    AsignarDatosVenta(nuevaVenta);
                    nuevaVenta.Id = dataManager.Ventas.Any() ?
                        dataManager.Ventas.Max(v => v.Id) + 1 : 1;

                    // Actualizar stock del libro
                    libroSeleccionado.CantidadDisponible -= (int)numCantidad.Value;

                    dataManager.Ventas.Add(nuevaVenta);
                    dataManager.GuardarTodosLosDatos();

                    // Registrar en historial
                    var historial = new Historial
                    {
                        Id = dataManager.HistorialAcciones.Any() ?
                            dataManager.HistorialAcciones.Max(h => h.Id) + 1 : 1,
                        TipoAccion = "Vender",
                        TablaAfectada = "VentaLibros",
                        RegistroAfectadoId = nuevaVenta.Id,
                        Descripcion = $"Venta de {numCantidad.Value} libro(s) a {txtCliente.Text}",
                        FechaAccion = DateTime.Now,
                        UsuarioId = 0
                    };
                    dataManager.HistorialAcciones.Add(historial);
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Venta registrada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Actualizar venta existente
                    AsignarDatosVenta(ventaActual);
                    ventaActual.ActualizarFechaModificación();

                    var index = dataManager.Ventas.FindIndex(v => v.Id == ventaActual.Id);
                    if (index >= 0)
                    {
                        dataManager.Ventas[index] = ventaActual;
                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Venta actualizada exitosamente.", "Éxito",
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
            if (dgvVentas.SelectedRows.Count > 0)
            {
                ventaActual = (VentaLibros)dgvVentas.SelectedRows[0].DataBoundItem;
                CargarVentaEnFormulario(ventaActual);
                modoEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("Seleccione una venta para modificar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("¿Está seguro de eliminar esta venta?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    var venta = (VentaLibros)dgvVentas.SelectedRows[0].DataBoundItem;

                    // Devolver stock al libro
                    var libro = dataManager.Libros.FirstOrDefault(l => l.Id == venta.LibroId);
                    if (libro != null)
                    {
                        libro.CantidadDisponible += venta.Cantidad;
                    }

                    venta.Activo = false;
                    venta.Estado = "Inactivo";
                    venta.EstadoVenta = "Cancelada";
                    dataManager.GuardarTodosLosDatos();

                    MessageBox.Show("Venta eliminada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatos();
                    ActualizarEstadisticas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta para eliminar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese nombre del cliente o ID de venta:", "Buscar Venta", "");

            if (!string.IsNullOrWhiteSpace(busqueda))
            {
                var ventasEncontradas = dataManager.Ventas.Where(v =>
                    v.Activo &&
                    (v.Cliente.ToLower().Contains(busqueda.ToLower()) ||
                     v.Id.ToString() == busqueda)).ToList();

                if (ventasEncontradas.Any())
                {
                    dgvVentas.DataSource = null;
                    dgvVentas.DataSource = ventasEncontradas;
                    ColorearFilas();
                }
                else
                {
                    MessageBox.Show("No se encontraron ventas con ese criterio.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                var venta = (VentaLibros)dgvVentas.SelectedRows[0].DataBoundItem;
                var libro = dataManager.Libros.FirstOrDefault(l => l.Id == venta.LibroId);

                StringBuilder factura = new StringBuilder();
                factura.AppendLine("=======================================");
                factura.AppendLine("         FACTURA DE VENTA");
                factura.AppendLine("     BIBLIOTECA UNIVERSITARIA UJCV");
                factura.AppendLine("=======================================");
                factura.AppendLine($"Factura No.: {venta.Id:D6}");
                factura.AppendLine($"Fecha: {venta.FechaVenta:dd/MM/yyyy}");
                factura.AppendLine($"Cliente: {venta.Cliente}");
                factura.AppendLine("---------------------------------------");
                factura.AppendLine("DETALLE DE LA COMPRA:");
                factura.AppendLine($"Libro: {libro?.Titulo ?? "N/A"}");
                factura.AppendLine($"ISBN: {libro?.ISBN ?? "N/A"}");
                factura.AppendLine($"Cantidad: {venta.Cantidad}");
                factura.AppendLine($"Precio Unitario: L. {venta.PrecioUnitario:F2}");
                factura.AppendLine("---------------------------------------");
                factura.AppendLine($"SUBTOTAL: L. {venta.Total:F2}");
                factura.AppendLine($"ISV (15%): L. {(venta.Total * 0.15m):F2}");
                factura.AppendLine($"TOTAL: L. {(venta.Total * 1.15m):F2}");
                factura.AppendLine("---------------------------------------");
                factura.AppendLine($"Método de Pago: {venta.MetodoPago}");
                factura.AppendLine($"Estado: {venta.EstadoVenta}");
                factura.AppendLine("=======================================");
                factura.AppendLine("¡Gracias por su compra!");

                MessageBox.Show(factura.ToString(), "Factura de Venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione una venta para generar factura.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarFormulario()
        {
            if (cmbLibro.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un libro.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLibro.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }

            if (numCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCantidad.Focus();
                return false;
            }

            if (numPrecioUnitario.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrecioUnitario.Focus();
                return false;
            }

            if (cmbMetodoPago.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un método de pago.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMetodoPago.Focus();
                return false;
            }

            return true;
        }

        private void AsignarDatosVenta(VentaLibros venta)
        {
            venta.LibroId = libroSeleccionado?.Id ?? 0;
            venta.Cliente = txtCliente.Text.Trim();
            venta.Cantidad = (int)numCantidad.Value;
            venta.PrecioUnitario = numPrecioUnitario.Value;
            venta.Total = decimal.Parse(txtTotal.Text.Replace("L. ", ""));
            venta.FechaVenta = dtpFechaVenta.Value;
            venta.MetodoPago = cmbMetodoPago.SelectedItem.ToString();
            venta.EstadoVenta = cmbEstadoVenta.SelectedItem.ToString();
            venta.ModificadoPor = "Sistema";
        }

        private void CargarVentaEnFormulario(VentaLibros venta)
        {
            txtIdVenta.Text = venta.Id.ToString();

            // Buscar y seleccionar el libro
            var libro = dataManager.Libros.FirstOrDefault(l => l.Id == venta.LibroId);
            if (libro != null)
            {
                for (int i = 0; i < cmbLibro.Items.Count; i++)
                {
                    if (cmbLibro.Items[i].ToString().Contains(libro.ISBN))
                    {
                        cmbLibro.SelectedIndex = i;
                        libroSeleccionado = libro;
                        break;
                    }
                }
            }

            txtCliente.Text = venta.Cliente;
            numCantidad.Value = venta.Cantidad;
            numPrecioUnitario.Value = venta.PrecioUnitario;
            txtTotal.Text = $"L. {venta.Total:F2}";
            dtpFechaVenta.Value = venta.FechaVenta;

            // Seleccionar método de pago
            for (int i = 0; i < cmbMetodoPago.Items.Count; i++)
            {
                if (cmbMetodoPago.Items[i].ToString() == venta.MetodoPago)
                {
                    cmbMetodoPago.SelectedIndex = i;
                    break;
                }
            }

            // Seleccionar estado de venta
            for (int i = 0; i < cmbEstadoVenta.Items.Count; i++)
            {
                if (cmbEstadoVenta.Items[i].ToString() == venta.EstadoVenta)
                {
                    cmbEstadoVenta.SelectedIndex = i;
                    break;
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtIdVenta.Clear();
            cmbLibro.SelectedIndex = 0;
            txtCliente.Clear();
            numCantidad.Value = 1;
            numPrecioUnitario.Value = 0;
            txtTotal.Text = "L. 0.00";
            dtpFechaVenta.Value = DateTime.Now;
            cmbMetodoPago.SelectedIndex = 0;
            cmbEstadoVenta.SelectedIndex = 0;
            txtInfoLibro.Clear();

            modoEdicion = false;
            ventaActual = null;
            libroSeleccionado = null;
            btnGuardar.Text = "Guardar";

            ActualizarCodigoVenta();
        }

        private void ActualizarCodigoVenta()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Ventas.Any() ?
                    dataManager.Ventas.Max(v => v.Id) + 1 : 1;
                txtIdVenta.Text = proximoId.ToString();
            }
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedIndex > 0)
            {
                string seleccion = cmbLibro.SelectedItem.ToString();
                string isbn = seleccion.Split('-')[0].Trim();

                libroSeleccionado = dataManager.Libros.FirstOrDefault(l => l.ISBN == isbn);

                if (libroSeleccionado != null)
                {
                    // Mostrar información del libro
                    txtInfoLibro.Text = $"Título: {libroSeleccionado.Titulo}\r\n" +
                                       $"Autor: {libroSeleccionado.Autor}\r\n" +
                                       $"Precio: L. {libroSeleccionado.Precio:F2}\r\n" +
                                       $"Disponibles: {libroSeleccionado.CantidadDisponible}";

                    // Establecer precio unitario
                    numPrecioUnitario.Value = libroSeleccionado.Precio;

                    // Actualizar total
                    CalcularTotal();
                }
            }
            else
            {
                txtInfoLibro.Clear();
                libroSeleccionado = null;
            }
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void numPrecioUnitario_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = numCantidad.Value * numPrecioUnitario.Value;
            txtTotal.Text = $"L. {total:F2}";
        }

        private void ActualizarEstadisticas()
        {
            try
            {
                // Ventas del día
                var ventasHoy = dataManager.Ventas
                    .Where(v => v.Activo && v.FechaVenta.Date == DateTime.Today)
                    .ToList();

                decimal totalHoy = ventasHoy.Sum(v => v.Total);
                lblVentasHoy.Text = $"Ventas Hoy: {ventasHoy.Count} (L. {totalHoy:F2})";

                // Ventas del mes
                var ventasMes = dataManager.Ventas
                    .Where(v => v.Activo &&
                           v.FechaVenta.Month == DateTime.Now.Month &&
                           v.FechaVenta.Year == DateTime.Now.Year)
                    .ToList();

                decimal totalMes = ventasMes.Sum(v => v.Total);
                lblVentasMes.Text = $"Ventas del Mes: {ventasMes.Count} (L. {totalMes:F2})";

                // Libro más vendido
                var libroMasVendido = dataManager.Ventas
                    .Where(v => v.Activo)
                    .GroupBy(v => v.LibroId)
                    .OrderByDescending(g => g.Sum(v => v.Cantidad))
                    .FirstOrDefault();

                if (libroMasVendido != null)
                {
                    var libro = dataManager.Libros.FirstOrDefault(l => l.Id == libroMasVendido.Key);
                    if (libro != null)
                    {
                        lblLibroMasVendido.Text = $"Más Vendido: {libro.Titulo} ({libroMasVendido.Sum(v => v.Cantidad)} unidades)";
                    }
                }

                // Total general
                decimal totalGeneral = dataManager.Ventas
                    .Where(v => v.Activo)
                    .Sum(v => v.Total);
                lblTotalGeneral.Text = $"Total General: L. {totalGeneral:F2}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en estadísticas: {ex.Message}");
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteVentas();
        }

        private void GenerarReporteVentas()
        {
            try
            {
                StringBuilder reporte = new StringBuilder();
                reporte.AppendLine("===========================================");
                reporte.AppendLine("       REPORTE DE VENTAS DE LIBROS");
                reporte.AppendLine("      BIBLIOTECA UNIVERSITARIA UJCV");
                reporte.AppendLine("===========================================");
                reporte.AppendLine($"Fecha del Reporte: {DateTime.Now:dd/MM/yyyy HH:mm}");
                reporte.AppendLine();

                var ventasHoy = dataManager.Ventas.Where(v => v.Activo && v.FechaVenta.Date == DateTime.Today).ToList();
                var ventasSemana = dataManager.Ventas.Where(v => v.Activo && v.FechaVenta >= DateTime.Now.AddDays(-7)).ToList();
                var ventasMes = dataManager.Ventas.Where(v => v.Activo &&
                    v.FechaVenta.Month == DateTime.Now.Month && v.FechaVenta.Year == DateTime.Now.Year).ToList();

                reporte.AppendLine("RESUMEN POR PERÍODO:");
                reporte.AppendLine($"Hoy: {ventasHoy.Count} ventas - L. {ventasHoy.Sum(v => v.Total):F2}");
                reporte.AppendLine($"Última Semana: {ventasSemana.Count} ventas - L. {ventasSemana.Sum(v => v.Total):F2}");
                reporte.AppendLine($"Este Mes: {ventasMes.Count} ventas - L. {ventasMes.Sum(v => v.Total):F2}");
                reporte.AppendLine();

                reporte.AppendLine("TOP 5 LIBROS MÁS VENDIDOS:");
                var topLibros = dataManager.Ventas
                    .Where(v => v.Activo)
                    .GroupBy(v => v.LibroId)
                    .Select(g => new { LibroId = g.Key, Total = g.Sum(v => v.Cantidad) })
                    .OrderByDescending(x => x.Total)
                    .Take(5)
                    .ToList();

                int pos = 1;
                foreach (var item in topLibros)
                {
                    var libro = dataManager.Libros.FirstOrDefault(l => l.Id == item.LibroId);
                    if (libro != null)
                    {
                        reporte.AppendLine($"{pos}. {libro.Titulo} - {item.Total} unidades");
                        pos++;
                    }
                }
                reporte.AppendLine();

                // Ventas por método de pago
                reporte.AppendLine("VENTAS POR MÉTODO DE PAGO:");
                var ventasPorMetodo = dataManager.Ventas
                    .Where(v => v.Activo)
                    .GroupBy(v => v.MetodoPago)
                    .Select(g => new { Metodo = g.Key, Cantidad = g.Count(), Total = g.Sum(v => v.Total) })
                    .OrderByDescending(x => x.Total)
                    .ToList();

                foreach (var metodo in ventasPorMetodo)
                {
                    reporte.AppendLine($"{metodo.Metodo}: {metodo.Cantidad} ventas - L. {metodo.Total:F2}");
                }

                reporte.AppendLine();
                reporte.AppendLine("===========================================");
                reporte.AppendLine($"Total General: L. {dataManager.Ventas.Where(v => v.Activo).Sum(v => v.Total):F2}");
                reporte.AppendLine("===========================================");

                MessageBox.Show(reporte.ToString(), "Reporte de Ventas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ventaActual = (VentaLibros)dgvVentas.Rows[e.RowIndex].DataBoundItem;
                CargarVentaEnFormulario(ventaActual);
                modoEdicion = true;
                btnGuardar.Text = "Actualizar";
            }
        }
    }
}