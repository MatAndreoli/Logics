using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace APP.Acesso
{
    internal class Connection
    {
        private static readonly string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        private static readonly string nameBD = "Usuario.accdb";
        private static readonly string pathBD = path;
        private static readonly string staticConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Matheus\Desktop\Progs\GitHub\Logics\Project\Usuario.accdb";
        private static readonly string relativeConnection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathBD + nameBD;
        private readonly OleDbConnection connection = new OleDbConnection();

        public Connection()
        {
            connection.ConnectionString = staticConnection;
        }

        public OleDbConnection Connect()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void Disconnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}