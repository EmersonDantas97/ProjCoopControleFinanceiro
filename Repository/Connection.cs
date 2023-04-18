using MySqlConnector;
using System.Text;

namespace ProjCoopControleFinanceiro.Repository
{
    /// <summary>
    /// Tabela estática para pegar a conexão com o banco de dados
    /// usando a técnica using -> IDisposable
    /// </summary>
    internal static class Connection
    {
        /// <summary>
        /// Método que retorna uma conexão aberta
        /// </summary>
        /// <returns>Conexão com o estado de aberta (Caso não falhe a conexão)</returns>
        public static MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection(getMakeString());
            con.Open();
            return con;
        }

        /// <summary>
        /// Caso o arquivo não exista vai criar um limpo
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static string getMakeString()
        {
            Configuration config = Configuration.ReadConfig();
            StringBuilder sb = new StringBuilder();

            if (config == null)
                throw new Exception("Configuração inválida!");

            sb.Append("Server=" + config.Server);
            sb.Append(";Port=" + config.Port);
            sb.Append(";Database=" + config.Database);
            sb.Append(";Uid=" + config.User);
            sb.Append(";Pwd=" + config.Password);

            return sb.ToString();

        }
    }
}
