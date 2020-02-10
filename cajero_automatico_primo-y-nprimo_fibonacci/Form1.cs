using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero_automatico_primo_y_nprimo_fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(TxtCantidad.Text);
            sbyte n = 0;
            String Respuesta = "Respuesta: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    Respuesta += n + (denominacion > 1 ? "Billetes" : "Monedas") + denominacion + "\n";
                }
                n = 0;
            }
            LblRespuesta.Text = Respuesta;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtpagar.Text);
            double pago = double.Parse(txtpago.Text);
            sbyte n = 0;
            double resta= pago - cantidad;
            string resp = "cambio \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(resta, 2))
                {
                    n++;

                    resta-= denominacion;
                }
                if (n > 0)
                {
                    resp += n + (denominacion > 1 ? "Billete" : "Monedas") + denominacion + "\n";
                } 
                n = 0;
            }
            lblCambio.Text = resp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, a, b = 0;
            x = Convert.ToInt32(txtnumero.Text);

            for (a = 1; a <= x; a++)
            {

                if (x % a == 0)
                    b++;
            }

            if (b > 1)

            {
                lblprimo.Text = "El numero es primo.";
            }
            else
            {
                lblprimo.Text = "El numero no es primo.";
            }
        }

        private void btnMF_Click(object sender, EventArgs e)
        {
            int a, b, c, d, num;
            a = 0;
            b = 1;

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            num = Convert.ToInt32(txtn.Text);

            for (d = 3; d <= num; d++)
            {
                c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;
            }
        }
    }
}
    

