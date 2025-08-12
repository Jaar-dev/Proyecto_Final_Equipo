using P1_2025_II_3P_PROYECTO_FINAL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmUsuario : Form
    {
        private List<Usuario> listaUsuarios;
        private Usuario usuarioActual;
        private string archivoJson = "usuarios.json";
        private bool modoEdicion = false;
        public FrmUsuario()
        {
            InitializeComponent();
            listaUsuarios = new List<Usuario>();
            CargarDatos();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Value = DateTime.Now;

            txtCodigoUsuario.Enabled = false;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtNombreUsuario, "Ingrese un nombre de usuario entre 4 y 20 caracteres");
            toolTip.SetToolTip(txtContraseña, "La contraseña debe tener al menos 8 caracteres, una mayúscula, una minúscula y un número");
            toolTip.SetToolTip(txtTelefono, "Formato: ####-####");
            toolTip.SetToolTip(txtCorreo, "Ingrese un correo electrónico válido");

            LimpiarFormulario();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ActualizarCodigoUsuario();
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
                    Usuario nuevoUsuario = new Usuario();
                    AsignarDatosUsuario(nuevoUsuario);
                    nuevoUsuario.Id = ObtenerProximoId();

                    listaUsuarios.Add(nuevoUsuario);
                    GuardarDatos();

                    MessageBox.Show("Usuario guardado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    ActualizarCodigoUsuario();
                }
                else
                {
                    if (usuarioActual != null)
                    {
                        AsignarDatosUsuario(usuarioActual);
                        usuarioActual.ModificadoPor = "Sistema";
                        usuarioActual.ActualizarFechaModificación();

                        GuardarDatos();

                        MessageBox.Show("Usuario actualizado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        modoEdicion = false;
                        ActualizarCodigoUsuario();
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
                    "Ingrese el código de usuario o nombre de usuario a buscar:",
                    "Buscar Usuario", "");

                if (string.IsNullOrWhiteSpace(busqueda))
                    return;

                Usuario usuarioEncontrado = null;

                if (int.TryParse(busqueda, out int codigo))
                {
                    usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.Id == codigo);
                }

                if (usuarioEncontrado == null)
                {
                    usuarioEncontrado = listaUsuarios.FirstOrDefault(
                        u => u.NombreUsuario.ToLower() == busqueda.ToLower());
                }

                if (usuarioEncontrado != null)
                {
                    CargarUsuarioEnFormulario(usuarioEncontrado);
                    modoEdicion = true;
                    usuarioActual = usuarioEncontrado;
                    MessageBox.Show("Usuario encontrado.", "Búsqueda exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Búsqueda",
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
            if (usuarioActual == null)
            {
                MessageBox.Show("Primero debe buscar un usuario para modificar.",
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
                if (usuarioActual == null)
                {
                    MessageBox.Show("Primero debe buscar un usuario para eliminar.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de eliminar al usuario {usuarioActual.NombreUsuario}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (usuarioActual.PrestamosActivos > 0)
                    {
                        MessageBox.Show("No se puede eliminar un usuario con préstamos activos.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    usuarioActual.Activo = false;
                    usuarioActual.Estado = "Eliminado";
                    usuarioActual.ModificadoPor = "Sistema";
                    usuarioActual.ActualizarFechaModificación();

                    GuardarDatos();
                    LimpiarFormulario();
                    modoEdicion = false;
                    usuarioActual = null;

                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito",
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
                string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                return false;
            }

            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^\d{4}-\d{4}$"))
            {
                MessageBox.Show("El formato del teléfono debe ser: ####-####", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El formato del correo electrónico es inválido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!modoEdicion)
            {
                if (listaUsuarios.Any(u => u.NombreUsuario.ToLower() == txtNombreUsuario.Text.ToLower() && u.Activo))
                {
                    MessageBox.Show("El nombre de usuario ya existe.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private bool ValidarContrasena(string contrasena)
        {
            if (contrasena.Length < 8) return false;

            bool tieneMayuscula = System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[A-Z]");
            bool tieneMinuscula = System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[a-z]");
            bool tieneNumero = System.Text.RegularExpressions.Regex.IsMatch(contrasena, @"[0-9]");

            return tieneMayuscula && tieneMinuscula && tieneNumero;
        }

        private void AsignarDatosUsuario(Usuario usuario)
        {
            string[] partesNombre = txtNombre.Text.Trim().Split(' ');
            if (partesNombre.Length >= 2)
            {
                usuario.Nombre = string.Join(" ", partesNombre.Take(partesNombre.Length - 1));
                usuario.Apellido = partesNombre.Last();
            }
            else
            {
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Apellido = "";
            }

            usuario.NombreUsuario = txtNombreUsuario.Text.Trim();
            usuario.Correo = txtCorreo.Text.Trim();
            usuario.Contrasena = txtContraseña.Text;
            usuario.Telefono = txtTelefono.Text.Trim();
            usuario.Direccion = txtDireccion.Text.Trim();
            usuario.FechaRegistro = dtpFechaRegistro.Value;
            usuario.FechaNacimiento = DateTime.Now.AddYears(-25);
            usuario.Genero = "Otro";
            usuario.Identificacion = "0000000000000"; 
            usuario.TipoUsuario = "Estudiante"; 
        }

        private void CargarUsuarioEnFormulario(Usuario usuario)
        {
            txtCodigoUsuario.Text = usuario.Id.ToString();
            txtNombre.Text = usuario.NombreCompleto;
            txtNombreUsuario.Text = usuario.NombreUsuario;
            txtCorreo.Text = usuario.Correo;
            txtContraseña.Text = usuario.Contrasena;
            txtConfirmarContraseña.Text = usuario.Contrasena;
            txtTelefono.Text = usuario.Telefono;
            txtDireccion.Text = usuario.Direccion;
            dtpFechaRegistro.Value = usuario.FechaRegistro;
        }

        private void LimpiarFormulario()
        {
            txtCodigoUsuario.Clear();
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            dtpFechaRegistro.Value = DateTime.Now;

            modoEdicion = false;
            usuarioActual = null;
        }

        private int ObtenerProximoId()
        {
            if (listaUsuarios.Count == 0)
                return 1;
            return listaUsuarios.Max(u => u.Id) + 1;
        }

        private void ActualizarCodigoUsuario()
        {
            if (!modoEdicion)
            {
                txtCodigoUsuario.Text = ObtenerProximoId().ToString();
            }
        }

        private void CargarDatos()
        {
            try
            {
                if (File.Exists(archivoJson))
                {
                    string json = File.ReadAllText(archivoJson);
                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                listaUsuarios = new List<Usuario>();
            }
        }

        private void GuardarDatos()
        {
            try
            {
                string json = JsonConvert.SerializeObject(listaUsuarios, Formatting.Indented);
                File.WriteAllText(archivoJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MostrarListaUsuarios();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Sistema de Gestión de Usuarios\n\n" +
                           "1. Use 'Buscar' para encontrar un usuario existente\n" +
                           "2. Use 'Modificar' para editar un usuario encontrado\n" +
                           "3. Use 'Eliminar' para desactivar un usuario\n" +
                           "4. Use 'Guardar' para crear un nuevo usuario o guardar cambios\n\n" +
                           "Formato de teléfono: ####-####\n" +
                           "La contraseña debe tener al menos 8 caracteres,\n" +
                           "una mayúscula, una minúscula y un número.";

            MessageBox.Show(mensaje, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarListaUsuarios()
        {
            if (listaUsuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string lista = "LISTA DE USUARIOS ACTIVOS\n";
            lista += "=====================================\n\n";

            foreach (var usuario in listaUsuarios.Where(u => u.Activo))
            {
                lista += usuario.ObtenerInformación() + "\n";
                lista += "-------------------------------------\n";
            }

            MessageBox.Show(lista, "Lista de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El formato del correo electrónico es inválido.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                }
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                if (!ValidarContrasena(txtContraseña.Text))
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, " +
                                  "una mayúscula, una minúscula y un número.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
            }
        }
    }
}
