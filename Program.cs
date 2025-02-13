using System;
using SiteDeCursos.ContentContext;
using System.Linq;

namespace SiteDeCursos
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo sobre POO", "orientacao-objetos"));
            artigos.Add(new Artigo("Artigo sobre C#", "fundamentos-csharp"));
            artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

            /*foreach (var artigo in artigos)
            {
                Console.WriteLine(artigo.Id);
                Console.WriteLine(artigo.Titulo);
                Console.WriteLine(artigo.Url);
                Console.WriteLine("");
            }
            */

            var cursos = new List<Curso>();

            var cursoPOO = new Curso("Fundamentos POO", "fundamentos-poo");
            var cursoCsharp = new Curso("Fundamentos C#", "fundamentos-csharp");
            var cursoAspNet = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet");

            cursos.Add(cursoPOO);
            cursos.Add(cursoCsharp);
            cursos.Add(cursoAspNet);

            var carreiras = new List<Carreira>();

            var carreiraDotnet = new Carreira("Especialista .NET", "especialista-dotnet");

            var itemDeCarreira2 = new ItemDeCarreira(2, "Aprenda POO", " ", cursoPOO);
            var itemDeCarreira = new ItemDeCarreira(1, "Comece por aqui", "", cursoCsharp);
            var itemDeCarreira3 = new ItemDeCarreira(3, "Aprenda .NET", "", cursoAspNet);
            carreiraDotnet.Items.Add(itemDeCarreira2);
            carreiraDotnet.Items.Add(itemDeCarreira3);
            carreiraDotnet.Items.Add(itemDeCarreira);
            carreiras.Add(carreiraDotnet);

            foreach(var carreira in carreiras)
            {
                Console.WriteLine(carreira.Titulo);
                
                foreach(var item in carreira.Items.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                    Console.WriteLine(item.Curso?.Titulo);
                    Console.WriteLine(item.Curso?.Nivel);

                    foreach (var notificacao in item.Notificacoes)
                    {
                        Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
                    }
                }
            }
        }
    }
}