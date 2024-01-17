using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private readonly ValidacoesString _validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornarQuantidadeCorretaDeCaracteresNaPalavraMatrix()
        {
            // Arrange
            const string palavraMatrix = "Matrix";
            const int resultadoEsperado = 6;

            // Act
            var resultado = _validacoes.RetornarQuantidadeCaracteres(palavraMatrix);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData("Esse é um texto qualquer", "qualquer", true)]
        [InlineData("Esse é um texto qualquer", "teste", false)]
        public void DeveVerificarSeTextoContemPalavra(string texto, string palavraProcurada, bool resultadoEsperado)
        {
            // Act
            var resultado = _validacoes.ContemCaractere(texto, palavraProcurada);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveVerificarSeTextoTerminaComPalavraProcurada()
        {
            // Arrange
            const string texto = "Começo, meio e fim do texto procurado";
            const string palavraProcurada = "procurado";

            // Act
            var resultado = _validacoes.TextoTerminaCom(texto, palavraProcurada);

            // Assert
            Assert.True(resultado);
        }
    }
}
