using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Editorial : EntidadBase
    {
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _correo;
        private string _pais;
        private int _añoFundacion;
        private string _sitioWeb;
        private int _librosPublicados;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de la editorial no puede estar vacío");
                _nombre = value;
            }
        }

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección no puede estar vacía");
                _direccion = value;
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (!Regex.IsMatch(value, @"^\d{4}-\d{4}$"))
                    throw new ArgumentException("Formato de teléfono inválido. Use: ####-####");
                _telefono = value;
            }
        }

        public string Correo
        {
            get { return _correo; }
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ArgumentException("Formato de correo electrónico inválido");
                _correo = value;
            }
        }

        public string Pais
        {
            get { return _pais; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El país no puede estar vacío");
                _pais = value;
            }
        }

        public int AñoFundacion
        {
            get { return _añoFundacion; }
            set
            {
                if (value < 1450 || value > DateTime.Now.Year)
                    throw new ArgumentException($"El año de fundación debe estar entre 1450 y {DateTime.Now.Year}");
                _añoFundacion = value;
            }
        }

        public string SitioWeb
        {
            get { return _sitioWeb; }
            set { _sitioWeb = value; }
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

        public Editorial() : base()
        {
            _librosPublicados = 0;
            _añoFundacion = DateTime.Now.Year;
        }

        public int AnosOperacion
        {
            get { return DateTime.Now.Year - _añoFundacion; }
        }

        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre)) return false;
                if (string.IsNullOrWhiteSpace(Direccion)) return false;
                if (string.IsNullOrWhiteSpace(Telefono)) return false;
                if (string.IsNullOrWhiteSpace(Correo)) return false;
                if (string.IsNullOrWhiteSpace(Pais)) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Editorial: {Nombre}\n" +
                   $"País: {Pais}\n" +
                   $"Fundación: {AñoFundacion} ({AnosOperacion} años)\n" +
                   $"Libros Publicados: {LibrosPublicados}\n" +
                   $"Contacto: {Telefono}";
        }

        public void AgregarPublicacion()
        {
            _librosPublicados++;
            ActualizarFechaModificación();
        }
    }
}
