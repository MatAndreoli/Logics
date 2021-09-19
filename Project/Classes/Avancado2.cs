using APP.Acesso;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Classes
{
    internal class Avancado2
    {
        #region Variables and Instances

        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();

        #endregion Variables and Instances

        #region Methods

        public Avancado2(string login)
        {
            cmd.CommandText = "insert into Avancado2 (loginA2, acertos, erros) values('" + login + "', 0, 0)";

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