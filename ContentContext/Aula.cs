using SiteDeCursos.ContentContext.Enums;

namespace SiteDeCursos.ContentContext
{
    public class Aula
    {
        public int Ordem { get; set; }
        public required string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
    }
}