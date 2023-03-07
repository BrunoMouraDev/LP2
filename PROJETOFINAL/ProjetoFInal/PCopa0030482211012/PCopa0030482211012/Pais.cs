using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PCopa0030482211012
{
    class Pais
    {
        public int id { get; set; }
        public int Nome { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daJogo;
            DataTable dtJogo = new DataTable();

            try
            {
                daJogo = new SqlDataAdapter("SELECT * FROM PAIS ORDER BY NOME", FrmPrincipal.conexao);
                daJogo.Fill(dtJogo);
                daJogo.FillSchema(dtJogo, SchemaType.Source);
            }//Fechamento Try
            catch(Exception)
            {
                throw;
            }
            return dtJogo;
        }
    }
}
