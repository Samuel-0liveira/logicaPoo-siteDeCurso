using SiteDeCursos.NotificationContext;

namespace SiteDeCursos.SharedContext
{
    public abstract class ConteudoBase : Notificador
    {
        public ConteudoBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}