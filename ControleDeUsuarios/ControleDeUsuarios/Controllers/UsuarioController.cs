using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ola")]
        public IActionResult OlaPessoa()
        {
            string nome = "Jose";
            if (nome.Equals("Maria"))
            {
                return Ok($"Olá {nome}");
            }
            else
            {
                return NotFound();
            }
           
        }
        [HttpGet("teste/outroteste")]
        public IActionResult Teste ()
        {
            return Ok("Teste");
        }
    }
}
