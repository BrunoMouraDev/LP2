using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulus
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtladoA.Clear();
            txtladoB.Clear();
            txtladoC.Clear();
        }

        double A, B, C;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtladoA.Text, out A) || !double.TryParse(txtladoB.Text, out B) || !double.TryParse(txtladoC.Text, out C))
            {
                MessageBox.Show("Valores devem ser ser numéricos");
            }
            else
            {
                if (A < (B + C) && A > Math.Abs(B - C) && B < (A + C) && B > Math.Abs(A - C) && C < (A + B) && C > Math.Abs(A - B))
                {
                    if (A == B && B == C)
                    {
                        txtresultado.Text = "Triangulo equilatero";
                    }
                    else
                    {
                        if (A == B || A == C || C == B)
                        {
                            txtresultado.Text = "Triangulo Isósceles";
                        }
                        else
                        {
                            txtresultado.Text = "Triangulo escaleno";
                        }
                    }
                }
            }
        }
    }
}
