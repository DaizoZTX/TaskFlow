﻿namespace WinFormsApp1
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
            textBox1 = new TextBox();
            button1 = new Button();
            boton_Cerrar = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(233, 373);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(338, 402);
            button1.Name = "button1";
            button1.Size = new Size(233, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // boton_Cerrar
            // 
            boton_Cerrar.Location = new Point(12, 402);
            boton_Cerrar.Name = "boton_Cerrar";
            boton_Cerrar.Size = new Size(88, 23);
            boton_Cerrar.TabIndex = 2;
            boton_Cerrar.Text = "Cerrar Caja";
            boton_Cerrar.UseVisualStyleBackColor = true;
            boton_Cerrar.Click += boton_Cerrar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(119, 402);
            button3.Name = "button3";
            button3.Size = new Size(88, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(224, 402);
            button4.Name = "button4";
            button4.Size = new Size(88, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 23);
            textBox4.TabIndex = 7;
            // 
            // facturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(594, 438);
            ControlBox = false;
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(boton_Cerrar);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "facturacion";
            Text = "TaskFlow V0.1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button boton_Cerrar;
        private Button button3;
        private Button button4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}