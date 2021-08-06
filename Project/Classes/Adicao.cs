using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using APP.Acesso;
using System.Data.OleDb;

namespace APP.Classes
{
    class Adicao
    {
        #region Variables and Instances
        Connection conn = new Connection();
        OleDbCommand cmd = new OleDbCommand();
        #endregion

        #region Methods
        public Adicao(string login)
        { 
            cmd.CommandText = "insert into Adicao values('" + login + "', 0, 0, 0)";

            try
            {
                cmd.Connection = conn.Connect();
                cmd.ExecuteNonQuery();
                conn.Disconnect();
            }
            catch (OleDbException)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao cadastrar");
            }
        }
        #endregion
    }
}
