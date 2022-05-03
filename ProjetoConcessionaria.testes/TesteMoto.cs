using Xunit;
using ProjetoConcessionaria.Models;
namespace ProjetoConcessionaria.testes
{
    public class TesteMoto
    {
        [Fact]
        public void MotoDeveTerValorEsperado()
        {
            var valorEsperado = (12000 + (300 * 50)) * 1.1;
            var moto = new Moto("kawasaki", "ninja", "2015", 2000, "verde",12000, 300, "injecao eletronica");
            var valorMoto = moto.CalcularValor();
            Assert.Equal(valorEsperado, valorMoto);
        }
    }
}