using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_II_3P_PROYECTO_FINAL.Clases
{
    public abstract class Ubicacion : EntidadBase
    {
        private string _estanteria;
        private int _pasillo;
        private string _seccion;
        private string _piso;
        private int _capacidadTotal;
        private int _espaciosOcupados;
        private string _tipoMaterial;
        private string _descripcionUbicacion;

        public string Estanteria { get; set; }
        public int Pasillo { get; set; }
        public string Seccion { get; set; }
        public string Piso { get; set; }
        public int CapacidadTotal { get; set; }
        public int EspaciosOcupados { get; set; }
        public string TipoMaterial { get; set; }
        public string DescripcionUbicacion { get; set; }

        public Ubicacion() : base()
        {
            _capacidadTotal = 100;
            _espaciosOcupados = 0;
        }

        public override bool Validar()
        {
            return !string.IsNullOrWhiteSpace(Estanteria) &&
                   !string.IsNullOrWhiteSpace(Seccion);
        }

        public override string ObtenerInformación()
        {
            return $"Ubicación: {Estanteria}-{Pasillo}-{Seccion}\n" +
                   $"Piso: {Piso}\n" +
                   $"Ocupación: {EspaciosOcupados}/{CapacidadTotal}";
        }

        public int EspaciosDisponibles()
        {
            return CapacidadTotal - EspaciosOcupados;
        }
    }
}