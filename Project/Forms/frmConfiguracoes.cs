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
            LblUser.Text = UserDados.login;
            LblEmail.Text = UserDados.email;
            LblNome.Text = UserDados.nome + " " + UserDados.sobrenome;
            LblIdade.Text = Convert.ToString(UserDados.idade) + " anos";
        }
        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        #endregion
    }
}
