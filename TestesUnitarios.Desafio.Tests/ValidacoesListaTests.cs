using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesListaTests
    {
        private ValidacoesLista _validacoes = new ValidacoesLista();

        [Theory]
        [InlineData(new[] { 5, -1, -8, 9 }, new[] { 5, 9 })]
        public void DeveRemoverNumerosNegativosDeUmaLista(IEnumerable<int> lista, IEnumerable<int> resultadoEsperado)
        {
            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(new List<int>(lista));

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(new[] { 5, -1, -8, 9 }, 9)]
        public void DeveConterONumero9NaLista(IEnumerable<int> lista, int numeroParaProcurar)
        {
            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(new List<int>(lista), numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Theory]
        [InlineData(new[] { 5, -1, -8, 9 }, 10)]
        public void NaoDeveConterONumero10NaLista(IEnumerable<int> lista, int numeroParaProcurar)
        {
            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(new List<int>(lista), numeroParaProcurar);

            // Assert
            Assert.False(resultado);
        }

        [Theory]
        [InlineData(new[] { 5, 7, 8, 9 }, 2, new[] { 10, 14, 16, 18 })]
        public void DeveMultiplicarOsElementosDaListaPor2(IEnumerable<int> lista, int multiplicador, IEnumerable<int> resultadoEsperado)
        {
            // Act
            var resultado = _validacoes.MultiplicarNumerosLista(new List<int>(lista), multiplicador);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(new[] { 5, -1, -8, 9 }, 9)]
        public void DeveRetornar9ComoMaiorNumeroDaLista(IEnumerable<int> lista, int resultadoEsperado)
        {
            // Act
            var resultado = _validacoes.RetornarMaiorNumeroLista(new List<int>(lista));

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(new[] { 5, -1, -8, 9 }, -8)]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista(IEnumerable<int> lista, int resultadoEsperado)
        {
            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(new List<int>(lista));

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
