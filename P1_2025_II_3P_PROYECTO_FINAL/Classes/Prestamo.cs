using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Prestamo : EntidadBase
    {
        private int _usuarioId;
        private int _libroId;
        private int _bibliotecarioId;
        private DateTime _fechaPrestamo;
        private DateTime _fechaVencimiento;
        private DateTime? _fechaDevolucion;
        private string _estadoPrestamo;
        private decimal _multaAcumulada;
        private int _renovaciones;
        private string _condicionLibro;

        public int UsuarioId
        {
            get { return _usuarioId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del usuario debe ser mayor que cero");
                _usuarioId = value;
            }
        }

        public int LibroId
        {
            get { return _libroId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del libro debe ser mayor que cero");
                _libroId = value;
            }
        }

        public int BibliotecarioId
        {
            get { return _bibliotecarioId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del bibliotecario debe ser mayor que cero");
                _bibliotecarioId = value;
            }
        }

        public DateTime FechaPrestamo
        {
            get { return _fechaPrestamo; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de préstamo no puede ser futura");
                _fechaPrestamo = value;
            }
        }

        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set
            {
                if (value <= _fechaPrestamo)
                    throw new ArgumentException("La fecha de vencimiento debe ser posterior a la fecha de préstamo");
                _fechaVencimiento = value;
            }
        }

        public DateTime? FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set
            {
                if (value.HasValue && value < _fechaPrestamo)
                    throw new ArgumentException("La fecha de devolución no puede ser anterior a la fecha de préstamo");
                _fechaDevolucion = value;
            }
        }

        public string EstadoPrestamo
        {
            get { return _estadoPrestamo; }
            set
            {
                if (value != "Activo" && value != "Devuelto" && value != "Vencido" && value != "Renovado")
                    throw new ArgumentException("Estado de préstamo inválido");
                _estadoPrestamo = value;
            }
        }

        public decimal MultaAcumulada
        {
            get { return _multaAcumulada; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La multa no puede ser negativa");
                _multaAcumulada = value;
            }
        }

        public int Renovaciones
        {
            get { return _renovaciones; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Las renovaciones no pueden ser negativas");
                if (value > 3)
                    throw new ArgumentException("No se permiten más de 3 renovaciones");
                _renovaciones = value;
            }
        }

        public string CondicionLibro
        {
            get { return _condicionLibro; }
            set
            {
                if (value != "Excelente" && value != "Bueno" && value != "Regular" && value != "Malo")
                    throw new ArgumentException("Condición del libro inválida");
                _condicionLibro = value;
            }
        }

        public Prestamo() : base()
        {
            _fechaPrestamo = DateTime.Now;
            _fechaVencimiento = DateTime.Now.AddDays(14);
            _estadoPrestamo = "Activo";
            _multaAcumulada = 0;
            _renovaciones = 0;
            _condicionLibro = "Bueno";
        }

        public int DiasRetraso
        {
            get
            {
                if (_estadoPrestamo == "Devuelto" && _fechaDevolucion.HasValue)
                {
                    if (_fechaDevolucion.Value > _fechaVencimiento)
                        return (_fechaDevolucion.Value - _fechaVencimiento).Days;
                }
                else if (_estadoPrestamo == "Vencido")
                {
                    return (DateTime.Now - _fechaVencimiento).Days;
                }
                return 0;
            }
        }

        public decimal MultaPorRetraso
        {
            get
            {
                return DiasRetraso * 10;
            }
        }

        public override bool Validar()
        {
            try
            {
                if (_usuarioId <= 0) return false;
                if (_libroId <= 0) return false;
                if (_bibliotecarioId <= 0) return false;
                if (_fechaVencimiento <= _fechaPrestamo) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Préstamo #{Id}\n" +
                   $"Usuario ID: {UsuarioId}\n" +
                   $"Libro ID: {LibroId}\n" +
                   $"Fecha Préstamo: {FechaPrestamo:dd/MM/yyyy}\n" +
                   $"Fecha Vencimiento: {FechaVencimiento:dd/MM/yyyy}\n" +
                   $"Estado: {EstadoPrestamo}\n" +
                   $"Días de Retraso: {DiasRetraso}\n" +
                   $"Multa: L. {MultaAcumulada:F2}";
        }

        public bool PuedeRenovar()
        {
            return _renovaciones < 3 && _estadoPrestamo == "Activo" && DiasRetraso == 0;
        }

        public void Renovar()
        {
            if (!PuedeRenovar())
                throw new InvalidOperationException("No se puede renovar este préstamo");

            _renovaciones++;
            _fechaVencimiento = _fechaVencimiento.AddDays(14);
            _estadoPrestamo = "Renovado";
            ActualizarFechaModificación();
        }

        public void MarcarComoDevuelto(string condicionLibro)
        {
            if (_estadoPrestamo == "Devuelto")
                throw new InvalidOperationException("El préstamo ya fue devuelto");

            _fechaDevolucion = DateTime.Now;
            _estadoPrestamo = "Devuelto";
            _condicionLibro = condicionLibro;

            if (DiasRetraso > 0)
            {
                _multaAcumulada = MultaPorRetraso;
            }

            ActualizarFechaModificación();
        }

        public void ActualizarEstado()
        {
            if (_estadoPrestamo != "Devuelto" && DateTime.Now > _fechaVencimiento)
            {
                _estadoPrestamo = "Vencido";
                _multaAcumulada = MultaPorRetraso;
            }
        }
    }
}
