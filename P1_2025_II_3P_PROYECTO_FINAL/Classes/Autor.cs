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

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La nacionalidad no puede estar vacía");
                _nacionalidad = value;
            }
        }

        public string Biografia
        {
            get { return _biografia; }
            set { _biografia = value; }
        }

        public int LibrosPublicados
        {
            get { return _librosPublicados; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El número de libros publicados no puede ser negativo");
                _librosPublicados = value;
            }
        }

        public string GeneroLiterario
        {
            get { return _generoLiterario; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El género literario no puede estar vacío");
                _generoLiterario = value;
            }
        }

        public string Premios
        {
            get { return _premios; }
            set { _premios = value; }
        }

        public string SitioWeb
        {
            get { return _sitioWeb; }
            set { _sitioWeb = value; }
        }

        public bool AutorActivo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string Pseudonimo
        {
            get { return _pseudonimo; }
            set { _pseudonimo = value; }
        }

        public Autor() : base()
        {
            _librosPublicados = 0;
            _activo = true;
            _generoLiterario = "Ficción";
        }

        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre)) return false;
                if (string.IsNullOrWhiteSpace(Apellido)) return false;
                if (string.IsNullOrWhiteSpace(Nacionalidad)) return false;
                if (string.IsNullOrWhiteSpace(GeneroLiterario)) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            string nombreMostrar = !string.IsNullOrWhiteSpace(_pseudonimo) ? _pseudonimo : NombreCompleto;
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
            return !string.IsNullOrWhiteSpace(_pseudonimo) ? _pseudonimo : NombreCompleto;
        }
    }
}
