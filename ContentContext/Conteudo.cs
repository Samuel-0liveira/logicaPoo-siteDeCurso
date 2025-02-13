using System.Diagnostics.Contracts;
using SiteDeCursos.SharedContext;

namespace SiteDeCursos.ContentContext
{
    public abstract class Conteudo : ConteudoBase
    {
        public Conteudo(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }
        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}