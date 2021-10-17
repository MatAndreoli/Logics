﻿using APP.Acesso;
using APP.Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Classes
{
    internal class UpdateAvancado2
    {
        private Connection conn = new Connection();
        private OleDbCommand cmd = new OleDbCommand();
        public int acertoUp, erroUp;

        public void Avancado2Update(int certo, int errado)
        {
            GetAcertoErro(UserDados.Login);
            acertoUp = certo + UserDados.AcertoMul;
            erroUp = errado + UserDados.ErroMul;
            cmd.CommandText = "update Avancado2 set acertos = '" + acertoUp + "', erros = '" + erroUp + "' where loginA2 = '" + UserDados.Login + "'";

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

        public void GetAcertoErro(string loginA2)
        {
            cmd.CommandText = "select * from Avancado2 where loginA2 = '" + loginA2 + "'";

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