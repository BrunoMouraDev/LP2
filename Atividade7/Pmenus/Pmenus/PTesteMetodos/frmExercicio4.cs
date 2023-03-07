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
    public partial class frmExercicio4 : Form
    {
      
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNums_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            int cont = 0;

            while (cont < rtbConteudo.Text.Length)
            {
                if (char.IsNumber(rtbConteudo.Text[cont]))
                {
                   posicao++;
                }
                cont++;
            }
            txtResultado.Text = posicao.ToString();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            if (!string.IsNullOrEmpty(rtbConteudo.Text))
                while (!char.IsWhiteSpace(rtbConteudo.Text[posicao]))
                {
                    if (posicao == rtbConteudo.TextLength - 1)
                    {
                        posicao = 0;
                        break;
                    }

                    posicao++;
                }

            txtResultado.Text = posicao.ToString();
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char caracter in rtbConteudo.Text)
            {
                if (char.IsLetter(caracter))
                    cont++; 
            }
            txtResultado.Text = cont.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            rtbConteudo.Clear();
        }
    }
}
