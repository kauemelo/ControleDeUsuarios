namespace ControleDeUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuario() 
        {
           // Nome = "Kaue";
        }
        //Sobre carga de metodo / construtor
        public Usuario(string nome)
        {
            Nome = nome;
        }
        public Usuario(string nome,string email)
        {
            Nome = nome;
            Email = email;
        }
        public Usuario(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}
