using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; 
using System.Data.SqlClient;

namespace PCopa0030482211012
{
    public partial class FrmPrincipal : Form
    {
        public static SqlConnection conexao; 

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
          try
            { 
                // aqui a conexão vai depende da sua máquina da escola ou particular 
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2;Persist Security Info=True;User ID=BD2211012;PASSWORD=W218cpd005");
                 conexao.Open(); 
                 } 
                 catch (SqlException ex) 
                 { 
                 MessageBox.Show("Erro de banco de dados =/" + ex.Message); 
                 } 
                 catch (Exception ex) 
                 { 
                 MessageBox.Show("Outros Erros =/" + ex.Message); 
                 } 

            }

        private void cadastrarJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmJogo"];
            if (fc != null)
                fc.Close();

            frmJogo2 objJ = new frmJogo2();
            objJ.MdiParent = this;
            objJ.WindowState = FormWindowState.Maximized;
            objJ.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmJogo"];
            if (fc != null)
                fc.Close();

            frmSobre SobreA = new frmSobre();
            SobreA.MdiParent = this;
            SobreA.WindowState = FormWindowState.Maximized;
            SobreA.Show();
        }
    }
}
