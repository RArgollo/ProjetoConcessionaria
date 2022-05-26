using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Exceptions;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.web.DTOs;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        public static List<CarroDTO> Carros { get; set; } = new List<CarroDTO>();
        public static ILogger<CarroController> Log { get; set; }

        public CarroController(ILogger<CarroController> log)
        {
            Log = log;
        }

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
                Log.LogError(ex.Message);
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