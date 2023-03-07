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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Alunos = {  "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
        
            int I, Total = 0;
            int N = Alunos.Length;

            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            MessageBox.Show("A resposta é = " + Total, "Total");
        }
    }
}
