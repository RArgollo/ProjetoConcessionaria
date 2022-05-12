using ProjetoConcessionaria.Models;
using Microsoft.AspNetCore.Mvc;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public static List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        [HttpPost("AddFuncionario")]
        public IActionResult AddFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
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
            Funcionarios.RemoveAt(Funcionarios.Count -1);
            return Ok(Funcionarios);
        }

    }
}