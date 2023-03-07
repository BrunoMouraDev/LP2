using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();


            //set

            objHorista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objHorista.Nomeempregado = txtnome.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtsalariohoras.Text);
            objHorista.NumeroHora = Convert.ToDouble(txthumerohoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtadmissao.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtfaltas.Text);
            if (rbtnsim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            MessageBox.Show("Matricula:" + objHorista.Matricula + "\n" + "Nome" + objHorista.Nomeempregado + "\n" + "Data de Entrada:" + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salario Bruto:" + objHorista.SalarioBruto().ToString("N2") + "\n" + "Tempo de Empresa (Dias):" + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHome()); 

        }

        private void txtsalariohoras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
