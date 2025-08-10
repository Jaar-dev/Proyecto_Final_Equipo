using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class VentaLibros : EntidadBase
    {
        private int _libroId;
        private int _cantidad;
        private decimal _precioUnitario;
        private decimal _total;
        private string _cliente;
        private DateTime _fechaVenta;
        private string _metodoPago;
        private string _estadoVenta;

        public int LibroId { get; set; }
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La cantidad debe ser mayor que cero");
                _cantidad = value;
            }
        }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public string MetodoPago { get; set; }
        public string EstadoVenta { get; set; }

        public VentaLibros() : base()
        {
            _fechaVenta = DateTime.Now;
            _estadoVenta = "Completada";
        }

        public override bool Validar()
        {
            return _libroId > 0 && _cantidad > 0 && _precioUnitario > 0;
        }

        public override string ObtenerInformación()
        {
            return $"Venta #{Id}\n" +
                   $"Cliente: {Cliente}\n" +
                   $"Cantidad: {Cantidad}\n" +
                   $"Total: L. {Total:F2}";
        }

        public void CalcularTotal()
        {
            Total = Cantidad * PrecioUnitario;
        }
    }
}