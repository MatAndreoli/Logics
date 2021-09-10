using APP.Classes;
using System;
using System.Windows.Forms;

namespace APP.Forms
{
    public partial class FrmConfiguracoes : Form
    {
        #region Methods

        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        private void LoadUserData()
        {
            LblUser.Text = UserDados.Login;
            LblEmail.Text = UserDados.Email;
            LblNome.Text = UserDados.Nome;
            LblIdade.Text = Convert.ToString(UserDados.Idade) + " anos";
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        #endregion Methods
    }
}