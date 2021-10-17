using APP.Classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.Classes;

namespace TCC.Forms
{
    public partial class FrmExplicacao : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private ThemeColor cl = new ThemeColor();

        public FrmExplicacao()
        {
            InitializeComponent();
        }

        private void FrmExplicacao_Load(object sender, EventArgs e)
        {
            Explicar(NQuestao.NQuest);
            PnlOptions.BorderColor = ThemeColor.PrimaryColor;
            foreach (Control control in Pnlpai.Controls)
            {
                if (control is IconPictureBox iconPictureBox)
                {
                    IconPictureBox ic = iconPictureBox;
                    ic.IconColor = cl.SelectColor();
                }
            }
        }

        private void Explicar(int n)
        {
            switch (n)
            {
                case 1:
                    LblExplicacao.Text = "Neste problema é fácil de resolver: pode-se pensar que se cinco homens cavam uma vala de 5 m em 5 horas, para cavar 100 m em 100 horas são necessários 100 homens.No entanto, este raciocínio é completamente falso: é preciso os mesmos cinco cavadores, e nada mais. Na verdade, cinco cavadores cavam 5 m em cinco horas; portanto, cinco escavadores cavam 1 m em 1 hora, e cavam 100 m em 100 horas.";
                    break;

                case 2:
                    LblExplicacao.Text = "Como entre um sábado e outro temos o intervalo de 7 dias, vamos dividir os 90 por 7 para saber quantas semanas teremos nesse intervalo. O resultado dessa divisão é 12 semanas e sobram 6 dias. Contando seis dias a partir de sábado, temos a sexta feira.";
                    break;

                case 3:
                    LblExplicacao.Text = "Como a primeira tartaruga andou 30 metros por dia, em 16 dias terá percorrido: 6. 30 = 480 metros Para descobrir quanto tempo a segunda tartaruga levará para percorrer os 480 metros, basta dividir pelos 20 metros percorridos por dia, assim temos: 480 : 20 = 24 dias Assim, o tempo de espera da primeira tartaruga será: 24 - 16 = 8";
                    break;

                case 4:
                    LblExplicacao.Text = "Para determinarmos a soma A + B + C + D = 20, é necessário considerar os maiores valores de A + B e de C + D. O valor maior da adição de A + B equivale a 11, considerando o dia do nascimento 29. Da mesma forma, o valor maior de C + D equivale a 9, considerando o mês de nascimento setembro, ou mês 09.";
                    break;

                case 5:
                    LblExplicacao.Text = "Apenas uma vez, já que nas contas seguintes estaríamos subtraindo 1 do número 1.110, 1.109, 1.108, etc.";
                    break;

                case 6:
                    LblExplicacao.Text = "As letras a e c indicam informações sobre Fulano. Contudo, a informação que temos é sobre os alunos de Fulano, e, portanto, não podemos afirmar nada a respeito de Fulano. A letra b fala sobre Roberto. Como ele não é aluno de Fulano, também não podemos afirmar se é verdade. A letra d fala que Carlos não foi aprovado.Como todos os alunos de Fulano foram aprovados, logo, ele não pode ser aluno de Fulano. Assim, essa alternativa é necessariamente verdadeira. Por fim, a letra d também não está correta, pois não nos foi informado que só os alunos de Fulano que foram aprovados.";
                    break;

                case 7:
                    LblExplicacao.Text = "Sebastião > Raimundo => Sebastião não é o mais novo e Raimundo não é o mais velho. \nFrancisco < Paulo => Paulo não é o mais novo e Francisco não é o mais velho. Paulo > Raimundo => Paulo não é o mais novo e Raimundo não é o mais velho. Sabemos que Paulo não é o mais novo, mas não podemos afirmar que é o mais velho. Assim, a alternativa 'a' não é obrigatoriamente verdadeira. O mesmo podemos dizer das letras b e c, pois sabemos que Raimundo e Francisco não são os mais velhos, mas não podemos afirmar que são os mais novos. Portanto, a única opção que é obrigatoriamente verdadeira é que Sebastião não é o mais novo.";
                    break;

                case 8:
                    LblExplicacao.Text = "O padrão é somar o número anterior a 2. Portanto, 7 + 2 = 9";
                    break;

                case 9:
                    LblExplicacao.Text = "Soma-se o 1º com o 2º e o 3º, o resultado é colocado na sequência e os dois próximos números são seus sucessores. Sempre com uma sequência de 3 números. Portando, o próximo número na sequência será 201, pois 66 + 67 + 68 = 201";
                    break;

                case 10:
                    LblExplicacao.Text = "Os padrões seguem uma ordem alfabética de 4 letras. Então observa-se que 'FGIH' não está em ordem alfabética (FGHI).";
                    break;

                case 11:
                    LblExplicacao.Text = "O padrão deste é a repetição de 3 letras, portanto 'IIKO' não segue esse padrão.";
                    break;
            }
        }

        private void CbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pnlpai_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}