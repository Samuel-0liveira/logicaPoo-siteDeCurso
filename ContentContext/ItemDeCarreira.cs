using SiteDeCursos.NotificationContext;

namespace SiteDeCursos.ContentContext
{
    public class ItemDeCarreira : ConteudoBase
    {
        public ItemDeCarreira(int ordem, string titulo, string descricao, Curso curso)
        {
            if (curso == null) {
                AddNotificacao(new Notificacao("Curso", "Curso inválido"));
            }

            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso? Curso { get; set; }
    }
}