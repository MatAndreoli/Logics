using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP.Acesso;
using System.Data.OleDb;
using APP.Classes;

namespace TCC.Classes
{
    internal class UpdateAdicao
    {
        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();
        public static int Acerto { get; set; }
        public static int Erro { get; set; }
        public int acertoUp, erroUp;

        public void AdicaoUpdate(int certo, int errado)
        {
            GetAcertoErro(UserDados.Login);
            acertoUp = certo + UserDados.AcertoAdicao;
            erroUp = errado + UserDados.ErroAdicao;
            cmd.CommandText = "update Adicao set acertos = '" + acertoUp + "', erros = '" + erroUp + "' where loginA = '" + UserDados.Login + "'";

            try
            {
                cmd.Connection = conn.Connect();
                cmd.ExecuteNonQuery();
                conn.Disconnect();
            }
            catch (OleDbException)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao atualizar BD.");
            }
        }

        public void GetAcertoErro(string login)
        {
            cmd.CommandText = "select * from Adicao where loginA = '" + login + "'";
            try
            {
                cmd.Connection = conn.Connect();
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        UserDados.AcertoAdicao = read.GetInt32(1);
                        UserDados.ErroAdicao = read.GetInt32(2);
                        UserDados.TotalAdicao = read.GetInt32(3);
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