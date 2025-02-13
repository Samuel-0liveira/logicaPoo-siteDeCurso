using SiteDeCursos.SharedContext;

namespace SiteDeCursos.SubscriptionContext
{
    public class Estudante : ConteudoBase
    {
        public Estudante(string nome, string email, Usuario usuario)
        {
            Nome = nome;
            Email = email;
            Usuario = usuario;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
    }
}