namespace SiteDeCursos.ContentContext
{
    public class ItemDeCarreira
    {
        public int Ordem { get; set; }
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public required Curso Curso { get; set; }
    }
}