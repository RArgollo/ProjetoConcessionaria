using ProjetoConcessionaria.console.Exceptions;
using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>();

        [HttpPost("AddCliente")]
        public IActionResult AddCliente (string telefone, string email)
        {
            try
            {
                var cliente = new Cliente("Argollo", "12345678977", "19/11/2001", email, telefone);
                Clientes.Add(cliente);
                return Ok(Clientes);
            }
            catch (InputInvalidoException ex)
            {
                BadRequest(ex.Message);
            }
        }

        [HttpGet("GetListClientes")]
        public IActionResult GetListClientes()
        {
            return Ok(Clientes);
        }

        [HttpDelete("DeleteCliente")]
        public IActionResult DeleteCliente()
        {
            Clientes.RemoveAt(Clientes.Count - 1);
            return Ok(Clientes);
        }

    }
}