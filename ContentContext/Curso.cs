using System.Data;

namespace SiteDeCursos.ContentContext
{
    public class Curso : Conteudo
    {
        public Curso()
        {
            Modulos = new List<Modulo>();
        }
        public required string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
    }

    public class Modulo
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }
        public required string Titulo { get; set; }

        public IList<Aula> Aulas { get; set; }
    }

    public class Aula
    {
        public int Ordem { get; set; }
        public required string Titulo { get; set; }
    }
}