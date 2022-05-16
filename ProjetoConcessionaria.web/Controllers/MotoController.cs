using ProjetoConcessionaria.console.Exceptions;
using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<Moto> Motos { get; set; } = new List<Moto>();

        [HttpPost("AddMoto")]
        public IActionResult AddMoto(string ano, double valor)
        {
            try
            {
                var moto = new Moto("Yamaha", "XT 660", ano, 12000, "Azul", valor, 660, "injecao eletronica"); 
                Motos.Add(moto);
                return Ok(Motos);
            }
            catch (InputInvalidoException ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("GetListMotos")]
        public IActionResult GetListMotos()
        {
            return Ok(Motos);
        }

        [HttpDelete("DeleteMoto")]
        public IActionResult DeleteMoto()
        {
            Motos.RemoveAt(Motos.Count - 1);
            return Ok(Motos);
        }

    }
}