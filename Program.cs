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

            var itemDeCarreira2 = new ItemDeCarreira(2, "Aprenda POO", "O segundo passo para se tornar um especialista .NET", cursoCsharp);
            var itemDeCarreira = new ItemDeCarreira(1, "Comece por aqui", "O primeiro passo para se tornar um especialista .NET", cursoCsharp);
            var itemDeCarreira3 = new ItemDeCarreira(3, "Aprenda .NET", "O terceiro passo para se tornar um especialista .NET", cursoCsharp);
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
                }
            }
        }
    }
}