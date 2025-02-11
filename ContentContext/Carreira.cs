namespace SiteDeCursos.ContentContext
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url) : base(titulo, url)
        {
            Items = new List<ItemDeCarreira>();
        }
        public IList<ItemDeCarreira> Items { get; set; }
        public int TotalDeCursos => Items.Count;
    }
}