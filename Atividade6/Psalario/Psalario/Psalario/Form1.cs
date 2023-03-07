using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnval_Click(object sender, EventArgs e)
        {
            double descontoinss = 0;
            double descontoirpf = 0;
            double salarioBruto = 0;
            double salariofamilia = 0;
            double salarioLiquido = 0;
            double numerofilhos = 0;

            if (txtnome.Text == String.Empty)//Ele irá testar se estiver Vazio
            {
                MessageBox.Show("O nome do Funcionário" + "\n Não pode ser vaxio!");
            }
            else
            {
                if (msbxsal.Text.Replace(",", "").Trim() == "")
                    MessageBox.Show("Valor do Salário Invalido ou Igual a 0");

                    if(!double.TryParse(msbxsal.Text, out salarioBruto) || !double.TryParse(cbxfilhos.Text,out numerofilhos))
                    {
                    MessageBox.Show("Salário Bruto e Número de filhos devem ser Números");
                    }
                     else
                    {
                        if (salarioBruto <= 0)
                        MessageBox.Show("Salário devem ser maior que 0");
                        else
                        {
                        //Calculo de INSS
                            if (salarioBruto <= 800.47)
                            {
                                mskaliinss.Text = ("7,65%");
                                descontoinss = 0.0765 * salarioBruto;
                            }
                            else if (salarioBruto <= 1050)
                            {
                                mskaliinss.Text = ("8,65%");
                                descontoinss = 0.0865 * salarioBruto;
                            }
                            else if (salarioBruto <= 1400.77)
                            {
                                mskaliinss.Text = ("9%");
                                descontoinss = 0.09 * salarioBruto;
                            }
                            else if (salarioBruto <= 2801.56)
                            {
                                mskaliinss.Text = ("11%");
                                descontoinss = 0.11 * salarioBruto;
                            }
                            else
                            {
                                mskaliinss.Text = ("Teto");
                                descontoinss = 308.17;
                            }

                            mskdescinss.Text = descontoinss.ToString("N2");

                            //Calculo de IRPF
                            if (salarioBruto <= 1257.12)
                            {
                                mskaliirpf.Text = ("0");
                            }

                            else if (salarioBruto <= 2512.08)
                            {
                                mskaliirpf.Text = ("15%");
                                descontoirpf = 0.15 * salarioBruto;
                            }

                            else
                            {
                                mskaliirpf.Text = ("27.5%");
                                descontoirpf = 0.275 * salarioBruto;
                            }
                            mskdescirpf.Text = descontoirpf.ToString("N2");

                            if (salarioBruto <= 435.52)
                            salariofamilia = 0.2233 * numerofilhos;

                            else if (salarioBruto <= 654.61)
                            salariofamilia = 0.1574 * numerofilhos;
                            else
                            salariofamilia = 0;

                            msksalfam.Text = salariofamilia.ToString("N2");

                            salarioLiquido = salarioBruto - descontoinss - descontoirpf + salariofamilia;

                            msksalliq.Text = salarioLiquido.ToString("N2");

                            lblinfor.Text = "Os descontos do Salário " + (rbtnf.Checked ? "da Sra." : "do Sr.") + txtnome.Text + 
                            " que é " + (cbxcasado.Checked ? "Casado(a)" : "Solteiro(a)")  + "  e que tem " + 
                            Convert.ToString(numerofilhos) + " filho(s) são:";

                            //Outra maneira de Fazer:
                            //    lblinfor.Text = "Os descontos do Salário ";
                            //if (rbtnf.Checked)
                            //    lblinfor.Text = lblinfor.Text + " da Sra ";
                            //else
                            //    lblinfor.Text = lblinfor.Text + " do Sr ";
                            //lblinfor.Text = lblinfor.Text + txtnome.Text;
                            //if (cbxcasado.Checked)
                            //    lblinfor.Text += " que é casado(a) ";
                            //else
                            //    lblinfor.Text = lblinfor + " que é solteiro(a)";
                            //lblinfor.Text = "";

                        }
                     }
            }
        }

        private void cbxcasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            msbxsal.Clear();
            txtnome.Clear();
            mskaliinss.Clear();
            mskaliirpf.Clear();
            mskdescinss.Clear();
            mskdescirpf.Clear();
            msksalfam.Clear();
            msksalliq.Clear();
            cbxcasado.Checked = false;
            cbxfilhos.Text = "";
            lblinfor.Text ="";


        }
    }
}
