using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_2025_II_3P_PROYECTO_FINAL.GUI
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {

    
        }

        private void GuardarUbicacion() { }
        private void ModificarUbicacion() { }
        private void BuscarUbicacion() { }
        private void EliminarUbicacion() { }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUbicacion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUbicacion();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUbicacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUbicacion();
        }

    }


}
