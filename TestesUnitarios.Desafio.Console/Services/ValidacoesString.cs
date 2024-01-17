namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        /// <summary>
        /// Retorna a quantidade de caracteres no texto.
        /// </summary>
        public int RetornarQuantidadeCaracteres(string texto)
        {
            return texto.Length;
        }

        /// <summary>
        /// Verifica se um determinado texto está contido no texto principal.
        /// </summary>
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            return texto.Contains(textoProcurado);
        }

        /// <summary>
        /// Verifica se o texto termina com o texto procurado.
        /// </summary>
        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            return texto.EndsWith(textoProcurado);
        }
    }
}
