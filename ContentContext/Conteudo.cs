using System.Diagnostics.Contracts;

namespace SiteDeCursos.ContentContext
{
    public abstract class Conteudo
    {
        public Conteudo()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public required string Titulo { get; set; }
        public required string Url { get; set; }
    }
}