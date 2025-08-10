using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Persona : EntidadBase
    {
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _correo;
        private string _direccion;
        private string _identificacion;
        private DateTime _fechaNacimiento;
        private string _genero;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                if (value.Length < 5)
                    throw new ArgumentException("El nombre debe tener al menos 5 caracteres.");
                if (value.Length > 40)
                    throw new ArgumentException("El nombre no puede exceder 40 caracteres.");
                if (!Regex.IsMatch(value, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
                    throw new ArgumentException("El nombre solo puede contener letras y espacios.");
                _nombre = value.Trim();
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El apellido no puede estar vacío");
                if (value.Length < 3 || value.Length > 50)
                    throw new ArgumentException("El apellido debe tener entre 3 y 50 caracteres");
                _apellido = value;
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (!ValidarTelefono(value))
                    throw new ArgumentException("Formato de teléfono inválido. Use: ####-####");
                _telefono = value;
            }
        }

        public string Correo
        {
            get { return _correo; }
            set
            {
                if (!ValidarCorreo(value))
                    throw new ArgumentException("Formato de correo electrónico inválido");
                _correo = value;
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

        public string Identificacion
        {
            get { return _identificacion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La identidad no puede estar vacía.");
                string limpia = Regex.Replace(value ?? "", @"[^\d]", "");
                if (limpia.Length != 13)
                    throw new ArgumentException("La identidad debe contener exactamente 13 dígitos numéricos.");
                _identificacion = value;
            }
        }
            
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");

                if (value < new DateTime(1900, 1, 1))
                    throw new ArgumentException("La fecha de nacimiento no puede ser anterior al año 1900.");

                int edadCalculada = DateTime.Now.Year - value.Year;
                if (DateTime.Now < value.AddYears(edadCalculada))
                    edadCalculada--;

                if (edadCalculada < 7)
                    throw new ArgumentException("La persona debe tener al menos 7 años de edad.");

                if (edadCalculada > 90)
                    throw new ArgumentException("La edad no puede ser mayor a 90 años.");
                _fechaNacimiento = value;
            }
        }

        public string Genero
        {
            get { return _genero; }
            set
            {
                if (value != "Masculino" && value != "Femenino" && value != "Otro")
                    throw new ArgumentException("El género debe ser: Masculino, Femenino u Otro");
                _genero = value;
            }
        }

        protected bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) return false;
            return Regex.IsMatch(telefono, @"^\d{4}-\d{4}$");
        }

        protected bool ValidarCorreo(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo)) return false;
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public int Edad
        {
            get
            {
                var edad = DateTime.Now.Year - _fechaNacimiento.Year;
                if (DateTime.Now.DayOfYear < _fechaNacimiento.DayOfYear)
                    edad--;
                return edad;
            }
        }

        public string NombreCompleto
        {
            get { return $"{_nombre} {_apellido}"; }
        }
    }
}