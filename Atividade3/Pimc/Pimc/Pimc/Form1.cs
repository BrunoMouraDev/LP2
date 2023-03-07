using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtimc.Clear();
            txtpeso.Clear();
            txtsituacao.Clear();
        }

        private void txtimc_TextChanged(object sender, EventArgs e)
        {

        }

        Double Peso, altura,imc;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtpeso.Text, out Peso) && Double.TryParse(txtaltura.Text, out altura))
            {
                if ((altura <= 0) || (Peso <= 0))
                    MessageBox.Show("Valores devem ser maior que Zero");
                else
                {
                    imc = Peso / (altura * altura);
                    imc = Math.Round(imc, 1); //Sistema que Arredonda

                    txtimc.Text = imc.ToString("N1");

                    if (imc < 18.5)
                        txtsituacao.Text = "Magreza";
                    else if (imc <= 24.9)
                        txtsituacao.Text = "Normal";
                    else if (imc <= 29.9)
                        txtsituacao.Text = "SobrePeso";
                    else if (imc <= 39.9)
                        txtsituacao.Text = "Obesidade";
                    else
                        txtsituacao.Text = "Obesidade Grave";

                }
            }
            else
                MessageBox.Show("Valores Ivalidos");
        }
    }
}
