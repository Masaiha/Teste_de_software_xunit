using Xunit;

namespace Demo.Tests
{
    public class _03___AssertsBoolTests
    {
        [Fact]
        public void Funcionario_Nome_NaodeveSerNuloOuVazio()
        {
            // Arrange
            var funcionario = new Funcionario("", 1000);

            // Act

            // Asserts
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Apelido_NaodeveTerApelido()
        {
            // Arrange
            var funcionario = new Funcionario("Masanori", 1000);

            // Act

            // Asserts
            Assert.Null(funcionario.Apelido);
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }

        [Fact]
        public void Funcionario_Apelido_DeveTerApelido()
        {
            // Arrange
            var funcionario = new Funcionario("Masanori", 1000);
            funcionario.Apelido = "Masa";

            // Act

            // Asserts
            Assert.NotNull(funcionario.Apelido);
            Assert.False(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.True(funcionario.Apelido?.Length > 0);
        }

        [Fact]
        public void Funcionario_Nome_DeveConterMaisDeDoisCaracteres()
        {
            // Arrange
            var funcionario = new Funcionario("Masanori", 1000);

            // Act

            // Asserts
            Assert.True(funcionario.Nome.Length > 2);
        }

    }
}
