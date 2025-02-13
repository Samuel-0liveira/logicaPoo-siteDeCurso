using System.Collections.Generic;
using SiteDeCursos.SharedContext;

namespace SiteDeCursos.ContentContext
{
    public class Modulo : ConteudoBase
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }
        public required string Titulo { get; set; }

        public IList<Aula> Aulas { get; set; }
    }
}