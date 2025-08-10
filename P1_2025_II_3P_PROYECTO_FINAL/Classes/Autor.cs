using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Autor : Persona
    {
        private string _nacionalidad;
        private string _biografia;
        private int _librosPublicados;
        private string _generoLiterario;
        private string _premios;
        private string _sitioWeb;
        private new bool _activo;
        private string _pseudonimo;

        public Autor() : base()
        {
            _librosPublicados = 0;
            _activo = true;
            _generoLiterario = "Ficción";
        }

        public string Nacionalidad
        {
            get => _nacionalidad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La nacionalidad no puede estar vacía.");
                _nacionalidad = value;
            }
        }

        public string Biografia
        {
            get => _biografia;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 30)
                    throw new ArgumentException("La biografía debe tener al menos 30 caracteres.");
                _biografia = value;
            }
        }

        public int LibrosPublicados
        {
            get => _librosPublicados;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El número de libros publicados no puede ser negativo.");
                _librosPublicados = value;
            }
        }

        public string GeneroLiterario
        {
            get => _generoLiterario;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El género literario no puede estar vacío.");
                _generoLiterario = value;
            }
        }

        public string Premios
        {
            get => _premios;
            set => _premios = value;
        }

        public string SitioWeb
        {
            get => _sitioWeb;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !Uri.IsWellFormedUriString(value, UriKind.Absolute))
                    throw new ArgumentException("El sitio web no tiene un formato válido.");
                _sitioWeb = value;
            }
        }

        public bool AutorActivo
        {
            get => _activo;
            set => _activo = value;
        }

        public string Pseudonimo
        {
            get => _pseudonimo;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value == NombreCompleto)
                    throw new ArgumentException("El pseudónimo no puede ser igual al nombre completo.");
                _pseudonimo = value;
            }
        }
        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre)) return false; 
                if (string.IsNullOrWhiteSpace(Apellido)) return false; 
                if (string.IsNullOrWhiteSpace(Nacionalidad)) return false; 
                if (string.IsNullOrWhiteSpace(GeneroLiterario)) return false;
                if (LibrosPublicados < 0) return false; 
                if (!string.IsNullOrWhiteSpace(SitioWeb) && !Uri.IsWellFormedUriString(SitioWeb, UriKind.Absolute)) return false;
                if (!string.IsNullOrWhiteSpace(Pseudonimo) && Pseudonimo == NombreCompleto) return false; 
                if (!string.IsNullOrWhiteSpace(Biografia) && Biografia.Length < 30) return false; 
             
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            string nombreMostrar = !string.IsNullOrWhiteSpace(Pseudonimo) ? Pseudonimo : NombreCompleto;
            return $"Autor: {nombreMostrar}\n" +
                   $"Nacionalidad: {Nacionalidad}\n" +
                   $"Género: {GeneroLiterario}\n" +
                   $"Libros Publicados: {LibrosPublicados}\n" +
                   $"Estado: {(AutorActivo ? "Activo" : "Inactivo")}";
        }

        public void AgregarLibro()
        {
            _librosPublicados++;
            ActualizarFechaModificación();
        }

        public string ObtenerNombrePublicacion()
        {
            return !string.IsNullOrWhiteSpace(Pseudonimo) ? Pseudonimo : NombreCompleto;
        }
    }
}
