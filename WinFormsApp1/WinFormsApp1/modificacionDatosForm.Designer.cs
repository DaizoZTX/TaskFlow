namespace WinFormsApp1
{
    partial class modificacionDatosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificacionDatosForm));
            boton_Cerrar = new Button();
            boton_Procesar = new Button();
            numUpD_Hamburgesas = new NumericUpDown();
            numUpD_Bebidas = new NumericUpDown();
            numUpD_DescPorcen = new NumericUpDown();
            numUpDown_IncremenPorcen = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpD_Hamburgesas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpD_Bebidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpD_DescPorcen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDown_IncremenPorcen).BeginInit();
            SuspendLayout();
            // 
            // boton_Cerrar
            // 
            boton_Cerrar.Cursor = Cursors.Hand;
            boton_Cerrar.Location = new Point(136, 182);
            boton_Cerrar.Name = "boton_Cerrar";
            boton_Cerrar.Size = new Size(85, 37);
            boton_Cerrar.TabIndex = 0;
            boton_Cerrar.Text = "Cerrar";
            boton_Cerrar.UseVisualStyleBackColor = true;
            boton_Cerrar.Click += boton_Cerrar_Click;
            // 
            // boton_Procesar
            // 
            boton_Procesar.Cursor = Cursors.Hand;
            boton_Procesar.Location = new Point(12, 182);
            boton_Procesar.Name = "boton_Procesar";
            boton_Procesar.Size = new Size(103, 37);
            boton_Procesar.TabIndex = 0;
            boton_Procesar.Text = "Guardar";
            boton_Procesar.UseVisualStyleBackColor = true;
            boton_Procesar.Click += boton_Procesar_Click;
            // 
            // numUpD_Hamburgesas
            // 
            numUpD_Hamburgesas.Location = new Point(12, 26);
            numUpD_Hamburgesas.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numUpD_Hamburgesas.Name = "numUpD_Hamburgesas";
            numUpD_Hamburgesas.Size = new Size(209, 23);
            numUpD_Hamburgesas.TabIndex = 1;
            // 
            // numUpD_Bebidas
            // 
            numUpD_Bebidas.Location = new Point(12, 67);
            numUpD_Bebidas.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numUpD_Bebidas.Name = "numUpD_Bebidas";
            numUpD_Bebidas.Size = new Size(209, 23);
            numUpD_Bebidas.TabIndex = 2;
            // 
            // numUpD_DescPorcen
            // 
            numUpD_DescPorcen.Location = new Point(12, 110);
            numUpD_DescPorcen.Maximum = new decimal(new int[] { 95, 0, 0, 0 });
            numUpD_DescPorcen.Name = "numUpD_DescPorcen";
            numUpD_DescPorcen.Size = new Size(209, 23);
            numUpD_DescPorcen.TabIndex = 3;
            // 
            // numUpDown_IncremenPorcen
            // 
            numUpDown_IncremenPorcen.Location = new Point(12, 153);
            numUpDown_IncremenPorcen.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numUpDown_IncremenPorcen.Name = "numUpDown_IncremenPorcen";
            numUpDown_IncremenPorcen.Size = new Size(209, 23);
            numUpDown_IncremenPorcen.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 5;
            label1.Text = "Precio de las Hamburgesas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 6;
            label2.Text = "Precio de las Bebidas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(170, 15);
            label3.TabIndex = 7;
            label3.Text = "% de descuento los dias Jueves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 8;
            label4.Text = "% de incremento por tarjeta de credito";
            // 
            // modificacionDatosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(233, 250);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numUpDown_IncremenPorcen);
            Controls.Add(numUpD_DescPorcen);
            Controls.Add(numUpD_Bebidas);
            Controls.Add(numUpD_Hamburgesas);
            Controls.Add(boton_Procesar);
            Controls.Add(boton_Cerrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "modificacionDatosForm";
            Text = "TaskFlow v0.1";
            ((System.ComponentModel.ISupportInitialize)numUpD_Hamburgesas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpD_Bebidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpD_DescPorcen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDown_IncremenPorcen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button boton_Cerrar;
        private Button boton_Procesar;
        private NumericUpDown numUpD_Hamburgesas;
        private NumericUpDown numUpD_Bebidas;
        private NumericUpDown numUpD_DescPorcen;
        private NumericUpDown numUpDown_IncremenPorcen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}