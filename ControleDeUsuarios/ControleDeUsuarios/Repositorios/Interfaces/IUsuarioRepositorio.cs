using ControleDeUsuarios.Models;

namespace ControleDeUsuarios.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<Usuario>> BuscarTodosUsuarios();

        Task< Usuario> BuscarPorID(int id);

       Task< Usuario> Adicionar(Usuario usuario);

      Task< Usuario> Atualizar(Usuario usuario, int id);

       Task< bool> Apagar(int id);
    }
}
