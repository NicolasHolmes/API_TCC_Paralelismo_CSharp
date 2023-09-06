using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        private readonly SeuDbContext _context; // Substitua pelo seu DbContext

        public ProdutosController(SeuDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return Ok(produtos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return BadRequest("O valor não pode estar vazio.");
            }

            dados.Add(valor);
            return CreatedAtAction(nameof(Get), new { id = dados.Count }, valor);
        }
    }
}