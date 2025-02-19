using SiteDeCursos.ContentContext.Enums;
using SiteDeCursos.SharedContext;

namespace SiteDeCursos.ContentContext
{
    public class Aula : ConteudoBase
    {
        public int Ordem { get; set; }
        public required string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
    }
}