namespace SiteDeCursos.NotificationContext
{
    public abstract class Notificador
    {
        public List<Notificacao> Notificacoes { get; set; }

        public Notificador()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddNotificacoes(IEnumerable<Notificacao> notificacao)
        {
            Notificacoes.AddRange(notificacao);
        }

        public bool Invalido => Notificacoes.Any();
    }
}