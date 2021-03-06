using APP.Acesso;
using System.Data.OleDb;

namespace TCC.Classes
{
    internal class Avancado1
    {
        #region Variables and Instances

        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();

        #endregion Variables and Instances

        #region Methods

        public Avancado1(string login)
        {
            cmd.CommandText = "insert into Avancado1 (loginA1, acertos, erros) values('" + login + "', 0, 0)";

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