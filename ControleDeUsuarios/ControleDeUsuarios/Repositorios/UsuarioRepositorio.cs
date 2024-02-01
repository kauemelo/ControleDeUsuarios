using ControleDeUsuarios.Models;
using ControleDeUsuarios.Repositorios.Interfaces;

namespace ControleDeUsuarios.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        public Task<Usuario> BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
        public Task<Usuario> Adicionar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Autorizar(Usuario usuario, int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
