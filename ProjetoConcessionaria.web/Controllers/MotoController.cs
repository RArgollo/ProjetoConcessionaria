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
        public IActionResult AddMoto(Moto moto)
        {
            Motos.Add(moto);
            return Ok(Motos);
        }

        [HttpGet("GetListMotos")]
        public IActionResult GetListMotos()
        {
            return Ok(Motos);
        }

        [HttpDelete("DeleteMoto")]
        public IActionResult DeleteMoto()
        {
            Motos.RemoveAt(Motos.Count -1);
            return Ok(Motos);
        }

    }
}