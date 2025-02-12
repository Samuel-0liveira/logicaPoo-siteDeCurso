namespace SiteDeCursos.NotificationContext
{
    public abstract class Notificador
    {
        public List<Notificacao> Notificacoes { get; set; }

        public void Add(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddRange(IEnumerable<Notificacao> notificacao)
        {
            Notificacoes.AddRange(notificacao);
        }
    }
}