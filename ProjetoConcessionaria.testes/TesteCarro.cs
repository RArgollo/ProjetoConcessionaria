using ProjetoConcessionaria.console.Exceptions;
using Xunit;
using ProjetoConcessionaria.Models;
namespace ProjetoConcessionaria.testes;

public class TesteCarro
{
    private Carro CriaCarroPadrão()
    {
        return new Carro("chevrolet", "camaro", "2012", 500, "amarelo", 250000, "gasolina", true);
    }
    [Fact]
    public void CarroDeveTerValorEsperado()
    {
        var carro = CriaCarroPadrão();
        var valorEsperado = 250000 * 1.2;
        var valorCarro = carro.CalcularValor();
        Assert.Equal(valorEsperado, valorCarro);
    }

    [Fact]
    public void CarroDeveTerValorMaiorQue5Mil()
    {
        var valorEsperado = 3000;
        var ex = Assert.Throws<InputInvalidoException>(() => new Carro("chevrolet", "camaro", "2012", 500, "amarelo", valorEsperado, "gasolina", true));
        Assert.Equal("Valor deve ser maior que 5mil", ex.Message);
    }
}
