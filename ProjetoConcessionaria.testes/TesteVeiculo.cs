using ProjetoConcessionaria.console.Exceptions;
using Xunit;
using ProjetoConcessionaria.Models;
namespace ProjetoConcessionaria.testes
{
    public class TesteVeiculo
    {
        [Fact]
        public void AnoDeveSerMaiorQue2004()
        {
            var anoEsperado = "2003";
            var ex = Assert.Throws<InputInvalidoException>(() => new Carro("chevrolet", "camaro", anoEsperado, 500, "amarelo", 250000, "gasolina", true));
            Assert.Equal("Ano deve ser maior que 2004 e menor ou igual ao ano atual", ex.Message);
        }

        [Fact]
        public void AnoDeveSerMenorOuIgualAtual()
        {
            var anoEsperado = "2024";
            var ex = Assert.Throws<InputInvalidoException>(() => new Carro("chevrolet", "camaro", anoEsperado, 500, "amarelo", 250000, "gasolina", true));
            Assert.Equal("Ano deve ser maior que 2004 e menor ou igual ao ano atual", ex.Message);
        }
    }
}