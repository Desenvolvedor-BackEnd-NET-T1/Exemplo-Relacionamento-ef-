
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoFimModulo;
using ProjetoFimModulo.Entidades;

namespace projetoFimModulo.Controller
{
    [ApiController]
    [Route("teste")]
    public class TesteController : ControllerBase
    {


        private readonly AppDbContext _context;

        public TesteController(AppDbContext context)
        {
            _context = context;
        }

        //para fins de teste, não é necessário criar um service e repository para este controller, pois ele não terá persistência de dados
        [HttpPost("Categorias")]
        public IActionResult CriarCaterias()
        {      
            _context.Categorias.Add(new Categoria { Nome = "Categoria Teste" });
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("Categorias")]
        public IActionResult GetCategorias()
        {
            var categorias = _context.Categorias.ToList();
            return Ok(categorias);
        }
        [HttpGet("Chamados")]
        public IActionResult GetChamados()
        {
        
            var chamados = _context.Chamados.ToList();
            


           

            return Ok(chamados);
        }
        [HttpPost("Chamados")]
        public IActionResult CriarChamados([FromQuery] int categoriaId)
        {

            _context.Chamados.Add(new Chamado { Descricao = "Chamado Teste", CategoriaId = categoriaId });

            _context.SaveChanges();

            return Ok();
        }



    }
}