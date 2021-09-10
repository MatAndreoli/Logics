using APP.Acesso;
using System.Data.OleDb;

namespace TCC.Classes
{
    internal class Subtracao
    {
        #region Variables and Instances

        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();

        #endregion Variables and Instances

        #region Methods

        public Subtracao(string login)
        {
            cmd.CommandText = "insert into Subtracao(loginS, acertos, erros) values('" + login + "', 0, 0)";

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