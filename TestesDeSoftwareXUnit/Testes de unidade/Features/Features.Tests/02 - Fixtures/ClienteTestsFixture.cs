using System;
using Features.Clientes;
using Xunit;

namespace Features.Tests
{
    /// <summary>
    /// Classe criada como uma coleção que será injetado nas classes que forem
    /// reutilizar o ClienteTestsFixture
    /// </summary>
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture> {}

    /// <summary>
    /// Como é uma classe reutilizável, deve, então implementar o Disposable
    /// </summary>
    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Eduardo",
                "Pires",
                DateTime.Now.AddYears(-30),
                "edu@edu.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public Cliente GerarClienteInValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "edu2edu.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public void Dispose() { }
    }
}