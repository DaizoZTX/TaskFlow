namespace WinFormsApp1
{
    public partial class pantallaInicial : Form
    {
        //Variables globales
        public int TipoUser;
        //creacion de la clase para la introduccion del segundo formulario...
        account_login_FormLoad loginSys;
        //tercer formulario
        facturacion facturacionSys;
        public pantallaInicial()
        {
            InitializeComponent();
            loginSys = new account_login_FormLoad();
            facturacionSys = new facturacion();
        }
        //ES ES SOLO PARA HACER RESALTAR EL BOTON
        //Creacion del panel para el menu principal, este se crea como un OBJETO
        Panel menuPrincipal = new Panel();
        //Evento de visualizacion del menu cuando el mouse pasa por el boton
        private void boton1_menuDesplegable_MouseEnter(object sender, EventArgs e)
        {
            panelHerramientas.Controls.Add(menuPrincipal);
            menuPrincipal.BackColor = Color.Cyan;
            menuPrincipal.Size = new Size(40, 40);
            menuPrincipal.Location = new Point(boton1_menuDesplegable.Location.X, boton1_menuDesplegable.Location.Y);
        }
        //Evento de salida de la visualizacion del menu cuando el mouse ya no esta en su entorno
        private void boton1_menuDesplegable_MouseLeave(object sender, EventArgs e)
        {
            panelHerramientas.Controls.Remove(menuPrincipal);
        }
        //Despliegue del menu
        private void boton1_menuDesplegable_Click(object sender, EventArgs e)
        {
            if (!panelMenuOpc.Visible)
            {
                panelMenuOpc.Visible = true;
            }
            else
            {
                panelMenuOpc.Visible = false;
            }
        }
        //boton de inicio de sesion
        private void botonMenu_inicioSesion_Click(object sender, EventArgs e)
        {
            loginSys.Show();
        }
        private void panelHerramientas_Paint(object sender, PaintEventArgs e)
        {
        }
        //boton de facturacion
        private void botonMenu_op1_Click(object sender, EventArgs e)
        {
            if (tb_tipoDePerfil.Text=="Empleados" || tb_tipoDePerfil.Text=="Admin")
            {
                facturacionSys.Show();
            }
            else
            {
                MessageBox.Show("NO EXISTE INICIO DE SESION", "ERROR", MessageBoxButtons.OK);
            }
        }
        //Boton de refrescado
        private void boton_refresh_Click(object sender, EventArgs e)
        {
            this.tb_tipoDePerfil.Text = loginSys.tb_usuario.Text;
            if (loginSys.tb_usuario.Text=="")
            {
                tb_tipoDePerfil.Text = "Sesion no iniciada...";
            }
        }
    }
}
