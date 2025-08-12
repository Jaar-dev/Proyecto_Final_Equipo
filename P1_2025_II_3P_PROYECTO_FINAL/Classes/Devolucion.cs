using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public class Devolucion : EntidadBase
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
            get => _prestamoId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del préstamo debe ser mayor que cero");
                _prestamoId = value;
            }
        }
        public int UsuarioId
        {
            get => _usuarioId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del usuario debe ser mayor que cero");
                _usuarioId = value;
            }
        }
        public int LibroId
        {
            get => _libroId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del libro debe ser mayor que cero");
                _libroId = value;
            }
        }

        public DateTime FechaDevolucion
        {
            get => _fechaDevolucion;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de devolución no puede ser futura");
                _fechaDevolucion = value;
            }
        }

        public string CondicionLibro
        {
            get => _condicionLibro;
            set
            {
                var condicionesValidas = new[] { "Excelente", "Bueno", "Regular", "Malo", "Perdido" };
                if (!condicionesValidas.Contains(value))
                    throw new ArgumentException("Condición del libro inválida");
                _condicionLibro = value;
            }
        }

        public decimal MultaAplicada
        {
            get => _multaAplicada;
            set
            {
                if (value < 0 || value > 1000)
                    throw new ArgumentException("La multa debe estar entre 0 y 1000 lempiras");
                _multaAplicada = value;
            }
        }

        public string ObservacionesDevolucion
        {
            get => _observacionesDevolucion;
            set
            {
                if (value.Length > 250)
                    throw new ArgumentException("Las observaciones no deben exceder 250 caracteres");
                _observacionesDevolucion = value;
            }
        }

        public int BibliotecarioReceptorId
        {
            get => _bibliotecarioReceptorId;
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
            _observacionesDevolucion = string.Empty;
        }

        public override bool Validar()
        {
            return _prestamoId > 0 &&
                   _usuarioId > 0 &&
                   _libroId > 0 &&
                   _bibliotecarioReceptorId > 0 &&
                   _fechaDevolucion <= DateTime.Now &&
                   !string.IsNullOrWhiteSpace(_condicionLibro) &&
                   _multaAplicada >= 0 &&
                   _observacionesDevolucion.Length <= 250;
        }

        public override string ObtenerInformación()
        {
            return $"Devolución #{Id}\n" +
                   $"Préstamo ID: {PrestamoId}\n" +
                   $"Usuario ID: {UsuarioId}\n" +
                   $"Libro ID: {LibroId}\n" +
                   $"Fecha Devolución: {FechaDevolucion:dd/MM/yyyy}\n" +
                   $"Condición: {CondicionLibro}\n" +
                   $"Multa Aplicada: L. {MultaAplicada:F2}\n" +
                   $"Observaciones: {ObservacionesDevolucion}";
        }

        public decimal CalcularMultaPorCondicion()
        {
            switch (CondicionLibro)
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
            MultaAplicada = multaPorRetraso + CalcularMultaPorCondicion();
            ActualizarFechaModificación();
        }
    }
}
