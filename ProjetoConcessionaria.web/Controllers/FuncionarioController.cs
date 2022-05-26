using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
using ProjetoConcessionaria.web.DTOs;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<FuncionarioDTO> Funcionarios { get; set; } = new List<FuncionarioDTO>();

        [HttpPost("AddFuncionario")]
        public IActionResult AddFuncionario(FuncionarioDTO funcionarioDto)
        {
            var funcionario = new Funcionario(funcionarioDto.Nome, funcionarioDto.CPF, funcionarioDto.DataNascimento, funcionarioDto.Cargo);
            Funcionarios.Add(funcionarioDto);
            return Ok(Funcionarios);
        }

        [HttpGet("GetListaFuncionarios")]
        public IActionResult GetListaFuncionarios()
        {
            return Ok(Funcionarios);
        }

        [HttpDelete("DeleteFuncionario")]
        public IActionResult DeleteFuncionario()
        {
            Funcionarios.RemoveAt(Funcionarios.Count - 1);
            return Ok(Funcionarios);
        }

    }
}