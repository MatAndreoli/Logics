﻿using APP.Acesso;
using APP.Classes;
using System.Data.OleDb;

namespace TCC.Classes
{
    internal class UpdateMultiplicacao
    {
        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();
        public int acertoUp, erroUp;

        public void MultiplicacaoUpdate(int certo, int errado)
        {
            GetAcertoErro(UserDados.Login);
            acertoUp = certo + UserDados.AcertoMul;
            erroUp = errado + UserDados.ErroMul;
            cmd.CommandText = "update Multiplicacao set acertos = '" + acertoUp + "', erros = '" + erroUp + "' where loginM = '" + UserDados.Login + "'";

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

        public void GetAcertoErro(string loginM)
        {
            cmd.CommandText = "select * from Multiplicacao where loginM = '" + loginM + "'";

            try
            {
                cmd.Connection = conn.Connect();
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        UserDados.AcertoMul = read.GetInt32(1);
                        UserDados.ErroMul = read.GetInt32(2);
                        UserDados.TotalMul = read.GetInt32(3);
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