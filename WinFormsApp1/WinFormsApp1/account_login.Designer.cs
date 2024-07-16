namespace WinFormsApp1
{
    partial class account_login_FormLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account_login_FormLoad));
            Img_login1 = new PictureBox();
            loginSysPanel = new Panel();
            boton_regresarInicio = new Button();
            botonLogin_aceptar = new Button();
            label_contraseña = new Label();
            label_usuario = new Label();
            tb_contraseña = new TextBox();
            tb_usuario = new TextBox();
            label_inicioSesion = new Label();
            img_login2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Img_login1).BeginInit();
            loginSysPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_login2).BeginInit();
            SuspendLayout();
            // 
            // Img_login1
            // 
            resources.ApplyResources(Img_login1, "Img_login1");
            Img_login1.Name = "Img_login1";
            Img_login1.TabStop = false;
            // 
            // loginSysPanel
            // 
            resources.ApplyResources(loginSysPanel, "loginSysPanel");
            loginSysPanel.BackColor = SystemColors.ScrollBar;
            loginSysPanel.Controls.Add(boton_regresarInicio);
            loginSysPanel.Controls.Add(botonLogin_aceptar);
            loginSysPanel.Controls.Add(label_contraseña);
            loginSysPanel.Controls.Add(label_usuario);
            loginSysPanel.Controls.Add(tb_contraseña);
            loginSysPanel.Controls.Add(tb_usuario);
            loginSysPanel.Controls.Add(label_inicioSesion);
            loginSysPanel.Name = "loginSysPanel";
            // 
            // boton_regresarInicio
            // 
            resources.ApplyResources(boton_regresarInicio, "boton_regresarInicio");
            boton_regresarInicio.Name = "boton_regresarInicio";
            boton_regresarInicio.UseVisualStyleBackColor = true;
            boton_regresarInicio.Click += boton_regresarInicio_Click;
            // 
            // botonLogin_aceptar
            // 
            resources.ApplyResources(botonLogin_aceptar, "botonLogin_aceptar");
            botonLogin_aceptar.Name = "botonLogin_aceptar";
            botonLogin_aceptar.UseVisualStyleBackColor = true;
            botonLogin_aceptar.Click += botonLogin_aceptar_Click;
            // 
            // label_contraseña
            // 
            resources.ApplyResources(label_contraseña, "label_contraseña");
            label_contraseña.BackColor = SystemColors.ControlDarkDark;
            label_contraseña.FlatStyle = FlatStyle.Flat;
            label_contraseña.ForeColor = SystemColors.ButtonHighlight;
            label_contraseña.Name = "label_contraseña";
            // 
            // label_usuario
            // 
            resources.ApplyResources(label_usuario, "label_usuario");
            label_usuario.BackColor = SystemColors.ControlDarkDark;
            label_usuario.FlatStyle = FlatStyle.Flat;
            label_usuario.ForeColor = SystemColors.ButtonHighlight;
            label_usuario.Name = "label_usuario";
            // 
            // tb_contraseña
            // 
            resources.ApplyResources(tb_contraseña, "tb_contraseña");
            tb_contraseña.Name = "tb_contraseña";
            // 
            // tb_usuario
            // 
            resources.ApplyResources(tb_usuario, "tb_usuario");
            tb_usuario.Name = "tb_usuario";
            // 
            // label_inicioSesion
            // 
            resources.ApplyResources(label_inicioSesion, "label_inicioSesion");
            label_inicioSesion.BackColor = SystemColors.ControlDarkDark;
            label_inicioSesion.FlatStyle = FlatStyle.Flat;
            label_inicioSesion.ForeColor = SystemColors.ButtonHighlight;
            label_inicioSesion.Name = "label_inicioSesion";
            // 
            // img_login2
            // 
            resources.ApplyResources(img_login2, "img_login2");
            img_login2.Name = "img_login2";
            img_login2.TabStop = false;
            // 
            // account_login_FormLoad
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.ControlDark;
            ControlBox = false;
            Controls.Add(loginSysPanel);
            Controls.Add(Img_login1);
            Controls.Add(img_login2);
            MaximizeBox = false;
            Name = "account_login_FormLoad";
            Load += account_login_FormLoad_Load;
            ((System.ComponentModel.ISupportInitialize)Img_login1).EndInit();
            loginSysPanel.ResumeLayout(false);
            loginSysPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_login2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Img_login1;
        private Panel loginSysPanel;
        private PictureBox img_login2;
        private Label label_inicioSesion;
        private Label label_contraseña;
        private Label label_usuario;
        public Button botonLogin_aceptar;
        public Button boton_regresarInicio;
        private TextBox tb_contraseña;
        public TextBox tb_usuario;
    }
}