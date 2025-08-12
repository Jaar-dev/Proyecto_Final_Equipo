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

namespace P1_2025_II_3P_PROYECTO_FINAL
{
    public partial class FrmLibro : Form
    {
        private DataManager dataManager;
        private Libro libroActual;
        private bool modoEdicion = false;
        public FrmLibro()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            ConfigurarFormulario();
        }

        /private void ConfigurarFormulario()
        {
            try
            { 
                CargarCombos();

                numCantidad.Minimum = 0;
                numCantidad.Maximum = 9999;
                numCantidad.Value = 1;

                numDisponibles.Minimum = 0;
                numDisponibles.Maximum = 9999;
                numDisponibles.Value = 1;

                numPaginas.Minimum = 1;
                numPaginas.Maximum = 99999;
                numPaginas.Value = 100;

                numPrecio.Minimum = 0;
                numPrecio.Maximum = 99999;
                numPrecio.DecimalPlaces = 2;

                numAnioPublicacion.Minimum = 1450;
                numAnioPublicacion.Maximum = DateTime.Now.Year;
                numAnioPublicacion.Value = DateTime.Now.Year;

                txtCodigo.Enabled = false;

                dtpFechaAdquisicion.Format = DateTimePickerFormat.Short;
                dtpFechaAdquisicion.Value = DateTime.Now;

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
                // Cargar Autores
                cmbAutor.Items.Clear();
                cmbAutor.Items.Add("-- Seleccione --");

                if (dataManager.Autores != null && dataManager.Autores.Any())
                {
                    foreach (var autor in dataManager.Autores.Where(a => a.Activo))
                    {
                        cmbAutor.Items.Add(autor.ObtenerNombrePublicacion());
                    }
                }
                else
                {
                    // Agregar algunos autores por defecto
                    cmbAutor.Items.AddRange(new string[] {
                        "Gabriel García Márquez",
                        "Isabel Allende",
                        "Jorge Luis Borges",
                        "Pablo Neruda"
                    });
                }
                cmbAutor.SelectedIndex = 0;

                // Cargar Editoriales
                cmbEditorial.Items.Clear();
                cmbEditorial.Items.Add("-- Seleccione --");

                if (dataManager.Editoriales != null && dataManager.Editoriales.Any())
                {
                    foreach (var editorial in dataManager.Editoriales.Where(e => e.Activo))
                    {
                        cmbEditorial.Items.Add(editorial.Nombre);
                    }
                }
                else
                {
                    // Agregar algunas editoriales por defecto
                    cmbEditorial.Items.AddRange(new string[] {
                        "Santillana",
                        "Pearson",
                        "McGraw-Hill",
                        "Planeta"
                    });
                }
                cmbEditorial.SelectedIndex = 0;

                // Cargar Categorías
                cmbCategoria.Items.Clear();
                cmbCategoria.Items.Add("-- Seleccione --");

                if (dataManager.Categorias != null && dataManager.Categorias.Any())
                {
                    foreach (var categoria in dataManager.Categorias.Where(c => c.Activo))
                    {
                        cmbCategoria.Items.Add(categoria.Nombre);
                    }
                }
                else
                {
                    // Agregar algunas categorías por defecto
                    cmbCategoria.Items.AddRange(new string[] {
                        "Literatura",
                        "Ciencias",
                        "Historia",
                        "Tecnología",
                        "Arte",
                        "Infantil"
                    });
                }
                cmbCategoria.SelectedIndex = 0;

                // Cargar Ubicaciones
                cmbUbicacionFisica.Items.Clear();
                cmbUbicacionFisica.Items.Add("-- Seleccione --");

                if (dataManager.Ubicaciones != null && dataManager.Ubicaciones.Any())
                {
                    foreach (var ubicacion in dataManager.Ubicaciones.Where(u => u.Activo))
                    {
                        cmbUbicacionFisica.Items.Add($"{ubicacion.Estanteria}-{ubicacion.Pasillo}-{ubicacion.Seccion}");
                    }
                }
                else
                {
                    // Agregar algunas ubicaciones por defecto
                    cmbUbicacionFisica.Items.AddRange(new string[] {
                        "A1-1-Literatura",
                        "B1-2-Ciencias",
                        "C1-3-Historia",
                        "D1-4-Tecnología"
                    });
                }
                cmbUbicacionFisica.SelectedIndex = 0;

                // Cargar Idiomas
                cmbIdioma.Items.Clear();
                cmbIdioma.Items.AddRange(new string[] {
                    "-- Seleccione --",
                    "Español",
                    "Inglés",
                    "Francés",
                    "Alemán",
                    "Italiano",
                    "Portugués"
                });
                cmbIdioma.SelectedIndex = 0;
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
            toolTip.SetToolTip(txtISBN, "Ingrese el ISBN del libro (13 dígitos)");
            toolTip.SetToolTip(txtTitulo, "Ingrese el título del libro");
            toolTip.SetToolTip(cmbAutor, "Seleccione o ingrese el autor");
            toolTip.SetToolTip(cmbEditorial, "Seleccione la editorial");
            toolTip.SetToolTip(cmbCategoria, "Seleccione la categoría del libro");
            toolTip.SetToolTip(numCantidad, "Cantidad total de ejemplares");
            toolTip.SetToolTip(numDisponibles, "Ejemplares disponibles para préstamo");
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            ActualizarCodigoLibro();
        }

        // ========================================
        // MÉTODOS CRUD
        // ========================================

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
                    // Crear nuevo libro
                    Libro nuevoLibro = new Libro();
                    AsignarDatosLibro(nuevoLibro);

                    dataManager.AgregarLibro(nuevoLibro);

                    MessageBox.Show("Libro guardado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigoLibro();
                }
                else
                {
                    // Modificar libro existente
                    if (libroActual != null)
                    {
                        AsignarDatosLibro(libroActual);
                        libroActual.ActualizarFechaModificacion();

                        dataManager.ActualizarLibro(libroActual);

                        MessageBox.Show("Libro actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoLibro();
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
                    "Ingrese el código del libro, ISBN o título a buscar:",
                    "Buscar Libro", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                Libro libroEncontrado = null;

                // Buscar por código
                if (int.TryParse(busqueda, out int codigo))
                {
                    libroEncontrado = dataManager.BuscarLibro(codigo);
                }

                // Si no se encontró por código, buscar por ISBN
                if (libroEncontrado == null)
                {
                    libroEncontrado = dataManager.BuscarLibroPorISBN(busqueda);
                }

                // Si no se encontró por ISBN, buscar por título
                if (libroEncontrado == null)
                {
                    var librosPorTitulo = dataManager.BuscarLibrosPorTitulo(busqueda);
                    if (librosPorTitulo.Any())
                    {
                        libroEncontrado = librosPorTitulo.First();
                    }
                }

                if (libroEncontrado != null)
                {
                    CargarLibroEnFormulario(libroEncontrado);
                    modoEdicion = true;
                    libroActual = libroEncontrado;
                    MessageBox.Show("Libro encontrado.", "Búsqueda exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Libro no encontrado.", "Búsqueda",
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
            if (libroActual == null)
            {
                MessageBox.Show("Primero debe buscar un libro para modificar.",
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
                if (libroActual == null)
                {
                    MessageBox.Show("Primero debe buscar un libro para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar el libro '{libroActual.Titulo}'?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Marcar como inactivo
                    libroActual.Activo = false;
                    libroActual.Estado = "Eliminado";
                    libroActual.ActualizarFechaModificacion();

                    dataManager.ActualizarLibro(libroActual);

                    LimpiarFormulario();
                    modoEdicion = false;
                    libroActual = null;

                    MessageBox.Show("Libro eliminado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========================================
        // MÉTODOS DE VALIDACIÓN
        // ========================================

        private bool ValidarFormulario()
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                cmbAutor.SelectedIndex <= 0 ||
                cmbEditorial.SelectedIndex <= 0 ||
                cmbCategoria.SelectedIndex <= 0 ||
                cmbIdioma.SelectedIndex <= 0)
            {
                return false;
            }

            // Validar ISBN
            string isbn = txtISBN.Text.Replace("-", "").Replace(" ", "");
            if (isbn.Length != 13 || !long.TryParse(isbn, out _))
            {
                MessageBox.Show("El ISBN debe tener 13 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar año de publicación
            if (numAnioPublicacion.Value < 1450 || numAnioPublicacion.Value > DateTime.Now.Year)
            {
                MessageBox.Show($"El año de publicación debe estar entre 1450 y {DateTime.Now.Year}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar cantidades
            if (numDisponibles.Value > numCantidad.Value)
            {
                MessageBox.Show("Los ejemplares disponibles no pueden ser mayor que la cantidad total.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ========================================
        // MÉTODOS AUXILIARES
        // ========================================

        private void AsignarDatosLibro(Libro libro)
        {
            libro.ISBN = txtISBN.Text.Trim();
            libro.Titulo = txtTitulo.Text.Trim();

            if (cmbAutor.SelectedIndex > 0)
                libro.Autor = cmbAutor.SelectedItem.ToString();

            if (cmbEditorial.SelectedIndex > 0)
                libro.Editorial = cmbEditorial.SelectedItem.ToString();

            libro.AnioPublicacion = (int)numAnioPublicacion.Value;

            if (cmbCategoria.SelectedIndex > 0)
                libro.Categoria = cmbCategoria.SelectedItem.ToString();

            libro.CantidadTotal = (int)numCantidad.Value;
            libro.CantidadDisponible = (int)numDisponibles.Value;
            libro.Precio = numPrecio.Value;

            if (cmbIdioma.SelectedIndex > 0)
                libro.Idioma = cmbIdioma.SelectedItem.ToString();

            libro.NumeroPaginas = (int)numPaginas.Value;
            libro.Edicion = txtEdicion.Text.Trim();

            if (cmbUbicacionFisica.SelectedIndex > 0)
                libro.Ubicacion = cmbUbicacionFisica.SelectedItem.ToString();

            libro.Observaciones = txtDescripcion.Text.Trim();
        }

        private void CargarLibroEnFormulario(Libro libro)
        {
            txtCodigo.Text = libro.Id.ToString();
            txtISBN.Text = libro.ISBN;
            txtTitulo.Text = libro.Titulo;

            // Seleccionar autor
            for (int i = 0; i < cmbAutor.Items.Count; i++)
            {
                if (cmbAutor.Items[i].ToString() == libro.Autor)
                {
                    cmbAutor.SelectedIndex = i;
                    break;
                }
            }

            // Seleccionar editorial
            for (int i = 0; i < cmbEditorial.Items.Count; i++)
            {
                if (cmbEditorial.Items[i].ToString() == libro.Editorial)
                {
                    cmbEditorial.SelectedIndex = i;
                    break;
                }
            }

            numAnioPublicacion.Value = libro.AnioPublicacion;

            // Seleccionar categoría
            for (int i = 0; i < cmbCategoria.Items.Count; i++)
            {
                if (cmbCategoria.Items[i].ToString() == libro.Categoria)
                {
                    cmbCategoria.SelectedIndex = i;
                    break;
                }
            }

            numCantidad.Value = libro.CantidadTotal;
            numDisponibles.Value = libro.CantidadDisponible;
            numPrecio.Value = libro.Precio;

            // Seleccionar idioma
            for (int i = 0; i < cmbIdioma.Items.Count; i++)
            {
                if (cmbIdioma.Items[i].ToString() == libro.Idioma)
                {
                    cmbIdioma.SelectedIndex = i;
                    break;
                }
            }

            numPaginas.Value = libro.NumeroPaginas;
            txtEdicion.Text = libro.Edicion;

            // Seleccionar ubicación
            if (!string.IsNullOrWhiteSpace(libro.Ubicacion))
            {
                for (int i = 0; i < cmbUbicacionFisica.Items.Count; i++)
                {
                    if (cmbUbicacionFisica.Items[i].ToString() == libro.Ubicacion)
                    {
                        cmbUbicacionFisica.SelectedIndex = i;
                        break;
                    }
                }
            }

            txtDescripcion.Text = libro.Observaciones;
            dtpFechaAdquisicion.Value = libro.FechaCreacion;
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtISBN.Clear();
            txtTitulo.Clear();
            cmbAutor.SelectedIndex = 0;
            cmbEditorial.SelectedIndex = 0;
            numAnioPublicacion.Value = DateTime.Now.Year;
            cmbCategoria.SelectedIndex = 0;
            numCantidad.Value = 1;
            numDisponibles.Value = 1;
            numPrecio.Value = 0;
            cmbIdioma.SelectedIndex = 0;
            numPaginas.Value = 100;
            txtEdicion.Clear();
            cmbUbicacionFisica.SelectedIndex = 0;
            txtDescripcion.Clear();
            dtpFechaAdquisicion.Value = DateTime.Now;

            modoEdicion = false;
            libroActual = null;
        }

        private void ActualizarCodigoLibro()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Libros.Any() ?
                    dataManager.Libros.Max(l => l.Id) + 1 : 1;
                txtCodigo.Text = proximoId.ToString();
            }
        }

        // ========================================
        // EVENTOS DEL MENÚ
        // ========================================

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementar opciones del menú Archivo
            MessageBox.Show("Menú Archivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementar opciones del menú Editar
            MessageBox.Show("Menú Editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarListaLibros();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Sistema de Gestión de Libros\n\n" +
                           "1. Use 'Buscar' para encontrar un libro existente\n" +
                           "2. Use 'Modificar' para editar un libro encontrado\n" +
                           "3. Use 'Eliminar' para desactivar un libro\n" +
                           "4. Use 'Guardar' para crear un nuevo libro o guardar cambios\n\n" +
                           "El ISBN debe tener 13 dígitos.\n" +
                           "Complete todos los campos obligatorios.";

            MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarListaLibros()
        {
            if (!dataManager.Libros.Any(l => l.Activo))
            {
                MessageBox.Show("No hay libros registrados.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string lista = "LISTA DE LIBROS ACTIVOS\n";
            lista += "=====================================\n\n";

            foreach (var libro in dataManager.Libros.Where(l => l.Activo).Take(10))
            {
                lista += libro.ObtenerInformacion() + "\n";
                lista += "-------------------------------------\n";
            }

            MessageBox.Show(lista, "Lista de Libros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ========================================
        // VALIDACIONES EN TIEMPO REAL
        // ========================================

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, guión y backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            // Ajustar el máximo de ejemplares disponibles
            numDisponibles.Maximum = numCantidad.Value;

            // Si los disponibles son mayores que el total, ajustar
            if (numDisponibles.Value > numCantidad.Value)
            {
                numDisponibles.Value = numCantidad.Value;
            }
        }
    }
}*/