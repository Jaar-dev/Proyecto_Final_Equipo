using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Bibliotecario : Persona
    {
        private string _codigoEmpleado;
        private string _turno;
        private decimal _salario;
        private DateTime _fechaContratacion;
        private string _departamento;
        private int _prestamosGestionados;
        private string _especialidad;
        private string _nivelAcceso;

        public string CodigoEmpleado
        {
            get { return _codigoEmpleado; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código de empleado no puede estar vacío");
                _codigoEmpleado = value;
            }
        }

        public string Turno
        {
            get { return _turno; }
            set
            {
                if (value != "Matutino" && value != "Vespertino" && value != "Nocturno")
                    throw new ArgumentException("El turno debe ser: Matutino, Vespertino o Nocturno");
                _turno = value;
            }
        }

        public decimal Salario
        {
            get { return _salario; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El salario no puede ser negativo");
                if (value < 9000)
                    throw new ArgumentException("El salario no puede ser menor al mínimo");
                _salario = value;
            }
        }

        public DateTime FechaContratacion
        {
            get { return _fechaContratacion; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("La fecha de contratación no puede ser futura");
                _fechaContratacion = value;
            }
        }

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }

        public int PrestamosGestionados
        {
            get { return _prestamosGestionados; }
            set { _prestamosGestionados = value; }
        }

        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public string NivelAcceso
        {
            get { return _nivelAcceso; }
            set
            {
                if (value != "Básico" && value != "Intermedio" && value != "Avanzado" && value != "Administrador")
                    throw new ArgumentException("Nivel de acceso inválido");
                _nivelAcceso = value;
            }
        }

        public Bibliotecario() : base()
        {
            _fechaContratacion = DateTime.Now;
            _prestamosGestionados = 0;
            _turno = "Matutino";
            _nivelAcceso = "Básico";
            _salario = 9000;
        }

        public int AnosServicio
        {
            get
            {
                return DateTime.Now.Year - _fechaContratacion.Year;
            }
        }

        public decimal BonoAntiguedad
        {
            get
            {
                return AnosServicio * 500;
            }
        }

        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre)) return false;
                if (string.IsNullOrWhiteSpace(Apellido)) return false;
                if (string.IsNullOrWhiteSpace(CodigoEmpleado)) return false;
                if (string.IsNullOrWhiteSpace(Correo)) return false;
                if (_salario < 9000) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Bibliotecario: {NombreCompleto}\n" +
                   $"Código: {CodigoEmpleado}\n" +
                   $"Turno: {Turno}\n" +
                   $"Años de Servicio: {AnosServicio}\n" +
                   $"Préstamos Gestionados: {PrestamosGestionados}";
        }

        public void RegistrarPrestamoGestionado()
        {
            _prestamosGestionados++;
            ActualizarFechaModificación();
        }

        public bool PuedeAutorizarPrestamo()
        {
            return Activo && (_nivelAcceso != "Básico");
        }

        public decimal CalcularSalarioTotal()
        {
            return _salario + BonoAntiguedad;
        }
    }
}