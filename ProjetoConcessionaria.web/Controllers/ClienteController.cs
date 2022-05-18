using ProjetoConcessionaria.console.Exceptions;
using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.web.DTOs;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        public static List<ClienteDTO> Clientes { get; set; } = new List<ClienteDTO>();

        [HttpPost("AddCliente")]
        public IActionResult AddCliente (ClienteDTO clienteDto)
        {
            try
            {
                var cliente = new Cliente(clienteDto.Nome, clienteDto.CPF, clienteDto.DataNascimento, clienteDto.Email, clienteDto.Telefone);
                Clientes.Add(clienteDto);
                return Ok(Clientes);
            }
            catch (InputInvalidoException ex)
            {
               return BadRequest(ex.Message);
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