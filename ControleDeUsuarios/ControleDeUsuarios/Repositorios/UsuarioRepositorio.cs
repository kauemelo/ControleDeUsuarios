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

        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            var listaUsuarios = await _dbContext.Usuarios.ToListAsync();
            return listaUsuarios;
        }
        public async Task<Usuario> BuscarPorID(int id)
        {
            var usuario = await _dbContext.Usuarios.FirstOrDefaultAsync(u => u.Id == id);
            return usuario;
        }
        public async Task<Usuario> Adicionar(Usuario usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario;
        }
        public async Task<Usuario> Atualizar(Usuario usuario, int id)
        {
            Usuario usuarioPorId = await BuscarPorID(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario com id ={id} não encontrado!");
            }
            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;
            _dbContext.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return usuarioPorId;
        }
        public async Task<bool> Apagar(int id)
        {
            Usuario usuarioPorId = await BuscarPorID(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario com id ={id} não encontrado!");
            }
            _dbContext.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
