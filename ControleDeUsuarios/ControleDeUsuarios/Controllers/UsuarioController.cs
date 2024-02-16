
using ControleDeUsuarios.Models;
using ControleDeUsuarios.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuarios.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //Declarar o repositorio de usuarios
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

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
        public async Task<ActionResult<List<Usuario>>> BuscarTodosUsuarios()
        {
            var ListaDeUsuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            if (ListaDeUsuarios == null)
            {
                return NotFound("Nenhum Usuario Encontrado!");
            }

            return Ok(ListaDeUsuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarUsuarioPorID(int id)
        {
            Usuario usuario =await _usuarioRepositorio.BuscarPorID(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] Usuario usuario)
        {
            Usuario usuarioCadastrado = await _usuarioRepositorio.Adicionar(usuario);
            return Ok(usuarioCadastrado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> atualizar([FromBody] Usuario usuario, int id)
        {
            usuario.Id = id;
            Usuario usuarioAtualizado = await _usuarioRepositorio.Atualizar(usuario, id);

            return Ok(usuarioAtualizado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var excluirUsuario = await _usuarioRepositorio.Apagar(id);
            string msg = (excluirUsuario == true ? "Usuario excluido com sucesso." : "Erro ao exluir.");
            return Ok(msg);
        }

    }
}
