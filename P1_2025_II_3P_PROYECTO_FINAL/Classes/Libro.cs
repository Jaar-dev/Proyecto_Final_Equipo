using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Libro : EntidadBase
    {
        private string _isbn;
        private string _titulo;
        private string _autor;
        private string _editorial;
        private int _añoPublicacion;
        private string _categoria;
        private int _cantidadDisponible;
        private int _cantidadTotal;
        private decimal _precio;
        private string _ubicacion;
        private string _idioma;
        private int _numeroPaginas;
        private string _edicion;

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                if (!ValidarISBN(value))
                    throw new ArgumentException("Formato de ISBN inválido");
                _isbn = value;
            }
        }

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El título no puede estar vacío");
                if (value.Length > 200)
                    throw new ArgumentException("El título no puede exceder 200 caracteres");
                _titulo = value;
            }
        }

        public string Autor
        {
            get { return _autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El autor no puede estar vacío");
                _autor = value;
            }
        }

        public string Editorial
        {
            get { return _editorial; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La editorial no puede estar vacía");
                _editorial = value;
            }
        }

        public int AñoPublicacion
        {
            get { return _añoPublicacion; }
            set
            {
                if (value < 1450 || value > DateTime.Now.Year)
                    throw new ArgumentException($"El año de publicación debe estar entre 1450 y {DateTime.Now.Year}");
                _añoPublicacion = value;
            }
        }

        public string Categoria
        {
            get { return _categoria; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La categoría no puede estar vacía");
                _categoria = value;
            }
        }

        public int CantidadDisponible
        {
            get { return _cantidadDisponible; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad disponible no puede ser negativa");
                if (value > _cantidadTotal)
                    throw new ArgumentException("La cantidad disponible no puede ser mayor que la cantidad total");
                _cantidadDisponible = value;
            }
        }

        public int CantidadTotal
        {
            get { return _cantidadTotal; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad total no puede ser negativa");
                _cantidadTotal = value;
            }
        }

        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("El precio no puede ser negativo");
                _precio = value;
            }
        }

        public string Ubicacion
        {
            get { return _ubicacion; }
            set { _ubicacion = value; }
        }

        public string Idioma
        {
            get { return _idioma; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El idioma no puede estar vacío");
                _idioma = value;
            }
        }

        public int NumeroPaginas
        {
            get { return _numeroPaginas; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El número de páginas debe ser mayor que cero");
                _numeroPaginas = value;
            }
        }

        public string Edicion
        {
            get { return _edicion; }
            set { _edicion = value; }
        }

        public Libro() : base()
        {
            _cantidadDisponible = 0;
            _cantidadTotal = 0;
            _precio = 0;
            _idioma = "Español";
            _añoPublicacion = DateTime.Now.Year;
        }

        private bool ValidarISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) return false;
            string cleanISBN = isbn.Replace("-", "").Replace(" ", "");
            return cleanISBN.Length == 13 && long.TryParse(cleanISBN, out _);
        }

        public override bool Validar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ISBN)) return false;
                if (string.IsNullOrWhiteSpace(Titulo)) return false;
                if (string.IsNullOrWhiteSpace(Autor)) return false;
                if (string.IsNullOrWhiteSpace(Editorial)) return false;
                if (_cantidadTotal < 0) return false;
                if (_cantidadDisponible < 0 || _cantidadDisponible > _cantidadTotal) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ObtenerInformación()
        {
            return $"Libro: {Titulo}\n" +
                   $"Autor: {Autor}\n" +
                   $"ISBN: {ISBN}\n" +
                   $"Editorial: {Editorial} ({AñoPublicacion})\n" +
                   $"Disponibles: {CantidadDisponible}/{CantidadTotal}\n" +
                   $"Precio: L. {Precio:F2}";
        }

        public bool EstaDisponible()
        {
            return _cantidadDisponible > 0 && Activo;
        }

        public void PrestarLibro()
        {
            if (!EstaDisponible())
                throw new InvalidOperationException("El libro no está disponible para préstamo");
            _cantidadDisponible--;
            ActualizarFechaModificación();
        }

        public void DevolverLibro()
        {
            if (_cantidadDisponible >= _cantidadTotal)
                throw new InvalidOperationException("No se pueden devolver más libros de los que existen");
            _cantidadDisponible++;
            ActualizarFechaModificación();
        }

        public decimal CalcularValorInventario()
        {
            return _cantidadTotal * _precio;
        }

        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - _añoPublicacion;
        }
    }
}
