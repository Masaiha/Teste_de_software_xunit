using Xunit;

namespace Demo.Tests
{
    public class _05___AssertsObjectTypesTests
    {
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Masanori", 10000);

            // Asserts
            Assert.IsType<Funcionario>(funcionario);
        }

        /// <summary>
        /// Testando herança
        /// </summary>
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Masanori", 10000);

            // Asserts
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}
