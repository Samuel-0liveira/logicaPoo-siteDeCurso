using SiteDeCursos.NotificationContext;
using SiteDeCursos.SharedContext;

namespace SiteDeCursos.SubscriptionContext
{
    public class Estudante : ConteudoBase
    {
        public Estudante()
        {
            Assinaturas = new List<Assinatura>();
        }

        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Usuario? Usuario { get; set; }

        public IList<Assinatura> Assinaturas { get; set;}

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (IsPremium)
            {
                AddNotificacao(new Notificacao("Premium", "O aluno já possuí uma assinatura ativa!"));
                return;
            }

            Assinaturas.Add(assinatura);
        }

        public bool IsPremium => Assinaturas.Any(x => !x.Inativo);
    }
}