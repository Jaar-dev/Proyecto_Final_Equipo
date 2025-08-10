using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Categoria : EntidadBase
    {
        private string _nombre;
        private string _descripcion;
        private string _codigoCategoria;
        private int _librosEnCategoria;
        private string _ubicacionEstanteria;
        private int _prestamosCategoria;
        private string _nivelDemanda;
        private bool _paraAdultos;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de la categoría no puede estar vacío");
                if (value.Length > 50)
                    throw new ArgumentException("El nombre no puede exceder 50 caracteres");
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string CodigoCategoria
        {
            get { return _codigoCategoria; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El código de categoría no puede estar vacío");
                if (!Regex.IsMatch(value, @"^[A-Z]{3}\d{3}$"))
                    throw new ArgumentException("El código debe tener el formato: AAA000");
                _codigoCategoria = value;
            }
        }

        public int LibrosEnCategoria
        {
            get { return _librosEnCategoria; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El número de libros no puede ser negativo");
                _librosEnCategoria = value;
            }
        }

        public string UbicacionEstanteria
        {
            get { return _ubicacionEstanteria; }
            set { _ubicacionEstanteria = value; }
        }

        public int PrestamosCategoria
        {
            get { return _prestamosCategoria; }
            set { _prestamosCategoria = value; }
        }

        public string NivelDemanda
        {
            get { return _nivelDemanda; }
            set
            {
                if (value != "Alta" && value != "Media" && value != "Baja")
                    throw new ArgumentException("El nivel de demanda debe ser: Alta, Media o Baja");
                _nivelDemanda = value;
            }
        }

        public bool ParaAdultos
        {
            get { return _paraAdultos; }
            set { _paraAdultos = value; }
        }

        public Categoria() : base()
        {
            _librosEnCategoria = 0;
            _prestamosCategoria = 0;
            _nivelDemanda = "Media";
            _paraAdultos = false;
        }

        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Nombre)) return false;
                if (string.IsNullOrWhiteSpace(CodigoCategoria)) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Categoría: {Nombre}\n" +
                   $"Código: {CodigoCategoria}\n" +
                   $"Libros: {LibrosEnCategoria}\n" +
                   $"Demanda: {NivelDemanda}\n" +
                   $"Ubicación: {UbicacionEstanteria}";
        }

        public void AgregarLibro()
        {
            _librosEnCategoria++;
            ActualizarFechaModificación();
        }

        public void QuitarLibro()
        {
            if (_librosEnCategoria > 0)
            {
                _librosEnCategoria--;
                ActualizarFechaModificación();
            }
        }

        public void RegistrarPrestamo()
        {
            _prestamosCategoria++;
            ActualizarNivelDemanda();
        }

        private void ActualizarNivelDemanda()
        {
            if (_prestamosCategoria > 100)
                _nivelDemanda = "Alta";
            else if (_prestamosCategoria > 50)
                _nivelDemanda = "Media";
            else
                _nivelDemanda = "Baja";
        }
    }
}
