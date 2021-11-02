using APP.Acesso;
using APP.Classes;
using System.Data.OleDb;

namespace TCC.Classes
{
    internal class UpdateSubtracao
    {
        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();
        public int acertoUp, erroUp;

        public void SubtracaoUpdate(int certo, int errado)
        {
            GetAcertoErro(UserDados.Login);
            acertoUp = certo + UserDados.AcertoSub;
            erroUp = errado + UserDados.ErroSub;
            cmd.CommandText = "update Subtracao set acertos = '" + acertoUp + "', erros = '" + erroUp + "' where loginS = '" + UserDados.Login + "'";

            try
            {
                cmd.Connection = conn.Connect();
                cmd.ExecuteNonQuery();
                conn.Disconnect();
                GetAcertoErro(UserDados.Login);
            }
            catch (OleDbException)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao atualizar BD.");
            }
        }

        public void GetAcertoErro(string loginS)
        {
            cmd.CommandText = "select * from Subtracao where loginS = '" + loginS + "'";

            try
            {
                cmd.Connection = conn.Connect();
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        UserDados.AcertoSub = read.GetInt32(1);
                        UserDados.ErroSub = read.GetInt32(2);
                        UserDados.TotalSub = read.GetInt32(3);
                    }
                }
                read.Close();
            }
            catch (OleDbException e)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao pegar dados do BD." + e);
            }
        }
    }
}