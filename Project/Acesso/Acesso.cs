using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP.Classes;

namespace APP.Acesso
{
    class Acesso
    {
        public bool exist = false;

        public bool Acessar(string login, string senha)
        {
            Validacao vali = new Validacao();
            exist = vali.ValidarLogin(login, senha);
            return exist;
        }
    }
}
