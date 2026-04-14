using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CadastroAluno
{
    internal class Conexao
    {
        public MySqlConnection Conectar()
        {
            string conexao = "server=localhost;" + "database=escola;" + "uid=root;" + "pwd=;";
            return new MySqlConnection(conexao);
        }

    }
}
