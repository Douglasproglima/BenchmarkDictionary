using System;
using BenchmarkDotNet.Running;

namespace BenchmarkDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Usando BenchmarkDotNet  ###\n");
            Console.WriteLine("Pressione algo para iniciar\n");
            Console.ReadLine();

            var resultado = BenchmarkRunner.Run<ValidarIteracaoDicionario>();
        }
    }
}
