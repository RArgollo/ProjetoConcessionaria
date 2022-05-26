using Microsoft.AspNetCore.Mvc;
using ProjetoConcessionaria.Lib.Models;
namespace ProjetoConcessionaria.web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static List<Venda> Vendas { get; set; } = new List<Venda>();

        [HttpPost("AddVenda")]
        public IActionResult AddVenda(Venda venda)
        {
            Vendas.Add(venda);
            return Ok(Vendas);
        }

        [HttpGet("GetListVendas")]
        public IActionResult GetListVendas()
        {
            return Ok(Vendas);
        }

        [HttpDelete("DeleteVenda")]
        public IActionResult DeleteVenda()
        {
            Vendas.RemoveAt(Vendas.Count - 1);
            return Ok(Vendas);
        }

    }
}