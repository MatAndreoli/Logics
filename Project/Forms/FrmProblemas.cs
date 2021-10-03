using APP.Classes;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.Forms
{
    public partial class FrmProblemas : Form
    {
        private ThemeColor cl = new ThemeColor();
        private int correctAnswer, questionNumber = 1, score = 0;

        public FrmProblemas()
        {
            InitializeComponent();
            FazerPergunta(questionNumber);
        }

        private void FazerPergunta(int num)
        {
            switch (num)
            {
                case 1:
                    LblPergunta.Text = "Cinco homens cavam uma vala de 5 metros em cinco horas. " +
                        "Quantos cavadores serão necessários para cavar uma vala de 100 metros em 100 horas ? ";

                    BtnR1.Text = "5";
                    BtnR2.Text = "100";
                    BtnR3.Text = "10";
                    BtnR4.Text = "50";

                    correctAnswer = 1;

                    break;

                case 2:
                    LblPergunta.Text = "Alguns consideram que a cidade de Florianópolis foi fundada no dia 23 de março de 1726, " +
                        "que caiu em um sábado. Após 90 dias, no dia 21 de junho, a data assinalou o início do inverno, " +
                        "quando a noite é a mais longa do ano. Esse dia caiu em uma:";

                    BtnR1.Text = "segunda-feira";
                    BtnR2.Text = "sexta-feira";
                    BtnR3.Text = "quarta-feira";
                    BtnR4.Text = "quinta-feira";
                    BtnR1.Width += 50;
                    BtnR2.Width += 50;
                    BtnR3.Width += 50;
                    BtnR4.Width += 50;

                    correctAnswer = 2;
                    break;

                case 3:
                    LblPergunta.Text = "Duas tartarugas estavam juntas e começaram a caminhar em linha reta em direção a um lago distante. A primeira tartaruga percorreu 30 metros por dia e demorou 16 dias para chegar ao lago. A segunda tartaruga só conseguiu percorrer 20 metros por dia e, portanto, chegou ao lago alguns dias depois da primeira. Quando a primeira tartaruga chegou ao lago, o número de dias que ela teve que esperar para a segunda tartaruga chegar foi:";

                    BtnR1.Text = "6";
                    BtnR2.Text = "7";
                    BtnR3.Text = "8";
                    BtnR4.Text = "9";
                    BtnR1.Width = 132;
                    BtnR2.Width = 132;
                    BtnR3.Width = 132;
                    BtnR4.Width = 132;

                    correctAnswer = 3;
                    break;

                case 4:
                    LblPergunta.Text = "Em um sistema de codificação, AB representa os algarismos do dia do nascimento de uma pessoa e CD os algarismos de seu mês de nascimento. " +
                        "Nesse sistema, a data trinta de julho, por exemplo, corresponderia a: A = 3;  B = 0;  C = 0;  D = 7; " +
                        "Admita uma pessoa cuja data de nascimento obedeça à seguinte condição: " +
                        "A + B + C + D = 20;  O mês de nascimento dessa pessoa é: ";

                    BtnR1.Text = "Agosto(8)";
                    BtnR2.Text = "Setembro(9)";
                    BtnR3.Text = "Outubro(10)";
                    BtnR4.Text = "Novembro(11)";
                    BtnR1.Width += 50;
                    BtnR2.Width += 50;
                    BtnR3.Width += 50;
                    BtnR4.Width += 50;

                    correctAnswer = 2;
                    break;

                case 5:
                    LblPergunta.Text = "Quantas vezes se pode subtrair o número 1 do número 1.111 ? ";

                    BtnR1.Text = "2";
                    BtnR2.Text = "3";
                    BtnR3.Text = "1.111";
                    BtnR4.Text = "1";
                    BtnR1.Width = 132;
                    BtnR2.Width = 132;
                    BtnR3.Width = 132;
                    BtnR4.Width = 132;

                    correctAnswer = 4;
                    break;

                case 6:
                    LblPergunta.Text = "Sabendo que é verdadeira a afirmação “Todos os alunos de Fulano foram aprovados no concurso”, então é necessariamente verdade:";

                    BtnR1.Text = "Fulano não foi aprovado no concurso.";
                    BtnR2.Text = "Se Roberto não é aluno de Fulano, então ele não foi aprovado no concurso.";
                    BtnR3.Text = "Fulano foi aprovado no concurso.";
                    BtnR4.Text = "Se Carlos não foi aprovado no concurso, então ele não é aluno de Fulano.";

                    BtnR1.Size = new Size(294, 100);
                    BtnR2.Size = new Size(294, 100);
                    BtnR3.Size = new Size(294, 100);
                    BtnR4.Size = new Size(294, 100);
                    BtnR1.Location = new Point(25, 208);
                    BtnR2.Location = new Point(330, 208);
                    BtnR3.Location = new Point(25, 330);
                    BtnR4.Location = new Point(330, 330);

                    correctAnswer = 4;
                    break;

                case 7:
                    LblPergunta.Text = "Dona Maria tem quatro filhos: Francisco, Paulo, Raimundo e Sebastião. A esse respeito, sabe-se que: I.Sebastião é mais velho que Raimundo. II.Francisco é mais novo que Paulo. III.Paulo é mais velho que Raimundo. Assim, é obrigatoriamente verdadeiro que: ";

                    BtnR1.Text = "Paulo é o mais velho.";
                    BtnR2.Text = "Raimundo é o mais novo.";
                    BtnR3.Text = "Sebastião não é o mais novo.";
                    BtnR4.Text = "Francisco é o mais novo.";

                    BtnR1.Size = new Size(208, 59);
                    BtnR2.Size = new Size(208, 59);
                    BtnR3.Size = new Size(208, 59);
                    BtnR4.Size = new Size(208, 59);
                    BtnR1.Location = new Point(85, 260);
                    BtnR2.Location = new Point(353, 260);
                    BtnR3.Location = new Point(85, 362);
                    BtnR4.Location = new Point(353, 362);

                    correctAnswer = 3;
                    break;

                case 8:
                    LblPergunta.Text = "Complete o padrão: 1, 3, 5, 7 ...";

                    BtnR1.Text = "9";
                    BtnR2.Text = "8";
                    BtnR3.Text = "10";
                    BtnR4.Text = "6";

                    BtnR1.Size = new Size(132, 38);
                    BtnR2.Size = new Size(132, 38);
                    BtnR3.Size = new Size(132, 38);
                    BtnR4.Size = new Size(132, 38);
                    BtnR1.Location = new Point(118, 271);
                    BtnR2.Location = new Point(386, 271);
                    BtnR3.Location = new Point(118, 373);
                    BtnR4.Location = new Point(386, 373);

                    correctAnswer = 1;
                    break;

                case 9:
                    LblPergunta.Text = "Complete o padrão: 1, 2, 3, 6, 7, 8, 21, 22, 23, 66, 67, 68 ...";

                    BtnR1.Text = "200";
                    BtnR2.Text = "133";
                    BtnR3.Text = "202";
                    BtnR4.Text = "201";

                    correctAnswer = 4;
                    break;

                case 10:
                    LblPergunta.Text = "Qual dos padrões abaixo abaixo está incorreto de acordo com os outros?";

                    BtnR1.Text = "ABCD";
                    BtnR2.Text = "MNOP";
                    BtnR3.Text = "WXYZ";
                    BtnR4.Text = "FGIH";

                    correctAnswer = 4;
                    break;

                case 11:
                    LblPergunta.Text = "Qual dos padrões abaixo abaixo está incorreto de acordo com os outros?";

                    BtnR1.Text = "MMNM";
                    BtnR2.Text = "IIKO";
                    BtnR3.Text = "AZZZ";
                    BtnR4.Text = "OPOO";

                    correctAnswer = 2;
                    break;
            }
        }

        private void MudarCor(object sender, EventArgs e)
        {
            Color color = cl.SelectColor();
            ThemeColor.PrimaryColor = color;
            Guna2Button ib = (Guna2Button)sender;
            ib.FillColor = color;
            ib.BorderColor = color;
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            var objectSender = (Guna2Button)sender;
            int btnTag = Convert.ToInt32(objectSender.Tag);

            if (btnTag == correctAnswer)
            {
                score++;
            }
            questionNumber++;
            FazerPergunta(questionNumber);
        }

        private void TirarFill(object sender, EventArgs e)
        {
            Guna2Button ib = (Guna2Button)sender;
            ib.FillColor = Color.FromArgb(36, 35, 80);
        }
    }
}