using ProjetoConcessionaria.Lib.Exceptions;
using ProjetoConcessionaria.Lib.Models;
using Xunit;
namespace ProjetoConcessionaria.testes
{
    public class TesteMoto
    {
        private Moto CriaMotoPadrão()
        {
            return new Moto("kawasaki", "ninja", "2015", 2000, "verde", 12000, 300, "injecao eletronica");
        }
        [Fact]
        public void MotoDeveTerValorEsperado()
        {
            var valorEsperado = (12000 + (300 * 50)) * 1.1;
            var moto = CriaMotoPadrão();
            var valorMoto = moto.CalcularValor();
            Assert.Equal(valorEsperado, valorMoto);
        }


        [Fact]
        public void MotoDeveTerValorMaiorQue2Mil()
        {
            var valorEsperado = 1000;
            var ex = Assert.Throws<InputInvalidoException>(() => new Moto("kawasaki", "ninja", "2015", 2000, "verde", valorEsperado, 300, "injecao eletronica"));
            Assert.Equal("Valor deve ser maior que 2mil", ex.Message);
        }
    }
}