using SiteDeCursos.SharedContext;

namespace SiteDeCursos.SubscriptionContext
{
    public class Assinatura : ConteudoBase
    {

        public Plano? Plano { get; set; }
        public DateTime? DataFinal { get; set; }

        public bool Inativo => DataFinal <= DateTime.Now;
    }
}