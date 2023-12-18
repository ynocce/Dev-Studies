using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class BancoDeDados
    {
        static string conexao = "server=localhost;port=3306;" + "database=clinica;uid=root;password=Ygor123456789;";


        public MySqlConnection conectar ()
        {
            MySqlConnection connection = new MySqlConnection(conexao);
            connection.Open();
            return connection;
        }
    }


}
