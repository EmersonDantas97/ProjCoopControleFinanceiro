using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCoopControleFinanceiro.Repository
{
    internal static class Connection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection(getMakeString());
            con.Open();
            return con;
        }

        private static string getMakeString()
        {
            Configuration config = Configuration.ReadConfig();
            StringBuilder sb = new StringBuilder();

            if(config == null)
                throw new Exception("Configuração inválida!");

            sb.Append("Server=" + config.Server);
            sb.Append("Port=" + config.Port);
            sb.Append("Database=" + config.Database);
            sb.Append("Uid=" + config.User);
            sb.Append("Pwd=" + config.Password);

            return sb.ToString();

        }
    }
}
