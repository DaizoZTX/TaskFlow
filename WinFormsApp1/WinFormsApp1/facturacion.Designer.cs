namespace WinFormsApp1
{
    partial class facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturacion));
            tb_factura = new TextBox();
            button1 = new Button();
            boton_Cerrar = new Button();
            tb_nombre = new TextBox();
            tb_cedula = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            numUpD_CantHamb = new NumericUpDown();
            numUpD_CantBebi = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            buton_NewClient = new Button();
            ((System.ComponentModel.ISupportInitialize)numUpD_CantHamb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpD_CantBebi).BeginInit();
            SuspendLayout();
            // 
            // tb_factura
            // 
            tb_factura.Location = new Point(231, 42);
            tb_factura.Multiline = true;
            tb_factura.Name = "tb_factura";
            tb_factura.ReadOnly = true;
            tb_factura.Size = new Size(269, 354);
            tb_factura.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(231, 402);
            button1.Name = "button1";
            button1.Size = new Size(269, 23);
            button1.TabIndex = 1;
            button1.Text = "IMPRIMIR FACTURA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // boton_Cerrar
            // 
            boton_Cerrar.Location = new Point(12, 401);
            boton_Cerrar.Name = "boton_Cerrar";
            boton_Cerrar.Size = new Size(84, 24);
            boton_Cerrar.TabIndex = 2;
            boton_Cerrar.Text = "Cerrar Caja";
            boton_Cerrar.UseVisualStyleBackColor = true;
            boton_Cerrar.Click += boton_Cerrar_Click;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(12, 42);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(213, 23);
            tb_nombre.TabIndex = 5;
            // 
            // tb_cedula
            // 
            tb_cedula.Location = new Point(12, 88);
            tb_cedula.Name = "tb_cedula";
            tb_cedula.Size = new Size(213, 23);
            tb_cedula.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "CEDULA";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Debito", "Credito" });
            comboBox1.Location = new Point(12, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 11;
            label3.Text = "METODO DE PAGO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 373);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 26);
            label4.Name = "label4";
            label4.Size = new Size(201, 15);
            label4.TabIndex = 13;
            label4.Text = "PREVISUALIZACION DE LA FACTURA";
            // 
            // numUpD_CantHamb
            // 
            numUpD_CantHamb.Location = new Point(12, 182);
            numUpD_CantHamb.Name = "numUpD_CantHamb";
            numUpD_CantHamb.Size = new Size(96, 23);
            numUpD_CantHamb.TabIndex = 14;
            // 
            // numUpD_CantBebi
            // 
            numUpD_CantBebi.Location = new Point(12, 235);
            numUpD_CantBebi.Name = "numUpD_CantBebi";
            numUpD_CantBebi.Size = new Size(96, 23);
            numUpD_CantBebi.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 164);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 16;
            label5.Text = "n° DE HAMBURGESAS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 217);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 17;
            label6.Text = "n° DE BEBIDAS";
            // 
            // buton_NewClient
            // 
            buton_NewClient.Location = new Point(102, 401);
            buton_NewClient.Name = "buton_NewClient";
            buton_NewClient.Size = new Size(123, 24);
            buton_NewClient.TabIndex = 18;
            buton_NewClient.Text = "Nuevo cliente";
            buton_NewClient.UseVisualStyleBackColor = true;
            buton_NewClient.Click += buton_NewClient_Click;
            // 
            // facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(519, 438);
            ControlBox = false;
            Controls.Add(buton_NewClient);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numUpD_CantBebi);
            Controls.Add(numUpD_CantHamb);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_cedula);
            Controls.Add(tb_nombre);
            Controls.Add(boton_Cerrar);
            Controls.Add(button1);
            Controls.Add(tb_factura);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "facturacion";
            Text = "TaskFlow V0.1";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numUpD_CantHamb).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpD_CantBebi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_factura;
        private Button button1;
        private Button boton_Cerrar;
        private TextBox tb_nombre;
        private TextBox tb_cedula;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private NumericUpDown numUpD_CantHamb;
        private NumericUpDown numUpD_CantBebi;
        private Label label5;
        private Label label6;
        private Button buton_NewClient;
    }
}