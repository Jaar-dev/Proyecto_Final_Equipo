using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using P1_2025_II_3P_PROYECTO_FINAL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    dataManager.CrearPrestamo(
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
                    // Modificar préstamo (solo fechas y observaciones)
                    if (prestamoActual != null && prestamoActual.EstadoPrestamo == "Activo")
                    {
                        prestamoActual.FechaVencimiento = dtpFechaVencimiento.Value;
                        prestamoActual.ActualizarFechaModificación();

                        dataManager.GuardarTodosLosDatos();

                        MessageBox.Show("Préstamo actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Operación inválida: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    "Ingrese el código del préstamo:",
                    "Buscar Préstamo", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                if (int.TryParse(busqueda, out int codigo))
                {
                    prestamoActual = dataManager.Prestamos.FirstOrDefault(p => p.Id == codigo);

                    if (prestamoActual != null)
                    {
                        CargarPrestamoEnFormulario(prestamoActual);
                        modoEdicion = true;

                        prestamoActual.ActualizarEstado();
                        txtEstado.Text = prestamoActual.EstadoPrestamo;

                        if (prestamoActual.EstadoPrestamo == "Vencido")
                        {
                            MessageBox.Show($"ATENCIÓN: Este préstamo está vencido.\n" +
                                          $"Días de retraso: {prestamoActual.DiasRetraso}\n" +
                                          $"Multa acumulada: L. {prestamoActual.MultaPorRetraso:F2}",
                                "Préstamo Vencido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        MessageBox.Show("Préstamo encontrado.", "Búsqueda exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Préstamo no encontrado.", "Búsqueda",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (prestamoActual == null)
            {
                MessageBox.Show("Primero debe buscar un préstamo para modificar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (prestamoActual.EstadoPrestamo != "Activo")
            {
                MessageBox.Show("Solo se pueden modificar préstamos activos.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (prestamoActual.PuedeRenovar())
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea renovar este préstamo por 14 días más?",
                    "Renovar Préstamo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dataManager.RenovarPrestamo(prestamoActual.Id);
                    MessageBox.Show($"Préstamo renovado exitosamente.\n" +
                                  $"Nueva fecha de vencimiento: {prestamoActual.FechaVencimiento:dd/MM/yyyy}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPrestamoEnFormulario(prestamoActual);
                }
            }
            else
            {
                MessageBox.Show($"Este préstamo no puede ser renovado.\n" +
                              $"Renovaciones realizadas: {prestamoActual.Renovaciones}/3",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prestamoActual == null)
                {
                    MessageBox.Show("Primero debe buscar un préstamo.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (prestamoActual.EstadoPrestamo == "Activo")
                {
                    DialogResult resultado = MessageBox.Show(
                        "Este préstamo está activo. ¿Desea procesar la devolución?",
                        "Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        ProcesarDevolucion();
                    }
                }
                else if (prestamoActual.EstadoPrestamo == "Devuelto")
                {
                    MessageBox.Show("Este préstamo ya fue devuelto.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Estado del préstamo: {prestamoActual.EstadoPrestamo}",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    usuario = dataManager.BuscarUsuarioPorNombre(txtUsuario.Text);
                }

                if (usuario != null)
                {
                    if (!usuario.Activo)
                    {
                        MessageBox.Show("El usuario está inactivo.", "Usuario Inactivo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Clear();
                        usuarioSeleccionado = null;
                        return;
                    }

                    usuarioSeleccionado = usuario;
                    txtUsuario.Text = $"{usuario.Id} - {usuario.NombreCompleto}";

                    if (!usuario.PuedePrestar())
                    {
                        string mensaje = "El usuario NO puede realizar préstamos:\n\n";

                        if (usuario.PrestamosActivos >= 5)
                            mensaje += $"- Tiene {usuario.PrestamosActivos} préstamos activos (máximo 5)\n";

                        if (usuario.MultasPendientes > 0)
                            mensaje += $"- Tiene multas pendientes: L. {usuario.MultasPendientes:F2}\n";

                        MessageBox.Show(mensaje, "Usuario No Habilitado",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtUsuario.Clear();
                        usuarioSeleccionado = null;
                    }
                    else
                    {
                        string info = $"Usuario: {usuario.NombreCompleto}\n" +
                                    $"Tipo: {usuario.TipoUsuario}\n" +
                                    $"Préstamos activos: {usuario.PrestamosActivos}/5";

                        lblUsuario.Text = info;
                    }
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
                        MessageBox.Show("El libro está inactivo.", "Libro Inactivo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtLibro.Clear();
                        libroSeleccionado = null;
                        return;
                    }

                    libroSeleccionado = libro;
                    txtLibro.Text = $"{libro.Id} - {libro.Titulo}";

                    if (!libro.EstaDisponible())
                    {
                        MessageBox.Show($"El libro NO está disponible.\n" +
                                      $"Ejemplares disponibles: {libro.CantidadDisponible}/{libro.CantidadTotal}",
                            "Libro No Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtLibro.Clear();
                        libroSeleccionado = null;
                    }
                    else
                    {
                        string info = $"Libro: {libro.Titulo}\n" +
                                    $"Autor: {libro.Autor}\n" +
                                    $"Disponibles: {libro.CantidadDisponible}/{libro.CantidadTotal}";

                        lblLibro.Text = info;
                    }
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
                var estadisticas = dataManager.ObtenerEstadisticas();

                // Actualizar etiquetas si existen
                this.Text = $"Gestión de Préstamos - Activos: {estadisticas["PrestamosActivos"]} | " +
                           $"Vencidos: {estadisticas["PrestamosVencidos"]}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar estadísticas: {ex.Message}");
            }
        }

        private Libro MostrarListaSeleccionLibros(List<Libro> libros)
        {
            Form formSeleccion = new Form
            {
                Text = "Seleccione un libro",
                Size = new Size(700, 400),
                StartPosition = FormStartPosition.CenterParent
            };

            ListView listView = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView.Columns.Add("ID", 50);
            listView.Columns.Add("Título", 250);
            listView.Columns.Add("Autor", 150);
            listView.Columns.Add("Disponibles", 100);

            foreach (var libro in libros)
            {
                var item = new ListViewItem(libro.Id.ToString());
                item.SubItems.Add(libro.Titulo);
                item.SubItems.Add(libro.Autor);
                item.SubItems.Add($"{libro.CantidadDisponible}/{libro.CantidadTotal}");
                item.Tag = libro;
                listView.Items.Add(item);
            }

            Button btnSeleccionar = new Button
            {
                Text = "Seleccionar",
                Dock = DockStyle.Bottom,
                Height = 30
            };

            Libro libroSeleccionado = null;

            btnSeleccionar.Click += (s, e) =>
            {
                if (listView.SelectedItems.Count > 0)
                {
                    libroSeleccionado = (Libro)listView.SelectedItems[0].Tag;
                    formSeleccion.DialogResult = DialogResult.OK;
                }
            };

            formSeleccion.Controls.Add(listView);
            formSeleccion.Controls.Add(btnSeleccionar);

            return formSeleccion.ShowDialog() == DialogResult.OK ? libroSeleccionado : null;
        }

        private void ProcesarDevolucion()
        {
            Form formDevolucion = new Form
            {
                Text = "Procesar Devolución",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterParent
            };

            Label lblCondicion = new Label
            {
                Text = "Condición del libro:",
                Location = new Point(20, 20),
                AutoSize = true
            };

            ComboBox cmbCondicion = new ComboBox
            {
                Location = new Point(20, 50),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbCondicion.Items.AddRange(new[] { "Excelente", "Bueno", "Regular", "Malo", "Perdido" });
            cmbCondicion.SelectedIndex = 1;

            Label lblObservaciones = new Label
            {
                Text = "Observaciones:",
                Location = new Point(20, 90),
                AutoSize = true
            };

            TextBox txtObservaciones = new TextBox
            {
                Location = new Point(20, 120),
                Width = 340,
                Height = 60,
                Multiline = true
            };

            Button btnProcesar = new Button
            {
                Text = "Procesar Devolución",
                Location = new Point(150, 200),
                Width = 120
            };

            btnProcesar.Click += (s, e) =>
            {
                try
                {
                    dataManager.DevolverPrestamo(
                        prestamoActual.Id,
                        cmbCondicion.SelectedItem.ToString(),
                        bibliotecarioActual.Id
                    );

                    MessageBox.Show("Devolución procesada exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    formDevolucion.DialogResult = DialogResult.OK;
                    LimpiarFormulario();
                    ActualizarEstadisticas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar devolución: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            formDevolucion.Controls.AddRange(new Control[]
            {
                lblCondicion, cmbCondicion, lblObservaciones, txtObservaciones, btnProcesar
            });

            formDevolucion.ShowDialog();
        }

        private void ImprimirComprobante()
        {
            string comprobante = "COMPROBANTE DE PRÉSTAMO\n";
            comprobante += "========================\n\n";
            comprobante += $"Préstamo No: {txtIDprestamo.Text}\n";
            comprobante += $"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}\n\n";
            comprobante += $"Usuario: {usuarioSeleccionado.NombreCompleto}\n";
            comprobante += $"Libro: {libroSeleccionado.Titulo}\n";
            comprobante += $"Autor: {libroSeleccionado.Autor}\n\n";
            comprobante += $"Fecha de préstamo: {dtpFechaPrestamo.Value:dd/MM/yyyy}\n";
            comprobante += $"Fecha de vencimiento: {dtpFechaVencimiento.Value:dd/MM/yyyy}\n\n";
            comprobante += $"Bibliotecario: {bibliotecarioActual.NombreCompleto}\n";
            comprobante += "========================\n";
            comprobante += "Recuerde devolver el libro en la fecha indicada.\n";
            comprobante += "Las devoluciones tardías generan multas.";

            MessageBox.Show(comprobante, "Comprobante de Préstamo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Implementar opciones del menú Archivo
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListaPrestamos();
        }

        private void MostrarListaPrestamos()
        {
            var prestamosActivos = dataManager.Prestamos.Where(p => p.EstadoPrestamo == "Activo").ToList();

            if (!prestamosActivos.Any())
            {
                MessageBox.Show("No hay préstamos activos.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string lista = "LISTA DE PRÉSTAMOS ACTIVOS\n";
            lista += "=====================================\n\n";

            foreach (var prestamo in prestamosActivos)
            {
                prestamo.ActualizarEstado();
                var usuario = dataManager.BuscarUsuario(prestamo.UsuarioId);
                var libro = dataManager.BuscarLibro(prestamo.LibroId);

                lista += $"Préstamo #{prestamo.Id}\n";
                lista += $"Usuario: {usuario?.NombreCompleto ?? "Desconocido"}\n";
                lista += $"Libro: {libro?.Titulo ?? "Desconocido"}\n";
                lista += $"Vencimiento: {prestamo.FechaVencimiento:dd/MM/yyyy}\n";
                lista += $"Estado: {prestamo.EstadoPrestamo}\n";

                if (prestamo.DiasRetraso > 0)
                {
                    lista += $"RETRASO: {prestamo.DiasRetraso} días\n";
                }

                lista += "-------------------------------------\n";
            }

            Form formLista = new Form
            {
                Text = "Lista de Préstamos Activos",
                Size = new Size(600, 500),
                StartPosition = FormStartPosition.CenterParent
            };

            TextBox textBox = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                Text = lista,
                Font = new Font("Consolas", 10)
            };

            formLista.Controls.Add(textBox);
            formLista.ShowDialog();
        }

    }
}