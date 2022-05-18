using ProjetoConcessionaria.console.Exceptions;
using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.web.DTOs;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MotoController : ControllerBase
    {
        public static List<MotoDTO> Motos { get; set; } = new List<MotoDTO>();

        [HttpPost("AddMoto")]
        public IActionResult AddMoto(MotoDTO motoDto)
        {
            try
            {
                var moto = new Moto(motoDto.Marca, motoDto.Modelo, motoDto.Ano, motoDto.Quilometragem, motoDto.Cor, motoDto.Valor, motoDto.Cilindrada, motoDto.Partida); 
                Motos.Add(motoDto);
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