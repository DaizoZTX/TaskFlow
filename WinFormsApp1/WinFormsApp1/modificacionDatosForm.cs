using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class modificacionDatosForm : Form
    {
        double precioHamb = 0, precioBebi = 0, porcenDesc = 0, porcenIncrem = 0;
        facturacion facSys = new facturacion();
        public modificacionDatosForm()
        {
            InitializeComponent();
        }

        private void boton_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void boton_Procesar_Click(object sender, EventArgs e)
        {
            facturacion.precioHambFac = double.Parse(numUpD_Hamburgesas.Text);
            facturacion.precioBebiFac = double.Parse(numUpD_Bebidas.Text);
            facturacion.porcenDescFac = double.Parse(numUpD_DescPorcen.Text);
            facturacion.porcenIncremFac = double.Parse(numUpDown_IncremenPorcen.Text);
            MessageBox.Show("Guardado con exito!", "Guardado...", MessageBoxButtons.OK);
        }
    }
}
