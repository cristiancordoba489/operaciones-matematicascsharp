using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperacionesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double RESTA = 0;

            RESTA = numero1 - numero2;

            //LE ESTOY DICIENDO QUE ME MUESTRE EN EL LABEL RESULTADO, EL RESULTADO DE LA SUMA

            LBLRESULTADO.Text = Convert.ToString(string.Format("{0:n}", RESTA));

            //PARA QUE ME MUESTRE LOS PUNTOS DE MILES
            // string.Format("{0:n}", RESTA)

            //PARA QUITAR LOS DECIMALES DESPUES DE LA N PONGO UN O
            // string.Format("{0:n0}", RESTA)

        }

        private void BTNSUMAR_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double SUMA = 0;

            SUMA = numero1 + numero2;

            //LE ESTOY DICIENDO QUE ME MUESTRE EN EL LABEL RESULTADO, EL RESULTADO DE LA SUMA

            LBLRESULTADO.Text = Convert.ToString(string.Format("{0:n}", SUMA));


        }

        private void BTNMULTIPLICAR_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double MULTIPLICACION = 0;

            MULTIPLICACION = numero1 * numero2;

            //LE ESTOY DICIENDO QUE ME MUESTRE EN EL LABEL RESULTADO, EL RESULTADO DE LA SUMA

            LBLRESULTADO.Text = Convert.ToString(string.Format("{0:n}", MULTIPLICACION));

        }

        private void BTNLIMPIAR_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = string.Empty;
            txtnumero2.Text = string.Empty;
            LBLRESULTADO.Text = "0";
            txtnumero1.Focus();

        }

        private void BTNDIVIDIR_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double DIVIDIR = 0;

            DIVIDIR = numero1 / numero2;

            //LE ESTOY DICIENDO QUE ME MUESTRE EN EL LABEL RESULTADO, EL RESULTADO DE LA SUMA

            LBLRESULTADO.Text = Convert.ToString(string.Format("{0:n}", DIVIDIR));
        }
    }
}
