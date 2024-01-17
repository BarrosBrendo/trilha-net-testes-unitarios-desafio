namespace TestesUnitarios.Desafio.Console.Services
{
    /// <summary>
    /// Classe respons�vel por realizar diversas valida��es envolvendo listas.
    /// </summary>
    public class ValidacoesLista
    {
        /// <summary>
        /// Remove os n�meros negativos de uma lista.
        /// </summary>
        /// <param name="lista">Lista de n�meros inteiros.</param>
        /// <returns>Lista apenas com n�meros positivos.</returns>
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            return lista.Where(x => x > 0).ToList();
        }

        /// <summary>
        /// Verifica se um determinado n�mero est� presente na lista.
        /// </summary>
        /// <param name="lista">Lista de n�meros inteiros.</param>
        /// <param name="numero">N�mero a ser verificado.</param>
        /// <returns>Verdadeiro se o n�mero estiver na lista, falso caso contr�rio.</returns>
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            return lista.Contains(numero);
        }

        /// <summary>
        /// Multiplica os elementos da lista por um determinado n�mero.
        /// </summary>
        /// <param name="lista">Lista de n�meros inteiros.</param>
        /// <param name="numero">N�mero pelo qual os elementos ser�o multiplicados.</param>
        /// <returns>Lista com elementos multiplicados.</returns>
        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            return lista.Select(x => x * numero).ToList();
        }

        /// <summary>
        /// Retorna o maior n�mero na lista.
        /// </summary>
        /// <param name="lista">Lista de n�meros inteiros.</param>
        /// <returns>Maior n�mero na lista.</returns>
        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max();
        }

        /// <summary>
        /// Retorna o menor n�mero na lista.
        /// </summary>
        /// <param name="lista">Lista de n�meros inteiros.</param>
        /// <returns>Menor n�mero na lista.</returns>
        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min();
        }
    }
}


