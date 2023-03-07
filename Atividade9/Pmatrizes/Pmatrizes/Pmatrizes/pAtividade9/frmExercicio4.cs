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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNomes_Click(object sender, EventArgs e)
        {
            txtPlanilha.Clear();

            List<string> Nomes = new List<string>()
            {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};

            Nomes.Remove("Otávio");

            for (int i = 0; i < Nomes.Count; i++)
            {
                txtPlanilha.Text += Nomes[i] + "\n";
            }
        }
    }
}
