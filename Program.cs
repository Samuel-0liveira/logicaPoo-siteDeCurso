using System;
using SiteDeCursos.ContentContext;

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

            foreach (var artigo in artigos)
            {
                Console.WriteLine(artigo.Id);
                Console.WriteLine(artigo.Titulo);
                Console.WriteLine(artigo.Url);
                Console.WriteLine("");
            }
        }
    }
}