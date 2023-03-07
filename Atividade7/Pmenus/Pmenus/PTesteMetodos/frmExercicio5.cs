using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        int num1, num2;

        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNumero2.Text, out num2);
            int.TryParse(txtNumero1.Text, out num1);

            if (!(int.TryParse(txtNumero1.Text, out num1)))
            {
                MessageBox.Show("O texto digitado não é número");
            }
            else
                if (!(int.TryParse(txtNumero2.Text, out num2)))
                {
                    MessageBox.Show("O texto digitado não é número");
                }
            else
                if (num2 > num1)
            {
                MessageBox.Show("Número 2 é maior que número 1, corrija!");
            }
            else
            {
                Random numAleatorio = new Random();
                int valorInteiro = numAleatorio.Next(num2,num1);
                txtResultado.Text = valorInteiro.ToString();

            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtNumero2.Text, out num2)))
            {
                MessageBox.Show("O texto digitado não é número");
            }
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if(!(int.TryParse(txtNumero1.Text, out num1)))
            {
                MessageBox.Show("O texto digitado não é número");
            }
              
        }
    }
}
