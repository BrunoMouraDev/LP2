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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] matrizNotas = new double[20, 3];
            string auxiliar;
            double media;

            for (var i = 0; i < 20; i++)
            {
                media = 0;

                for (var j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (j + 1) + " do aluno " + (i + 1), "Entrada das Notas");

                    if (double.TryParse(auxiliar, out matrizNotas[i, j]))
                    {
                        if ((matrizNotas[i, j] < 0) || (matrizNotas[i, j] > 10))
                        {
                            MessageBox.Show("Inválido!");

                            j--;
                        }
                        else
                            media += matrizNotas[i, j];
                    }
                    else
                    {
                        MessageBox.Show("Somente Numeros!");
                        j--;
                    }
                }   // fim do segundo for
                media = media / 3;

                listnotas.Items.Add("Aluno: " + (i + 1) + " Média: " + media.ToString("N2"));
            }
        }
    }
}
