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
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de la editorial no puede estar vacío");
                if (value.Length < 3 || value.Length > 100)
                    throw new ArgumentException("El nombre debe tener entre 3 y 100 caracteres");
                _nombre = value;
            }
        }
        public string Direccion
        {
            get => _direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La dirección no puede estar vacía");
                _direccion = value;
            }
        }

        public string Telefono
        {
            get => _telefono;
            set
            {
                if (!Regex.IsMatch(value, @"^\d{4}-\d{4}$"))
                    throw new ArgumentException("Formato de teléfono inválido. Use: ####-####");
                _telefono = value;
            }
        }

        public string Correo
        {
            get => _correo;
            set
            {
                if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ArgumentException("Formato de correo electrónico inválido");
                _correo = value;
            }
        }

        public string Pais
        {
            get => _pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El país no puede estar vacío");
                _pais = value;
            }
        }

        public int AñoFundacion
        {
            get => _añoFundacion;
            set
            {
                if (value < 1450 || value > DateTime.Now.Year)
                    throw new ArgumentException($"El año de fundación debe estar entre 1450 y {DateTime.Now.Year}");
                _añoFundacion = value;
            }
        }

        public string SitioWeb
        {
            get => _sitioWeb;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.StartsWith("http"))
                    throw new ArgumentException("El sitio web debe comenzar con 'http'");
                _sitioWeb = value;
            }
        }

        public int LibrosPublicados
        {
            get => _librosPublicados;
            set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentException("El número de libros publicados debe estar entre 0 y 100,000");
                _librosPublicados = value;
            }
        }

        public Editorial() : base()
        {
            _librosPublicados = 0;
            _añoFundacion = DateTime.Now.Year;
            _sitioWeb = string.Empty;
        }
        public Editorial(string nombre, string direccion, string telefono, string correo, string pais, int añoFundacion, string sitioWeb) : base()
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
            Pais = pais;
            AñoFundacion = añoFundacion;
            SitioWeb = sitioWeb;
            LibrosPublicados = 0;
        }

        public int AnosOperacion => DateTime.Now.Year - _añoFundacion;

        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Direccion) &&
                   Regex.IsMatch(Telefono, @"^\d{4}-\d{4}$") &&
                   Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") &&
                   !string.IsNullOrWhiteSpace(Pais) &&
                   AñoFundacion >= 1450 && AñoFundacion <= DateTime.Now.Year &&
                   LibrosPublicados >= 0 && LibrosPublicados <= 100000;
        }

        public override string ObtenerInformación()
        {
            return $"Editorial: {Nombre}\n" +
                   $"País: {Pais}\n" +
                   $"Fundación: {AñoFundacion} ({AnosOperacion} años)\n" +
                   $"Libros Publicados: {LibrosPublicados}\n" +
                   $"Contacto: {Telefono}\n" +
                   $"Sitio Web: {SitioWeb}";
        }

        public void AgregarPublicacion()
        {
            LibrosPublicados++;
            ActualizarFechaModificación();
        }
    }
}