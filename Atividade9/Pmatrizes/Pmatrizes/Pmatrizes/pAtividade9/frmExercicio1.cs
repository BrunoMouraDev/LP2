using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace pAtividade9
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int max = 20;
            int[] valores = new int[max];
            string stringona = "";

            txtPlanilha.Clear();

            for (i = 0; i < max; i++)
            {
                var verificar = Interaction.InputBox("Entre com o {i + 1} número:", "Coletor de Números");

                if (verificar == "")
                    return;

                if (!int.TryParse(verificar, out int num))
                {
                    MessageBox.Show("Entre com os números adequados!");
                    i--;
                }
                else
                {
                    valores[i] = num;
                }
            }

            for (i = max - 1; i >= 0; i--)
            {
                stringona += valores[i] + "\n";
            }

            txtPlanilha.Text = stringona;

        }
    }
}
