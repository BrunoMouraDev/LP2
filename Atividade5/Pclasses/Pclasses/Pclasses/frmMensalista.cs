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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();


            //set

            objMensalista.Matricula = Convert.ToInt32(txtmatricula.Text);
            objMensalista.Nomeempregado = txtnome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtadmissao.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtsalario.Text);
            if (rbtnsim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula:" + objMensalista.Matricula + "\n" + "Nome" + objMensalista.Nomeempregado + "\n" + "Data de Entrada:" + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salario Bruto:" + objMensalista.SalarioBruto().ToString("N2") + "\n" + "Tempo de Empresa (Dias):" + objMensalista.TempoTrabalho() + "\n" + objMensalista.VerificaHome());  

        }
    }
}
