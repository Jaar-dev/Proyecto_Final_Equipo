using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using P1_2025_II_3P_PROYECTO_FINAL.Clases;

namespace P1_2025_II_3P_PROYECTO_FINAL.Helpers
{
    public static class JsonHelper
    {
        private static readonly string DataPath = "Data";

        static JsonHelper()
        {
            if (!Directory.Exists(DataPath))
            {
                Directory.CreateDirectory(DataPath);
            }
        }

        public static void GuardarJson<T>(List<T> lista, string nombreArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(DataPath, nombreArchivo);
                string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
                File.WriteAllText(rutaCompleta, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar archivo JSON: {ex.Message}");
            }
        }

        public static List<T> CargarJson<T>(string nombreArchivo)
        {
            try
            {
                string rutaCompleta = Path.Combine(DataPath, nombreArchivo);

                if (!File.Exists(rutaCompleta))
                {
                    return new List<T>();
                }

                string json = File.ReadAllText(rutaCompleta);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar archivo JSON: {ex.Message}");
            }
        }

        public static bool ExisteArchivo(string nombreArchivo)
        {
            string rutaCompleta = Path.Combine(DataPath, nombreArchivo);
            return File.Exists(rutaCompleta);
        }

        public static void CrearBackup(string nombreArchivo)
        {
            try
            {
                string rutaOriginal = Path.Combine(DataPath, nombreArchivo);
                if (File.Exists(rutaOriginal))
                {
                    string nombreBackup = $"{Path.GetFileNameWithoutExtension(nombreArchivo)}_backup_{DateTime.Now:yyyyMMdd_HHmmss}.json";
                    string rutaBackup = Path.Combine(DataPath, "Backups", nombreBackup);

                    string dirBackup = Path.Combine(DataPath, "Backups");
                    if (!Directory.Exists(dirBackup))
                    {
                        Directory.CreateDirectory(dirBackup);
                    }

                    File.Copy(rutaOriginal, rutaBackup, true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al crear backup: {ex.Message}");
            }
        }
    }

    public class DataManager
    {
        private static DataManager _instance;
        public static DataManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataManager();
                }
                return _instance;
            }
        }

        private const string ARCHIVO_USUARIOS = "usuarios.json";
        private const string ARCHIVO_LIBROS = "libros.json";
        private const string ARCHIVO_PRESTAMOS = "prestamos.json";
        private const string ARCHIVO_DEVOLUCIONES = "devoluciones.json";
        private const string ARCHIVO_BIBLIOTECARIOS = "bibliotecarios.json";
        private const string ARCHIVO_AUTORES = "autores.json";
        private const string ARCHIVO_CATEGORIAS = "categorias.json";
        private const string ARCHIVO_EDITORIALES = "editoriales.json";
        private const string ARCHIVO_HISTORIAL = "historial.json";
        private const string ARCHIVO_VENTAS = "ventas.json";
        private const string ARCHIVO_UBICACIONES = "ubicaciones.json";
        private const string ARCHIVO_PAISES = "paises.json";

        public List<Usuario> Usuarios { get; private set; }
        public List<Libro> Libros { get; private set; }
        public List<Prestamo> Prestamos { get; private set; }
        public List<Devolucion> Devoluciones { get; private set; }
        public List<Bibliotecario> Bibliotecarios { get; private set; }
        public List<Autor> Autores { get; private set; }
        public List<Categoria> Categorias { get; private set; }
        public List<Editorial> Editoriales { get; private set; }
        public List<Historial> HistorialAcciones { get; private set; }
        public List<VentaLibros> Ventas { get; private set; }
        public List<Ubicacion> Ubicaciones { get; private set; }
        public List<Pais> Paises { get; private set; }

        private DataManager()
        {
            CargarTodosLosDatos();
        }

        public void CargarTodosLosDatos()
        {
            Usuarios = JsonHelper.CargarJson<Usuario>(ARCHIVO_USUARIOS);
            Libros = JsonHelper.CargarJson<Libro>(ARCHIVO_LIBROS);
            Prestamos = JsonHelper.CargarJson<Prestamo>(ARCHIVO_PRESTAMOS);
            Devoluciones = JsonHelper.CargarJson<Devolucion>(ARCHIVO_DEVOLUCIONES);
            Bibliotecarios = JsonHelper.CargarJson<Bibliotecario>(ARCHIVO_BIBLIOTECARIOS);
            Autores = JsonHelper.CargarJson<Autor>(ARCHIVO_AUTORES);
            Categorias = JsonHelper.CargarJson<Categoria>(ARCHIVO_CATEGORIAS);
            Editoriales = JsonHelper.CargarJson<Editorial>(ARCHIVO_EDITORIALES);
            HistorialAcciones = JsonHelper.CargarJson<Historial>(ARCHIVO_HISTORIAL);
            Ventas = JsonHelper.CargarJson<VentaLibros>(ARCHIVO_VENTAS);
            Ubicaciones = JsonHelper.CargarJson<Ubicacion>(ARCHIVO_UBICACIONES);
            Paises = JsonHelper.CargarJson<Pais>(ARCHIVO_PAISES);
        }

        public void GuardarTodosLosDatos()
        {
            JsonHelper.GuardarJson(Usuarios, ARCHIVO_USUARIOS);
            JsonHelper.GuardarJson(Libros, ARCHIVO_LIBROS);
            JsonHelper.GuardarJson(Prestamos, ARCHIVO_PRESTAMOS);
            JsonHelper.GuardarJson(Devoluciones, ARCHIVO_DEVOLUCIONES);
            JsonHelper.GuardarJson(Bibliotecarios, ARCHIVO_BIBLIOTECARIOS);
            JsonHelper.GuardarJson(Autores, ARCHIVO_AUTORES);
            JsonHelper.GuardarJson(Categorias, ARCHIVO_CATEGORIAS);
            JsonHelper.GuardarJson(Editoriales, ARCHIVO_EDITORIALES);
            JsonHelper.GuardarJson(HistorialAcciones, ARCHIVO_HISTORIAL);
            JsonHelper.GuardarJson(Ventas, ARCHIVO_VENTAS);
            JsonHelper.GuardarJson(Ubicaciones, ARCHIVO_UBICACIONES);
            JsonHelper.GuardarJson(Paises, ARCHIVO_PAISES);
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            usuario.Id = ObtenerProximoId(Usuarios);
            Usuarios.Add(usuario);
            JsonHelper.GuardarJson(Usuarios, ARCHIVO_USUARIOS);
            RegistrarAccion("Crear", "Usuario", usuario.Id, $"Usuario {usuario.NombreUsuario} creado");
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            var index = Usuarios.FindIndex(u => u.Id == usuario.Id);
            if (index >= 0)
            {
                Usuarios[index] = usuario;
                JsonHelper.GuardarJson(Usuarios, ARCHIVO_USUARIOS);
                RegistrarAccion("Actualizar", "Usuario", usuario.Id, $"Usuario {usuario.NombreUsuario} actualizado");
            }
        }

        public void EliminarUsuario(int id)
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                var prestamosActivos = Prestamos.Where(p => p.UsuarioId == id && p.EstadoPrestamo == "Activo").ToList();
                if (prestamosActivos.Any())
                {
                    throw new InvalidOperationException("No se puede eliminar un usuario con préstamos activos");
                }

                usuario.Activo = false;
                usuario.Estado = "Eliminado";
                ActualizarUsuario(usuario);
                RegistrarAccion("Eliminar", "Usuario", id, $"Usuario {usuario.NombreUsuario} eliminado");
            }
        }

        public Usuario BuscarUsuario(int id)
        {
            return Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public Usuario BuscarUsuarioPorNombre(string nombreUsuario)
        {
            return Usuarios.FirstOrDefault(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
        }

        public void AgregarLibro(Libro libro)
        {
            if (libro == null)
                throw new ArgumentNullException(nameof(libro));

            libro.Id = ObtenerProximoId(Libros);
            Libros.Add(libro);
            JsonHelper.GuardarJson(Libros, ARCHIVO_LIBROS);
            RegistrarAccion("Crear", "Libro", libro.Id, $"Libro {libro.Titulo} agregado");
        }

        public void ActualizarLibro(Libro libro)
        {
            if (libro == null)
                throw new ArgumentNullException(nameof(libro));

            var index = Libros.FindIndex(l => l.Id == libro.Id);
            if (index >= 0)
            {
                Libros[index] = libro;
                JsonHelper.GuardarJson(Libros, ARCHIVO_LIBROS);
                RegistrarAccion("Actualizar", "Libro", libro.Id, $"Libro {libro.Titulo} actualizado");
            }
        }

        public Libro BuscarLibro(int id)
        {
            return Libros.FirstOrDefault(l => l.Id == id);
        }

        public Libro BuscarLibroPorISBN(string isbn)
        {
            return Libros.FirstOrDefault(l => l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        public List<Libro> BuscarLibrosPorTitulo(string titulo)
        {
            return Libros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Libro> BuscarLibrosPorAutor(string autor)
        {
            return Libros.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void CrearPrestamo(int usuarioId, int libroId, int bibliotecarioId)
        {
            var usuario = BuscarUsuario(usuarioId);
            if (usuario == null)
                throw new InvalidOperationException("Usuario no encontrado");

            if (!usuario.PuedePrestar())
                throw new InvalidOperationException("El usuario no puede realizar préstamos");

            var libro = BuscarLibro(libroId);
            if (libro == null)
                throw new InvalidOperationException("Libro no encontrado");

            if (!libro.EstaDisponible())
                throw new InvalidOperationException("El libro no está disponible");

            var bibliotecario = Bibliotecarios.FirstOrDefault(b => b.Id == bibliotecarioId);
            if (bibliotecario == null)
                throw new InvalidOperationException("Bibliotecario no encontrado");

            var prestamo = new Prestamo
            {
                Id = ObtenerProximoId(Prestamos),
                UsuarioId = usuarioId,
                LibroId = libroId,
                BibliotecarioId = bibliotecarioId,
                FechaPrestamo = DateTime.Now,
                FechaVencimiento = DateTime.Now.AddDays(14),
                EstadoPrestamo = "Activo"
            };

            libro.PrestarLibro();
            usuario.RegistrarPrestamo();
            bibliotecario.RegistrarPrestamoGestionado();

            Prestamos.Add(prestamo);
            ActualizarLibro(libro);
            ActualizarUsuario(usuario);
            JsonHelper.GuardarJson(Bibliotecarios, ARCHIVO_BIBLIOTECARIOS);
            JsonHelper.GuardarJson(Prestamos, ARCHIVO_PRESTAMOS);

            RegistrarAccion("Crear", "Prestamo", prestamo.Id,
                $"Préstamo creado - Usuario: {usuario.NombreUsuario}, Libro: {libro.Titulo}");
        }

        public void DevolverPrestamo(int prestamoId, string condicionLibro, int bibliotecarioReceptorId)
        {
            var prestamo = Prestamos.FirstOrDefault(p => p.Id == prestamoId);
            if (prestamo == null)
                throw new InvalidOperationException("Préstamo no encontrado");

            if (prestamo.EstadoPrestamo == "Devuelto")
                throw new InvalidOperationException("El préstamo ya fue devuelto");

            var usuario = BuscarUsuario(prestamo.UsuarioId);
            var libro = BuscarLibro(prestamo.LibroId);

            prestamo.MarcarComoDevuelto(condicionLibro);

            var devolucion = new Devolucion
            {
                Id = ObtenerProximoId(Devoluciones),
                PrestamoId = prestamoId,
                UsuarioId = prestamo.UsuarioId,
                LibroId = prestamo.LibroId,
                FechaDevolucion = DateTime.Now,
                CondicionLibro = condicionLibro,
                MultaAplicada = prestamo.MultaAcumulada,
                BibliotecarioReceptorId = bibliotecarioReceptorId
            };

            libro.DevolverLibro();
            usuario.RegistrarDevolucion();

            if (prestamo.MultaAcumulada > 0)
            {
                usuario.AplicarMulta(prestamo.MultaAcumulada);
            }

            Devoluciones.Add(devolucion);
            ActualizarLibro(libro);
            ActualizarUsuario(usuario);
            JsonHelper.GuardarJson(Prestamos, ARCHIVO_PRESTAMOS);
            JsonHelper.GuardarJson(Devoluciones, ARCHIVO_DEVOLUCIONES);

            RegistrarAccion("Devolucion", "Prestamo", prestamo.Id,
                $"Préstamo devuelto - Condición: {condicionLibro}, Multa: L. {prestamo.MultaAcumulada:F2}");
        }

        public void RenovarPrestamo(int prestamoId)
        {
            var prestamo = Prestamos.FirstOrDefault(p => p.Id == prestamoId);
            if (prestamo == null)
                throw new InvalidOperationException("Préstamo no encontrado");

            prestamo.Renovar();
            JsonHelper.GuardarJson(Prestamos, ARCHIVO_PRESTAMOS);

            RegistrarAccion("Renovar", "Prestamo", prestamo.Id,
                $"Préstamo renovado - Nueva fecha vencimiento: {prestamo.FechaVencimiento:dd/MM/yyyy}");
        }

        private int ObtenerProximoId<T>(List<T> lista) where T : EntidadBase
        {
            if (lista == null || lista.Count == 0)
                return 1;
            return lista.Max(item => item.Id) + 1;
        }

        private void RegistrarAccion(string tipoAccion, string tabla, int registroId, string descripcion)
        {
            var historial = new Historial
            {
                Id = ObtenerProximoId(HistorialAcciones),
                TipoAccion = tipoAccion,
                TablaAfectada = tabla,
                RegistroAfectadoId = registroId,
                Descripcion = descripcion,
                FechaAccion = DateTime.Now,
                UsuarioId = 0
            };

            HistorialAcciones.Add(historial);
            JsonHelper.GuardarJson(HistorialAcciones, ARCHIVO_HISTORIAL);
        }

        public Dictionary<string, int> ObtenerEstadisticas()
        {
            return new Dictionary<string, int>
            {
                { "TotalUsuarios", Usuarios.Count(u => u.Activo) },
                { "TotalLibros", Libros.Count(l => l.Activo) },
                { "LibrosDisponibles", Libros.Count(l => l.EstaDisponible()) },
                { "PrestamosActivos", Prestamos.Count(p => p.EstadoPrestamo == "Activo") },
                { "PrestamosVencidos", Prestamos.Count(p => p.EstadoPrestamo == "Vencido") },
                { "TotalBibliotecarios", Bibliotecarios.Count(b => b.Activo) },
                { "TotalAutores", Autores.Count(a => a.Activo) },
                { "TotalCategorias", Categorias.Count(c => c.Activo) },
                { "VentasMes", Ventas.Count(v => v.FechaVenta.Month == DateTime.Now.Month) }
            };
        }

        public List<Prestamo> ObtenerPrestamosVencidos()
        {
            foreach (var prestamo in Prestamos.Where(p => p.EstadoPrestamo != "Devuelto"))
            {
                prestamo.ActualizarEstado();
            }

            return Prestamos.Where(p => p.EstadoPrestamo == "Vencido").ToList();
        }

        public List<Usuario> ObtenerUsuariosConMultas()
        {
            return Usuarios.Where(u => u.MultasPendientes > 0).ToList();
        }

        public List<Libro> ObtenerLibrosMasPrestados(int top = 10)
        {
            var librosPrestados = Prestamos
                .GroupBy(p => p.LibroId)
                .Select(g => new { LibroId = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .Take(top)
                .ToList();

            var libros = new List<Libro>();
            foreach (var item in librosPrestados)
            {
                var libro = BuscarLibro(item.LibroId);
                if (libro != null)
                    libros.Add(libro);
            }

            return libros;
        }

        public void CrearBackupCompleto()
        {
            JsonHelper.CrearBackup(ARCHIVO_USUARIOS);
            JsonHelper.CrearBackup(ARCHIVO_LIBROS);
            JsonHelper.CrearBackup(ARCHIVO_PRESTAMOS);
            JsonHelper.CrearBackup(ARCHIVO_DEVOLUCIONES);
            JsonHelper.CrearBackup(ARCHIVO_BIBLIOTECARIOS);
            JsonHelper.CrearBackup(ARCHIVO_AUTORES);
            JsonHelper.CrearBackup(ARCHIVO_CATEGORIAS);
            JsonHelper.CrearBackup(ARCHIVO_EDITORIALES);
            JsonHelper.CrearBackup(ARCHIVO_HISTORIAL);
            JsonHelper.CrearBackup(ARCHIVO_VENTAS);
            JsonHelper.CrearBackup(ARCHIVO_UBICACIONES);
            JsonHelper.CrearBackup(ARCHIVO_PAISES);
        }
    }
}