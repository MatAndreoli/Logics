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

        public UpdateAdicao(int certo, int errado)
        {
            cmd.CommandText = "update Adicao set acertos = '" + certo + "', erros = '" + errado + "' where loginA = '" + UserDados.login + "'";

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
    }
}