using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class EntidadBase
    {
        protected int _id;
        protected DateTime _fechaCreación;
        protected DateTime _fechaModificación;
        protected bool _activo;
        protected string _creadoPor;
        protected string _modificadoPor;
        protected string _observaciones;
        protected string _estado;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID debe ser mayor que cero");
                _id = value;
            }
        }

        public DateTime FechaCreación
        {
            get { return _fechaCreación; }
            set { _fechaCreación = value; }
        }

        public DateTime FechaModificación
        {
            get { return _fechaModificación; }
            set { _fechaModificación = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string CreadoPor
        {
            get { return _creadoPor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El campo 'Creado Por' no puede estar vacío");
                _creadoPor = value;
            }
        }

        public string ModificadoPor
        {
            get { return _modificadoPor; }
            set { _modificadoPor = value; }
        }

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public EntidadBase()
        {
            _fechaCreación = DateTime.Now;
            _fechaModificación = DateTime.Now;
            _activo = true;
            _estado = "Activo";
            _creadoPor = "Sistema";
        }

        public abstract bool Validar();
        public abstract string ObtenerInformación();

        public virtual void ActualizarFechaModificación()
        {
            _fechaModificación = DateTime.Now;
        }

        public virtual string ConvertirAJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}