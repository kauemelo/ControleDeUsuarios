
using ControleDeUsuarios.Models;
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
            // Usuario usuario = new Usuario();
            //Usuario usuario = new Usuario("Kalicia");
            Usuario usuario = new Usuario(1, "Maria", "maria@gmail.com");



            return Ok($"Olá {usuario.Nome}!Seu email é: {usuario.Email}");

            //if (usuario.Nome.Equals("Kaue"))
            //{
            //    return Ok($"Olá {usuario.Nome}, Cara de porco");
            //}
            //else
            //{
            //    return NotFound();
            //}

        }
        [HttpGet("teste/outroteste")]
        public IActionResult Teste()
        {
            return Ok("Teste");
        }

        [HttpGet]
        public ActionResult<List <Usuario>> BuscarTodosUsuarios() 
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
               

            return Ok($"Usuario {usuario.Nome} cadastrado com sucesso!");
        }


    }
}
