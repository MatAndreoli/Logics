using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Classes;

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
            LblNome.Text = UserDados.Nome + " " + UserDados.Sobrenome;
            LblIdade.Text = Convert.ToString(UserDados.Idade) + " anos";
        }
        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        #endregion
    }
}
