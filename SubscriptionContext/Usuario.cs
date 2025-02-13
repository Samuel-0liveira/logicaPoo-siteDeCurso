using SiteDeCursos.SharedContext;

namespace SiteDeCursos.SubscriptionContext
{
    public class Usuario : ConteudoBase
    {
        public Usuario(string nomeDeUsuario, string senha)
        {
            NomeDoUsuario = nomeDeUsuario;
            Senha = senha;
        }
        public string NomeDoUsuario { get; set; }
        public string Senha { get; set; }
    }
}