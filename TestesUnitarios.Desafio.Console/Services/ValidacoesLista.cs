namespace TestesUnitarios.Desafio.Console.Services
{
    /// <summary>
    /// Classe responsável por realizar diversas validações envolvendo listas.
    /// </summary>
    public class ValidacoesLista
    {
        /// <summary>
        /// Remove os números negativos de uma lista.
        /// </summary>
        /// <param name="lista">Lista de números inteiros.</param>
        /// <returns>Lista apenas com números positivos.</returns>
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            return lista.Where(x => x > 0).ToList();
        }

        /// <summary>
        /// Verifica se um determinado número está presente na lista.
        /// </summary>
        /// <param name="lista">Lista de números inteiros.</param>
        /// <param name="numero">Número a ser verificado.</param>
        /// <returns>Verdadeiro se o número estiver na lista, falso caso contrário.</returns>
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            return lista.Contains(numero);
        }

        /// <summary>
        /// Multiplica os elementos da lista por um determinado número.
        /// </summary>
        /// <param name="lista">Lista de números inteiros.</param>
        /// <param name="numero">Número pelo qual os elementos serão multiplicados.</param>
        /// <returns>Lista com elementos multiplicados.</returns>
        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            return lista.Select(x => x * numero).ToList();
        }

        /// <summary>
        /// Retorna o maior número na lista.
        /// </summary>
        /// <param name="lista">Lista de números inteiros.</param>
        /// <returns>Maior número na lista.</returns>
        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        /// <summary>
        /// Retorna o menor número na lista.
        /// </summary>
        /// <param name="lista">Lista de números inteiros.</param>
        /// <returns>Menor número na lista.</returns>
        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}


