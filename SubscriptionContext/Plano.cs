using SiteDeCursos.SharedContext;

namespace SiteDeCursos.SubscriptionContext
{
    public class Plano : ConteudoBase
    {
        public Plano(string titulo, decimal preco)
        {
            Titulo = titulo;
            Preco = preco;
        }

        public string Titulo { get; set; }
        public decimal Preco { get; set; }
    }
}