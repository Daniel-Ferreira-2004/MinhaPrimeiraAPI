using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.context;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos is null)
            {
                return NotFound("A tabela Produtos não foi encontrada");
            }
            return produtos;
        }

        [HttpGet("{id:int}", Name= "ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produtos = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produtos is null)
            {
                return NotFound("Não foi possivel localizar um Produto com esse ID");
            }
            return produtos;
        }

        [HttpPost]
        public ActionResult Post(Produto produtos)
        {
            if (produtos is null)
            {
                return BadRequest("O produto não pode ser nulo");
            }

            _context.Produtos.Add(produtos);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterProduto",
                new { id = produtos.ProdutoId }, produtos);
        }
    }
}
