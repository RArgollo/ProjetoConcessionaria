using Xunit;
using ProjetoConcessionaria.Models;
namespace ProjetoConcessionaria.testes;

public class TesteCarro
{
    [Fact]
    public void CarroDeveTerValorEsperado()
    {
        var carro = new Carro("chevrolet", "camaro", "2012", 500, "amarelo", 250000, "gasolina", true);
        var valorEsperado = 250000 * 1.2;
        var valorCarro = carro.CalcularValor();
        Assert.Equal(valorEsperado, valorCarro);
    }
}
