using ControleDeUsuarios.Models;
using ControleDeUsuarios.Repositorios.Interfaces;
using ControleDeUsuarios.Data;
using Microsoft.EntityFrameworkCore;

namespace ControleDeUsuarios.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        //Definir a variavel que vai conectar com o banco de dados
        public readonly ControleUsuariosDbContext _dbContext;
        public UsuarioRepositorio(ControleUsuariosDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Usuario> BuscarTodosUsuarios()
        {
            var listaUsuarios = _dbContext.Usuarios.ToList();
            return listaUsuarios;
        }
        public Usuario BuscarPorID(int id)
        {
            var usuario = _dbContext.Usuarios.FirstOrDefault(u => u.Id == id);
            return usuario;
        }
        public Usuario Adicionar(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();
            return usuario;
        }
        public Usuario Atualizar(Usuario usuario, int id)
        {
            Usuario usuarioPorId = BuscarPorID(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario com id ={id} não encontrado!");
            }
            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;
            _dbContext.Update(usuarioPorId);
            _dbContext.SaveChanges();
            return usuarioPorId;
        }
        public bool Apagar(int id)
        {
            Usuario usuarioPorId = BuscarPorID(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario com id ={id} não encontrado!");
            }
            _dbContext.Remove(usuarioPorId);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
