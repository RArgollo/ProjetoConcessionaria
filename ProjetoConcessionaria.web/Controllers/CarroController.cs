using ProjetoConcessionaria.console.Exceptions;
using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.web.DTOs;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<CarroDTO> Carros { get; set; } = new List<CarroDTO>();

        [HttpPost("AddCarro")]
        public IActionResult AddCarro(CarroDTO carroDto)
        {
            try
            {
                var carro = new Carro(carroDto.Marca, carroDto.Modelo, carroDto.Ano, carroDto.Quilometragem, carroDto.Cor, carroDto.Valor, carroDto.Combustivel, carroDto.TransmissaoAutomatica);
                Carros.Add(carroDto);
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