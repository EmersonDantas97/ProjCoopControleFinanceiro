using ProjCoopControleFinanceiro.Util;
using System.Diagnostics;
using System.Text.Json;

namespace ProjCoopControleFinanceiro.Repository
{
    internal class Configuration
    {
        public string Server { get; set; } = "";
        public string Database { get; set; } = "";
        public string User { get; set; } = "";
        public string Password { get; set; } = "";
        public string Port { get; set; } = "";

        private const string archive = @"C:\CONFIGURACAO.JSON";

        public static Configuration? ReadConfig()
        {
            string jsonStr = "";

            if (!File.Exists(archive))
            {
                CreateConfig();
                throw new IOException("Arquivo de configuração não inválido!");
            }

            using (var archiveRead = new StreamReader(archive))
            {
                jsonStr = archiveRead.ReadToEnd();
            }
            return JsonSerializer.Deserialize<Configuration>(jsonStr); ;
        }

        private static void CreateConfig()
        {
            string json = JsonSerializer.Serialize(new Configuration());
            using(StreamWriter sw = new StreamWriter(archive))
            {
                sw.WriteLine(json);
            }
            Functions.OpenArchiveTextNotepad(archive);
        }
    }
}
