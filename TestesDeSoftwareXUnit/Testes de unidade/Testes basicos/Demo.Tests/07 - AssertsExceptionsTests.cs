using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class _07___AssertsExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Asserts
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitodo()
        {
            // Arrange & Act & Asserts
            var exception =
                Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Masanori", 250));

            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }

    }
}
