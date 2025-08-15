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

        private void ConfigurarFormulario()
        {
            try
            {
                numericNumeroPaginas.Minimum = 1;
                numericNumeroPaginas.Maximum = 99999;
                numericNumeroPaginas.Value = 100;

                dtpAño.Format = DateTimePickerFormat.Custom;
                dtpAño.CustomFormat = "yyyy";
                dtpAño.ShowUpDown = true;

                txtIDLibro.Enabled = false;

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
                cmbTitulo.Items.Clear();
                cmbCategoria.Items.Clear();
                cmbIdioma.Items.Clear();

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
                    cmbCategoria.Items.AddRange(new string[] {
                        "Literatura", "Ciencias", "Historia", "Tecnología", "Arte", "Infantil"
                    });
                }
                cmbCategoria.SelectedIndex = 0;

                cmbIdioma.Items.AddRange(new string[] {
                    "-- Seleccione --", "Español", "Inglés", "Francés", "Alemán", "Italiano", "Portugués"
                });
                cmbIdioma.SelectedIndex = 0;

                cmbTitulo.DropDownStyle = ComboBoxStyle.Simple;
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
            toolTip.SetToolTip(cmbTitulo, "Ingrese el título del libro");
            toolTip.SetToolTip(txtAutor, "Ingrese el nombre del autor");
            toolTip.SetToolTip(cmbCategoria, "Seleccione la categoría del libro");
            toolTip.SetToolTip(numericNumeroPaginas, "Número de páginas del libro");
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            ActualizarCodigoLibro();
            this.StartPosition = FormStartPosition.CenterScreen;


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
                    if (libroActual != null)
                    {
                        AsignarDatosLibro(libroActual);
                        libroActual.ActualizarFechaModificación();

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

                if (int.TryParse(busqueda, out int codigo))
                {
                    libroEncontrado = dataManager.BuscarLibro(codigo);
                }

                if (libroEncontrado == null)
                {
                    libroEncontrado = dataManager.BuscarLibroPorISBN(busqueda);
                }

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
                    libroActual.Activo = false;
                    libroActual.Estado = "Eliminado";
                    libroActual.ActualizarFechaModificación();

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

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(cmbTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                cmbCategoria.SelectedIndex <= 0 ||
                cmbIdioma.SelectedIndex <= 0)
            {
                return false;
            }

            string isbn = txtISBN.Text.Replace("-", "").Replace(" ", "");
            if (isbn.Length != 13 || !long.TryParse(isbn, out _))
            {
                MessageBox.Show("El ISBN debe tener 13 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int año = dtpAño.Value.Year;
            if (año < 1450 || año > DateTime.Now.Year)
            {
                MessageBox.Show($"El año de publicación debe estar entre 1450 y {DateTime.Now.Year}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void AsignarDatosLibro(Libro libro)
        {
            libro.ISBN = txtISBN.Text.Trim();
            libro.Titulo = cmbTitulo.Text.Trim();
            libro.Autor = txtAutor.Text.Trim();
            libro.AñoPublicacion = dtpAño.Value.Year;

            if (cmbCategoria.SelectedIndex > 0)
                libro.Categoria = cmbCategoria.SelectedItem.ToString();

            libro.Editorial = "Editorial por defecto";
            libro.CantidadTotal = 1;
            libro.CantidadDisponible = 1;
            libro.Precio = 0;

            if (cmbIdioma.SelectedIndex > 0)
                libro.Idioma = cmbIdioma.SelectedItem.ToString();

            libro.NumeroPaginas = (int)numericNumeroPaginas.Value;
            libro.Edicion = "Primera";
            libro.Ubicacion = "Estantería A1";
        }

        private void CargarLibroEnFormulario(Libro libro)
        {
            txtIDLibro.Text = libro.Id.ToString();
            txtISBN.Text = libro.ISBN;
            cmbTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;

            dtpAño.Value = new DateTime(libro.AñoPublicacion, 1, 1);

            for (int i = 0; i < cmbCategoria.Items.Count; i++)
            {
                if (cmbCategoria.Items[i].ToString() == libro.Categoria)
                {
                    cmbCategoria.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbIdioma.Items.Count; i++)
            {
                if (cmbIdioma.Items[i].ToString() == libro.Idioma)
                {
                    cmbIdioma.SelectedIndex = i;
                    break;
                }
            }

            numericNumeroPaginas.Value = libro.NumeroPaginas;
        }

        private void LimpiarFormulario()
        {
            txtIDLibro.Clear();
            txtISBN.Clear();
            cmbTitulo.Text = "";
            txtAutor.Clear();
            dtpAño.Value = DateTime.Now;
            cmbCategoria.SelectedIndex = 0;
            cmbIdioma.SelectedIndex = 0;
            numericNumeroPaginas.Value = 100;

            modoEdicion = false;
            libroActual = null;
        }

        private void ActualizarCodigoLibro()
        {
            if (!modoEdicion)
            {
                int proximoId = dataManager.Libros.Any() ?
                    dataManager.Libros.Max(l => l.Id) + 1 : 1;
                txtIDLibro.Text = proximoId.ToString();
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menú Archivo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                lista += libro.ObtenerInformación() + "\n";
                lista += "-------------------------------------\n";
            }

            MessageBox.Show(lista, "Lista de Libros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}