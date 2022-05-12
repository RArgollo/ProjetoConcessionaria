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
        public IActionResult AddCarro(Carro carro)
        {
            Carros.Add(carro);
            return Ok(Carros);
        }

        [HttpGet("GetListCarros")]
        public IActionResult GetListCarros()
        {
            return Ok(Carros);
        }

        [HttpDelete("DeleteCarro")]
        public IActionResult DeleteCarro()
        {
            Carros.RemoveAt(Carros.Count -1);
            return Ok(Carros);
        }

    }
}