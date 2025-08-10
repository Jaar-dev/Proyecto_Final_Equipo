using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Historial : EntidadBase
    {
        private int _usuarioId;
        private string _tipoAccion;
        private string _descripcion;
        private DateTime _fechaAccion;
        private string _tablaAfectada;
        private int _registroAfectadoId;
        private string _valorAnterior;
        private string _valorNuevo;

        public int UsuarioId { get; set; }
        public string TipoAccion { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaAccion { get; set; }
        public string TablaAfectada { get; set; }
        public int RegistroAfectadoId { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }

        public Historial() : base()
        {
            _fechaAccion = DateTime.Now;
        }

        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(TipoAccion) &&
                   !string.IsNullOrWhiteSpace(Descripcion);
        }

        public override string ObtenerInformación()
        {
            return $"Acción: {TipoAccion}\n" +
                   $"Fecha: {FechaAccion:dd/MM/yyyy HH:mm}\n" +
                   $"Descripción: {Descripcion}";
        }
    }
}
