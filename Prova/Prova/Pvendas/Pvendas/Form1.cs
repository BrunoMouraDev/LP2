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
namespace Pvendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            int N = 0;
            int M = 0;
            int Totalmes = 0;
            double Totalgeral = 0;



            var auxiliar2 = Interaction.InputBox("Total de Meses: ", "Número de Meses");
            int.TryParse(auxiliar2, out N);

            int[,] matrizVendas = new int[N, 4];
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    var auxiliar = Interaction.InputBox("Valor de Vendas: ", "Entrada de Valor de Vendas");

                    int.TryParse(auxiliar, out matrizVendas[j, i]);
                    Totalmes += matrizVendas[j, i];
                    lstbxValores.Items.Add("Total do Mes: " + (M + 1) + " Semana: " + (i + 1) + " " + matrizVendas[j, i]);

                }
                lstbxValores.Items.Add(">>Total do Mes: " + Totalmes.ToString("N2"));
                lstbxValores.Items.Add("\n -------------------------------");
                Totalmes = 0;
                M += 1;
            }

            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    Totalgeral += matrizVendas[j, i];
                }
            }

            lstbxValores.Items.Add(">>Total Geral: " + Totalgeral.ToString("N2"));

        }

 
    }
}
