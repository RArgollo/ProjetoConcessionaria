using ProjetoConcessionaria.console.Exceptions;
using Xunit;
using ProjetoConcessionaria.Models;
namespace ProjetoConcessionaria.testes
{
    public class TesteCliente
    {
        [Fact]
        public void TelefoneDeveTerMaisDe8Caracteres()
        {
            var telefoneEsperado = "123456";
            var ex = Assert.Throws<InputInvalidoException>(() => new Cliente("Rafael", "49439305819", "19/11/2001", "rafaelargollo22@hotmail.com", telefoneEsperado));
            Assert.Equal("Telefone deve ter entre 8 e 15 dígitos", ex.Message);
        }

           [Fact]
        public void TelefoneDeveTerMenosDe15Caracteres()
        {
            var telefoneEsperado = "123456789123456789";
            var ex = Assert.Throws<InputInvalidoException>(() => new Cliente("Rafael", "49439305819", "19/11/2001", "rafaelargollo22@hotmail.com", telefoneEsperado));
            Assert.Equal("Telefone deve ter entre 8 e 15 dígitos", ex.Message);
        }

          public void EmailDeveConterArroba()
        {
            var emailEsperado = "aaaaaaaaaa";
            var ex = Assert.Throws<InputInvalidoException>(() => new Cliente("Rafael", "49439305819", "19/11/2001", emailEsperado, "976973261"));
            Assert.Equal("Email inválido", ex.Message);
        }
    }
}