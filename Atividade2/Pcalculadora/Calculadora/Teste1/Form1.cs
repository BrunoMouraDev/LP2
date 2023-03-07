using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        bool porcetagem = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "2";

            Operacao.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "5";

            Operacao.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "9";

            Operacao.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "7";

            Operacao.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "8";

            Operacao.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            calculo = Convert.ToDecimal(RESULTADO.Text);

            Operacao.Text += "*";

            RESULTADO.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "4";

            Operacao.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "6";

            Operacao.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        { 
            calculo = Convert.ToDecimal(RESULTADO.Text);

            Operacao.Text += "-";

            RESULTADO.Text = "";

            adicao =false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "1";

            Operacao.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "3";

            Operacao.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(RESULTADO.Text);

            Operacao.Text += "+";

            RESULTADO.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += ",";

            Operacao.Text += ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RESULTADO.Text += "0";

            Operacao.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(RESULTADO.Text);

            Operacao.Text += "/";

            RESULTADO.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultado = true;

            Operacao.Text += "=";

            //Inicio Operação de Adição
            if (adicao == true)
            {
               if(porcetagem == true)
                {
                    RESULTADO.Text = Convert.ToString(calculo*( Convert.ToDecimal(RESULTADO.Text)/100));
                }

               RESULTADO.Text = Convert.ToString(Convert.ToDecimal(RESULTADO.Text) + calculo);

               Operacao.Text = RESULTADO.Text;

            }//fechamento adição

            //Inicio Operação de Subtração
            if (subtracao == true)
            {
                if (porcetagem == true)
                {
                    RESULTADO.Text = Convert.ToString((calculo*(Convert.ToDecimal(RESULTADO.Text)/100)));
                }

                RESULTADO.Text = Convert.ToString(calculo - Convert.ToDecimal(RESULTADO.Text));

               Operacao.Text = RESULTADO.Text;

                
            }//fechamento Subtração


            //Inicio Operação de Multiplicação
            if (multiplicacao == true)
            {

                RESULTADO.Text = Convert.ToString(Convert.ToDecimal(RESULTADO.Text) * calculo);

                Operacao.Text = RESULTADO.Text;

            }//fechamento Multiplicação

            // Inicio Operação de Divisão
            if (divisao == true)
            {
                if (Convert.ToDecimal(RESULTADO.Text) > 0)
                { 
                    RESULTADO.Text = Convert.ToString(calculo / Convert.ToDecimal(RESULTADO.Text));

                    Operacao.Text = RESULTADO.Text;
                     
                 }
            }//fechamento Divisão
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Operacao.Text += "%";

            porcetagem = true;

        }

        private void RESULTADO_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            RESULTADO.Text = "";

            Operacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            try
            {
                string apagar = RESULTADO.Text;

                apagar = apagar.Remove(apagar.Length - 1);

                RESULTADO.Text = apagar;

                Operacao.Text = apagar;
            }
            catch(Exception)
            {

            }
        }
    }//fechamento do forms
}// Fechamento do Codigo
