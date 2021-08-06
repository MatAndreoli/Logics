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
    internal class Adicao
    {
        #region Variables and Instances

        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();

        #endregion Variables and Instances

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

        #endregion Methods
    }
}