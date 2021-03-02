using Xunit;

namespace Demo.Tests
{
    public class _01___AssertsStringsTests
    {
        [Fact]

        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Masanori", "Iha");

            // Asserts
            Assert.Equal("MASANORI IHA", nomeCompleto, ignoreCase: true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Masanori", "Iha");

            // Asserts
            Assert.Contains("nori", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Masanori", "Iha");

            // Asserts
            Assert.StartsWith("Masa", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Masanori", "Iha");

            // Asserts
            Assert.EndsWith("Iha", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Masanori", "Iha");

            // Asserts
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }

    }
}
