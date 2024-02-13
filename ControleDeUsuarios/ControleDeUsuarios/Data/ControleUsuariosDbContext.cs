using ControleDeUsuarios.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeUsuarios.Data
{
    public class ControleUsuariosDbContext: DbContext
    {
        public ControleUsuariosDbContext(DbContextOptions<ControleUsuariosDbContext> options) 
            : base(options) 
        { 
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
