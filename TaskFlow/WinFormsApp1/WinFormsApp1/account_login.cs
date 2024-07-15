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

    public partial class account_login_FormLoad : Form
    {
        int tipoUsuario;
        string cuenta;
        public account_login_FormLoad()
        {
            InitializeComponent();
        }
        private void botonLogin_aceptar_Click(object sender, EventArgs e)
        {
            tipoUsuario=inicio_sesion();
        }
        private int inicio_sesion()
        {
            int tipoDeUsuario = 0;
            if (tb_usuario.Text == "Admin" && tb_contraseña.Text == "admin")
            {
                MessageBox.Show("Sesion iniciada correctamente!", "ADMINISTRADOR", MessageBoxButtons.OK);
                tipoDeUsuario = 1;
                cuenta = "ADMINISTRADOR";
            }
            else
            {
                if (tb_usuario.Text == "Empleados" && tb_contraseña.Text == "1234")
                {
                    MessageBox.Show("Sesion iniciada correctamente!", "EMPLEADOS", MessageBoxButtons.OK);
                    tipoDeUsuario = 2;
                    cuenta = "EMPLEADOS";
                }
                else
                {
                    if (tb_usuario.Text == "Admin" && tb_contraseña.Text != "admin" || tb_usuario.Text != "Admin" && tb_contraseña.Text == "admin")
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta!", "Oh No!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (tb_usuario.Text == "Empleados" && tb_contraseña.Text != "1234" || tb_usuario.Text != "Empleados" && tb_contraseña.Text == "1234")
                        {
                            MessageBox.Show("Usuario o contraseña incorrecta!", "Oh No!", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("ERROR: No se encontro el usuario", "ERROR", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            return tipoDeUsuario;
        }
        private void account_login_FormLoad_Load(object sender, EventArgs e)
        {
        }
        private void boton_regresarInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
