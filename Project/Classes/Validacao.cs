using APP.Acesso;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace APP.Classes
{
    internal class Validacao
    {
        #region Variables and Instances

        public bool exist = false;
        private OleDbCommand cmd = new OleDbCommand();
        private Connection con = new Connection();
        private readonly Regex rgNome = new Regex(@"^[A-ZàáâãèéêìíîòóôõùúûçÀÁÂÃÈÉÌÍÒÓÔÙÚÇ][a-zàáâãèéêìíîòóôõùúûçÀÁÂÃÈÉÌÍÒÓÔÙÚÇ]+$");
        private readonly Regex rgSobrenome = new Regex(@"^[A-ZàáâãèéêìíîòóôõùúûçÀÁÂÃÈÉÌÍÒÓÔÙÚÇ][a-zàáâãèéêìíîòóôõùúûçÀÁÂÃÈÉÌÍÒÓÔÙÚÇ]*(\s?[A-Za-zA-ZàáâãèéêìíîòóôõùúûçÀÁÂÃÈÉÌÍÒÓÔÙÚÇ]\.?)*");
        private readonly Regex rgIdade = new Regex(@"(^[0-9]{1,2})+$");
        private readonly Regex rgEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

        #endregion Variables and Instances

        #region Methods

        public bool ValidarLogin(string login, string senha)
        {
            cmd.CommandText = "select * from Login WHERE(((StrComp([Login].[login], '" + login + "', 0)) = 0)) and (((StrComp([Login].[senha], '" + senha + "', 0)) = 0)); ";
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection = con.Connect();
                OleDbDataReader read = cmd.ExecuteReader();

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        UserDados.Login = read.GetString(0);
                        UserDados.Nome = read.GetString(2);
                        UserDados.Sobrenome = read.GetString(3);
                        UserDados.Idade = read.GetInt32(4);
                        UserDados.Email = read.GetString(5);
                    }
                    exist = true;
                }
            }
            catch (OleDbException erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro" + erro);
            }
            return exist;
        }

        public bool ValidarEmail(string email)
        {
            if (rgEmail.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarIdade(string idade)
        {
            if (rgIdade.IsMatch(idade))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarNome(string nome)
        {
            if (rgNome.IsMatch(nome))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarSobrenome(string sobre)
        {
            if (rgSobrenome.IsMatch(sobre))
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