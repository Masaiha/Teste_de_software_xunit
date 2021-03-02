using Xunit;

namespace Demo.Tests
{
    public class _06___AssertsCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionarioJunior = FuncionarioFactory.Criar("Masanori", 1000);
            var funcionarioPleno = FuncionarioFactory.Criar("Masanori", 2000);
            var funcionarioSenior = FuncionarioFactory.Criar("Masanori", 8000);

            // Asserts
            Assert.All(funcionarioJunior.Habilidades, habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
            Assert.All(funcionarioPleno.Habilidades, habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
            Assert.All(funcionarioSenior.Habilidades, habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadesBasicas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Masanori", 1000);

            // Asserts
            Assert.Contains("OOP",funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadesAvancadas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Masanori", 1000);

            // Asserts
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidadesAvancadas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Masanori", 15000);

            var habilidades = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            // Asserts
            Assert.Equal(habilidades, funcionario.Habilidades);
        }

    }
}
