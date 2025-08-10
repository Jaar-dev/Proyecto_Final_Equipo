using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Devolucion : EntidadBase
    {
        private int _prestamoId;
        private int _usuarioId;
        private int _libroId;
        private DateTime _fechaDevolucion;
        private string _condicionLibro;
        private decimal _multaAplicada;
        private string _observacionesDevolucion;
        private int _bibliotecarioReceptorId;

        public int PrestamoId
        {
            get { return _prestamoId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del préstamo debe ser mayor que cero");
                _prestamoId = value;
            }
        }

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

        public DateTime FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de devolución no puede ser futura");
                _fechaDevolucion = value;
            }
        }

        public string CondicionLibro
        {
            get { return _condicionLibro; }
            set
            {
                if (value != "Excelente" && value != "Bueno" && value != "Regular" && value != "Malo" && value != "Perdido")
                    throw new ArgumentException("Condición del libro inválida");
                _condicionLibro = value;
            }
        }

        public decimal MultaAplicada
        {
            get { return _multaAplicada; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La multa no puede ser negativa");
                _multaAplicada = value;
            }
        }

        public string ObservacionesDevolucion
        {
            get { return _observacionesDevolucion; }
            set { _observacionesDevolucion = value; }
        }

        public int BibliotecarioReceptorId
        {
            get { return _bibliotecarioReceptorId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del bibliotecario receptor debe ser mayor que cero");
                _bibliotecarioReceptorId = value;
            }
        }

        public Devolucion() : base()
        {
            _fechaDevolucion = DateTime.Now;
            _condicionLibro = "Bueno";
            _multaAplicada = 0;
        }

        public override bool Validar()
        {
            try
            {
                if (_prestamoId <= 0) return false;
                if (_usuarioId <= 0) return false;
                if (_libroId <= 0) return false;
                if (_bibliotecarioReceptorId <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Devolución #{Id}\n" +
                   $"Préstamo ID: {PrestamoId}\n" +
                   $"Usuario ID: {UsuarioId}\n" +
                   $"Libro ID: {LibroId}\n" +
                   $"Fecha Devolución: {FechaDevolucion:dd/MM/yyyy}\n" +
                   $"Condición: {CondicionLibro}\n" +
                   $"Multa Aplicada: L. {MultaAplicada:F2}";
        }

        public decimal CalcularMultaPorCondicion()
        {
            switch (_condicionLibro)
            {
                case "Malo":
                    return 50;
                case "Perdido":
                    return 500;
                default:
                    return 0;
            }
        }

        public void ProcesarDevolucion(decimal multaPorRetraso)
        {
            _multaAplicada = multaPorRetraso + CalcularMultaPorCondicion();
            ActualizarFechaModificación();
        }
    }
}
