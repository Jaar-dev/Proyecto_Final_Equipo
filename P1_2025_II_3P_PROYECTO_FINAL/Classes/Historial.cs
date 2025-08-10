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
        public string TipoAccion
        {
            get => _tipoAccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El tipo de acción no puede estar vacío");
                if (value.Length < 3 || value.Length > 50)
                    throw new ArgumentException("El tipo de acción debe tener entre 3 y 50 caracteres");
                _tipoAccion = value;
            }
        }

        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La descripción no puede estar vacía");
                if (value.Length > 250)
                    throw new ArgumentException("La descripción no debe exceder 250 caracteres");
                _descripcion = value;
            }
        }

        public DateTime FechaAccion
        {
            get => _fechaAccion;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de acción no puede ser futura");
                _fechaAccion = value;
            }
        }

        public string TablaAfectada
        {
            get => _tablaAfectada;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La tabla afectada no puede estar vacía");
                _tablaAfectada = value;
            }
        }

        public int RegistroAfectadoId
        {
            get => _registroAfectadoId;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El ID del registro afectado no puede ser negativo");
                _registroAfectadoId = value;
            }
        }

        public string ValorAnterior
        {
            get => _valorAnterior;
            set => _valorAnterior = value ?? string.Empty;
        }

        public string ValorNuevo
        {
            get => _valorNuevo;
            set => _valorNuevo = value ?? string.Empty;
        }

        public Historial() : base()
        {
            _fechaAccion = DateTime.Now;
            _valorAnterior = string.Empty;
            _valorNuevo = string.Empty;
        }
        public Historial(int usuarioId, string tipoAccion, string descripcion, string tablaAfectada, int registroAfectadoId, string valorAnterior, string valorNuevo) : base()
        {
            UsuarioId = usuarioId;
            TipoAccion = tipoAccion;
            Descripcion = descripcion;
            TablaAfectada = tablaAfectada;
            RegistroAfectadoId = registroAfectadoId;
            ValorAnterior = valorAnterior ?? string.Empty;
            ValorNuevo = valorNuevo ?? string.Empty;
            FechaAccion = DateTime.Now;
        }

        public override bool Validar()
        {
            return UsuarioId > 0 &&
                   !string.IsNullOrWhiteSpace(TipoAccion) &&
                   TipoAccion.Length >= 3 && TipoAccion.Length <= 50 &&
                   !string.IsNullOrWhiteSpace(Descripcion) &&
                   Descripcion.Length <= 250 &&
                   FechaAccion <= DateTime.Now &&
                   !string.IsNullOrWhiteSpace(TablaAfectada) &&
                   RegistroAfectadoId >= 0;
        }
        public override string ObtenerInformación()
        {
            return $"Acción: {TipoAccion}\n" +
                   $"Fecha: {FechaAccion:dd/MM/yyyy HH:mm}\n" +
                   $"Descripción: {Descripcion}\n" +
                   $"Tabla: {TablaAfectada}\n" +
                   $"Registro ID: {RegistroAfectadoId}";
        }
    }
}

