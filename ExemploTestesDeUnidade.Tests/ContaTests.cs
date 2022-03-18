using System;
using NUnit.Framework;

namespace ExemploTestesDeUnidade.Tests
{
    [TestFixture]
    public class ContaTests
    {
        [SetUp]
        public void SetUp()
        {
            // falarei sobre esse método na próxima parte
            // basicamente, passarei a criação do objeto conta a este método
            // para que ele não seja repetido em todos os testes
        }

        [Test]
        public void Depositar_RetornaSaldoMaisValorDepositado()
        {
            // Arrange 
            Conta conta = new Conta("Lucas", 100);
            decimal saldoEsperado = 200;

            // Act
            var resultado = conta.Depositar(100);

            // Assert
            Assert.AreEqual(saldoEsperado, resultado);
        }

        [Test]
        public void Deposito_QuandoExecutadoComValorNegativo_LancaLancaInvalidOperationException()
        {
            // Arrange
            Conta conta = new Conta("Lucas", 100);

            // Act
            Func<decimal> acao = () => conta.Depositar(-100);

            // Assert
            Assert.Throws<InvalidOperationException>(() => acao());
        }

        [Test]
        public void Saque_QuandoHaSaldoSuficiente_RetornaValorDoSaque()
        {
            // Arrange
            Conta conta = new Conta("Lucas", 100);
            decimal resultadoEsperado = 50;

            // Act
            var resultado = conta.Sacar(50);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [Test]
        public void Saque_QuandoNaoHaSaldoSuficiente_LancaInvalidOperationException()
        {
            // Arrange
            Conta conta = new Conta("Lucas", 100);

            // Act
            Func<decimal> acao = () => conta.Sacar(200);

            // Assert
            Assert.Throws<InvalidOperationException>(() => acao());
        }
    }
}
