using ProjetoConcessionaria.console.Exceptions;
using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<Carro> Carros { get; set; } = new List<Carro>();

        [HttpPost("AddCarro")]
        public IActionResult AddCarro(string ano, double valor)
        {
            try
            {
                var carro = new Carro("Chevrolet", "Camaro", ano, 20000, "Amarelo", valor, "Gasolina", true);
                Carros.Add(carro);
                return Ok(Carros);
            }
            catch (InputInvalidoException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetListCarros")]
        public IActionResult GetListCarros()
        {
            return Ok(Carros);
        }

        [HttpDelete("DeleteCarro")]
        public IActionResult DeleteCarro()
        {
            Carros.RemoveAt(Carros.Count - 1);
            return Ok(Carros);
        }
    }
}