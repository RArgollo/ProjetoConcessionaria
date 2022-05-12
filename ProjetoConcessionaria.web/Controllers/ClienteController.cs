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
        public IActionResult AddCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            return Ok(Clientes);
        }

        [HttpGet("GetListClientes")]
        public IActionResult GetListClientes()
        {
            return Ok(Clientes);
        }

        [HttpDelete("DeleteCliente")]
        public IActionResult DeleteCliente()
        {
            Clientes.RemoveAt(Clientes.Count -1);
            return Ok(Clientes);
        }

    }
}