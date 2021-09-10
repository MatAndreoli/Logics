using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using APP.Acesso;
using TCC.Classes;
using System.Data.OleDb;

namespace APP.Classes
{
    internal class Cadastro
    {
        #region Variables and Instances

        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();
        private bool cadastrado;

        #endregion Variables and Instances

        #region Methods

        public Cadastro(string user, string pass, string nome, int idade, string email)
        {
            cmd.CommandText = "insert into Login values('" + user + "', '" + pass + "', '" + nome + "', " + idade + ", '" + email + "')";

            try
            {
                Adicao point = new Adicao(user);
                Subtracao sub = new Subtracao(user);
                cmd.Connection = conn.Connect();
                cmd.ExecuteNonQuery();
                conn.Disconnect();
                cadastrado = true;
                System.Windows.Forms.MessageBox.Show("Cadastrado.");
            }
            catch (OleDbException)
            {
                System.Windows.Forms.MessageBox.Show("Nome de usuário existente ou erro no preenchimento dados.", "Erro", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        public bool Cadastrou()
        {
            if (cadastrado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion Methods
    }
}