using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Usuario : Persona
    {
        private string _nombreUsuario;
        private string _contrasena;
        private int _prestamosActivos;
        private decimal _multasPendientes;
        private DateTime _fechaRegistro;
        private string _tipoUsuario;
        private int _librosPrestados;
        private string _preferenciasLectura;

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de usuario no puede estar vacío");
                if (value.Length < 4 || value.Length > 20)
                    throw new ArgumentException("El nombre de usuario debe tener entre 4 y 20 caracteres");
                _nombreUsuario = value;
            }
        }

        public string Contrasena
        {
            get { return _contrasena; }
            set
            {
                if (!ValidarContrasena(value))
                    throw new ArgumentException("La contraseña debe tener al menos 8 caracteres, una mayúscula, una minúscula y un número");
                _contrasena = value;
            }
        }

        public int PrestamosActivos
        {
            get { return _prestamosActivos; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Los préstamos activos no pueden ser negativos");
                if (value > 5)
                    throw new ArgumentException("No se pueden tener más de 5 préstamos activos");
                _prestamosActivos = value;
            }
        }

        public decimal MultasPendientes
        {
            get { return _multasPendientes; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Las multas no pueden ser negativas");
                _multasPendientes = value;
            }
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        public string TipoUsuario
        {
            get { return _tipoUsuario; }
            set
            {
                if (value != "Estudiante" && value != "Profesor" && value != "Externo" && value != "Administrativo")
                    throw new ArgumentException("Tipo de usuario inválido");
                _tipoUsuario = value;
            }
        }

        public int LibrosPrestados
        {
            get { return _librosPrestados; }
            set { _librosPrestados = value; }
        }

        public string PreferenciasLectura
        {
            get { return _preferenciasLectura; }
            set { _preferenciasLectura = value; }
        }

        public Usuario() : base()
        {
            _fechaRegistro = DateTime.Now;
            _prestamosActivos = 0;
            _multasPendientes = 0;
            _librosPrestados = 0;
            _tipoUsuario = "Estudiante";
        }

        private bool ValidarContrasena(string contrasena)
        {
            if (string.IsNullOrWhiteSpace(contrasena)) return false;
            if (contrasena.Length < 8) return false;

            bool tieneMayuscula = Regex.IsMatch(contrasena, @"[A-Z]");
            bool tieneMinuscula = Regex.IsMatch(contrasena, @"[a-z]");
            bool tieneNumero = Regex.IsMatch(contrasena, @"[0-9]");

            return tieneMayuscula && tieneMinuscula && tieneNumero;
        }

        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre)) return false;
                if (string.IsNullOrWhiteSpace(Apellido)) return false;
                if (string.IsNullOrWhiteSpace(NombreUsuario)) return false;
                if (string.IsNullOrWhiteSpace(Contrasena)) return false;
                if (string.IsNullOrWhiteSpace(Correo)) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Usuario: {NombreUsuario}\n" +
                   $"Nombre: {NombreCompleto}\n" +
                   $"Tipo: {TipoUsuario}\n" +
                   $"Préstamos Activos: {PrestamosActivos}\n" +
                   $"Multas Pendientes: L. {MultasPendientes:F2}";
        }

        public bool PuedePrestar()
        {
            return _prestamosActivos < 5 && _multasPendientes == 0 && Activo;
        }

        public void RegistrarPrestamo()
        {
            if (!PuedePrestar())
                throw new InvalidOperationException("El usuario no puede realizar préstamos");
            _prestamosActivos++;
            _librosPrestados++;
        }

        public void RegistrarDevolucion()
        {
            if (_prestamosActivos > 0)
                _prestamosActivos--;
        }

        public void AplicarMulta(decimal monto)
        {
            if (monto < 0)
                throw new ArgumentException("El monto de la multa debe ser positivo");
            _multasPendientes += monto;
        }

        public void PagarMulta(decimal monto)
        {
            if (monto < 0)
                throw new ArgumentException("El monto a pagar debe ser positivo");
            if (monto > _multasPendientes)
                throw new ArgumentException("El monto a pagar excede las multas pendientes");
            _multasPendientes -= monto;
        }
    }
}