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
    public partial class facturacion : Form
    {

        public static double precioHambFac = 0, precioBebiFac = 0, porcenDescFac = 0, porcenIncremFac = 0, acumDia = 0, montoTotal = 0;
        public facturacion()
        {
            InitializeComponent();
        }
        //boton de cerrar caja
        private void boton_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult respR = (MessageBox.Show("Esta seguro de que quiere cerrar el cajero?", "OJO!!", MessageBoxButtons.YesNo));
            if (respR == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        //FACTURACION
        private void button1_Click(object sender, EventArgs e)
        {
            //calculos
            double montoNeto = 0;
            montoNeto = (precioHambFac * int.Parse(numUpD_CantHamb.Text)) + (precioBebiFac * int.Parse(numUpD_CantBebi.Text));
            montoTotal = montoNeto;
            //INCREMENTO
            if (comboBox1.SelectedIndex == 1)
            {
                montoTotal += montoNeto * (porcenIncremFac / 100);
            }
            //DESCUENTO
            if (dateTimePicker1.Value.DayOfWeek.ToString() == "Thrusday")
            {
                montoTotal -= montoNeto * (porcenDescFac / 100);
            }
            //FACTURA----------------------------------------------------------------------------
            tb_factura.Text = "NOMBRE: " + tb_nombre.Text + "\r\n";
            tb_factura.Text += "CEDULA: " + tb_cedula.Text + "\r\n";
            tb_factura.Text += "METODO DE PAGO: " + comboBox1.SelectedItem.ToString() + "\r\n";
            tb_factura.Text += "DIA: " + dateTimePicker1.Value.DayOfWeek.ToString() + "\r\n";
            tb_factura.Text += "-----------------------------\r\n";
            if (comboBox1.SelectedIndex == 1)
            {
                tb_factura.Text += "INCREMENTO POR PAGO CON TARJETA DE CREDITO: " + porcenIncremFac + "% (" + montoNeto * (porcenIncremFac / 100) + "Bs)\r\n";
            }
            if (dateTimePicker1.Value.DayOfWeek.ToString() == "Thursday")
            {
                tb_factura.Text += "DESCUENTO POR COMPRA UN DIA JUEVES: " + porcenDescFac + "% (" + montoNeto * (porcenDescFac / 100) + "Bs)\r\n";
            }
            tb_factura.Text += "--------------------------\r\n";
            tb_factura.Text += "MONTO BASE: " + montoNeto + "Bs\r\n";
            tb_factura.Text += "MONTO A PAGAR: " + montoTotal + "Bs";
            montoNeto = 0;
        }

        private void buton_NewClient_Click(object sender, EventArgs e)
        {
            tb_factura.Text = "";
            comboBox1.SelectedIndex = -1;
            tb_nombre.Text = "";
            tb_cedula.Text = "";
            numUpD_CantBebi.Text = "0";
            numUpD_CantHamb.Text = "0";
            acumDia += montoTotal;
        }
    }
}
