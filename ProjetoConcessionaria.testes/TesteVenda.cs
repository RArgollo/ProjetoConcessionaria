using Xunit;
using ProjetoConcessionaria.Models;
namespace ProjetoConcessionaria.testes
{
    public class TesteVenda
    {
        [Fact]
        public void GerentePodeAplicarDesconto()
        {
            var comprador = new Cliente("Rafael", "49439305819", "19/11/2001", "rafaelargollo22@hotmail.com", "976973261");
            var vendedor = new Funcionario("Pedro", "12345678978", "22/03/1998", "gerente");
            var veiculo = new Moto("kawasaki", "ninja", "2015", 2000, "verde", 12000, 300, "injecao eletronica");
            var venda = new Venda(comprador, vendedor, veiculo, "credito", 29700);
            var valorFinalEsperado = 29700 * 0.95;
            var valorFinal = venda.AplicarDesconto();
            Assert.Equal(valorFinalEsperado, valorFinal);
        }
    }
}