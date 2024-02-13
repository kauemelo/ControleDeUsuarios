namespace ControleDeUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string Email { get; set; }
         public DateTime DataCadastro { get;}
        public Usuario() 
        {
            DataCadastro = DateTime.Now;
        }
        //Sobre carga de metodo / construtor
        public Usuario(string nome)
        {
            Nome = nome;
            DataCadastro = DateTime.Now;
        }
        public Usuario(string nome,string email)
        {
            Nome = nome;
            Email = email;
            DataCadastro = DateTime.Now;
        }
        public Usuario(int id, string nome, string email,)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataCadastro = DateTime.Now;
        }
    }
}
