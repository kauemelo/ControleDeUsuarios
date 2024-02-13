using ControleDeUsuarios.Models;

namespace ControleDeUsuarios.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        List<Usuario> BuscarTodosUsuarios();

        Usuario BuscarPorID(int id);

        Usuario Adicionar(Usuario usuario);

       Usuario Atualizar(Usuario usuario, int id);

        bool Apagar(int id);
    }
}
