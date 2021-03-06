using APP.Acesso;
using APP.Classes;
using System.Data.OleDb;

namespace TCC.Classes
{
    internal class UpdateAvancado1
    {
        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();
        public int acertoUp, erroUp;

        public void Avancado1Update(int certo, int errado)
        {
            GetAcertoErro(UserDados.Login);
            acertoUp = certo + UserDados.AcertoAvan1;
            erroUp = errado + UserDados.ErroAvan1;
            cmd.CommandText = "update Avancado1 set acertos = '" + acertoUp + "', erros = '" + erroUp + "' where loginA1 = '" + UserDados.Login + "'";

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

        public void GetAcertoErro(string loginA1)
        {
            cmd.CommandText = "select * from Avancado1 where loginA1 = '" + loginA1 + "'";

            try
            {
                cmd.Connection = conn.Connect();
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        UserDados.AcertoAvan1 = read.GetInt32(1);
                        UserDados.ErroAvan1 = read.GetInt32(2);
                        UserDados.TotalAvan1 = read.GetInt32(3);
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