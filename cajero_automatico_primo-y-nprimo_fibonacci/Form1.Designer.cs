﻿namespace cajero_automatico_primo_y_nprimo_fibonacci
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpagar = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblprimo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrespuesta = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnmio = new System.Windows.Forms.Button();
            this.txtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aqua;
            this.groupBox1.Controls.Add(this.LblCantidad);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.BtnRetirar);
            this.groupBox1.Controls.Add(this.LblRespuesta);
            this.groupBox1.Location = new System.Drawing.Point(340, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajero automatico";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(6, 26);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "Cantidad.";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(64, 23);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 3;
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.Location = new System.Drawing.Point(170, 21);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(75, 23);
            this.BtnRetirar.TabIndex = 0;
            this.BtnRetirar.Text = "RETIRAR";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            this.BtnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Location = new System.Drawing.Point(6, 59);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(70, 13);
            this.LblRespuesta.TabIndex = 2;
            this.LblRespuesta.Text = "Respuesta: ?";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aqua;
            this.groupBox2.Controls.Add(this.lblCambio);
            this.groupBox2.Controls.Add(this.txtpago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtpagar);
            this.groupBox2.Controls.Add(this.btnPagar);
            this.groupBox2.Location = new System.Drawing.Point(340, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 226);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagar";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(126, 144);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(13, 13);
            this.lblCambio.TabIndex = 11;
            this.lblCambio.Text = "¿";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(103, 61);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(100, 20);
            this.txtpago.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paga con:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad a pagar:";
            // 
            // txtpagar
            // 
            this.txtpagar.Location = new System.Drawing.Point(103, 32);
            this.txtpagar.Name = "txtpagar";
            this.txtpagar.Size = new System.Drawing.Size(100, 20);
            this.txtpagar.TabIndex = 7;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(89, 100);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aqua;
            this.groupBox3.Controls.Add(this.txtnumero);
            this.groupBox3.Controls.Add(this.lblprimo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnrespuesta);
            this.groupBox3.Location = new System.Drawing.Point(610, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 172);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Numeros Primos";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(117, 26);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 3;
            // 
            // lblprimo
            // 
            this.lblprimo.AutoSize = true;
            this.lblprimo.Location = new System.Drawing.Point(122, 78);
            this.lblprimo.Name = "lblprimo";
            this.lblprimo.Size = new System.Drawing.Size(70, 13);
            this.lblprimo.TabIndex = 2;
            this.lblprimo.Text = "Respuesta: ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Numero:";
            // 
            // btnrespuesta
            // 
            this.btnrespuesta.Location = new System.Drawing.Point(117, 128);
            this.btnrespuesta.Name = "btnrespuesta";
            this.btnrespuesta.Size = new System.Drawing.Size(75, 23);
            this.btnrespuesta.TabIndex = 0;
            this.btnrespuesta.Text = "Mostrar";
            this.btnrespuesta.UseVisualStyleBackColor = true;
            this.btnrespuesta.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Aqua;
            this.groupBox4.Controls.Add(this.btnmio);
            this.groupBox4.Controls.Add(this.txtn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(23, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 206);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Secuencia Fibonacci.";
            // 
            // btnmio
            // 
            this.btnmio.Location = new System.Drawing.Point(36, 95);
            this.btnmio.Name = "btnmio";
            this.btnmio.Size = new System.Drawing.Size(75, 23);
            this.btnmio.TabIndex = 3;
            this.btnmio.Text = "Mostrar.";
            this.btnmio.UseVisualStyleBackColor = true;
            this.btnmio.Click += new System.EventHandler(this.btnMF_Click);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(11, 69);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese los valores a Generar:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(164, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 160);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 473);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpagar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblprimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrespuesta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnmio;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

