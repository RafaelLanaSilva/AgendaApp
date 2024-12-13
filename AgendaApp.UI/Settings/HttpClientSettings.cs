namespace AgendaApp.UI.Settings
{
    /// <summary>
    /// Classe para mapear os endereços das APIs
    /// </summary>
    public class HttpClientSettings
    {
        /// <summary>
        /// URL base da API de agenda
        /// </summary>
        private static string UrlBase = "http://localhost:5008/api";

        public static string CriarPessoa = $"{UrlBase}/pessoas/criar";
        public static string AutenticarPessoa = $"{UrlBase}/pessoas/autenticar";
        public static string Tarefas = $"{UrlBase}/tarefas";
    }
}



