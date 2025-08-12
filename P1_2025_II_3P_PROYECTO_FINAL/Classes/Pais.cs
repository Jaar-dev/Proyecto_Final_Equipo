using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public class Pais : EntidadBase
    {
        private string _nombre;
        private string _codigo;
        private string _continente;
        private string _idiomaPrincipal;
        private string _capital;
        private long _poblacion;
        private decimal _pib;
        private string _moneda;

        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Continente { get; set; }
        public string IdiomaPrincipal { get; set; }
        public string Capital { get; set; }
        public long Poblacion { get; set; }
        public decimal PIB { get; set; }
        public string Moneda { get; set; }

        public Pais() : base()
        {
        }

        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Nombre) &&
                   !string.IsNullOrWhiteSpace(Codigo);
        }

        public override string ObtenerInformación()
        {
            return $"País: {Nombre} ({Codigo})\n" +
                   $"Continente: {Continente}\n" +
                   $"Capital: {Capital}\n" +
                   $"Idioma: {IdiomaPrincipal}";
        }
    }
}
