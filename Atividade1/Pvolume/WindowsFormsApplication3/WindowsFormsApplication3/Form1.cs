using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculo_Click(object sender, EventArgs e)
        {
            double raio,altura;

            if(Double.TryParse(txtaltura.Text, out altura) && Double.TryParse(txtraio.Text, out raio))
            {
                if(raio<=0)
                {
                    MessageBox.Show("Raio deve ser maior que Zero");
                    txtraio.Focus();
                }

                if (altura <= 0)
                {
                    MessageBox.Show("Altura deve ser maior que Zero");
                    txtaltura.Focus();
                }

                double volume;

                //volume = 3.14 * Raio*Raio * altura;
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtvolume.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Invalido");
                txtraio.Focus();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtraio.Text = "";
            txtvolume.Text = string.Empty;

            txtraio.Focus();

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }//Fechamento SE DO BOTÃO CALUCLO
    }
}
