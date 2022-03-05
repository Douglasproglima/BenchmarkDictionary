using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchmarkDictionary
{
    [RankColumn]
    [MemoryDiagnoser]
    public class ValidarIteracaoDicionario
    {
        private Dictionary<int, string> mesesDoAno = new Dictionary<int, string>
        {
            {1,"Janeiro" },
            {2,"Fevereiro" },
            {3,"Março" },
            {4,"Abril" },
            /*{5,"Maio" },
            {6,"Junho" },
            {7,"Julho" },
            {8,"Agosto" },
            {9,"Setembro" },
            {10,"Outubro" },
            {11,"Novembro" },
            {12,"Dezembro" }*/
        };

        [Benchmark]
        public void SubDictionaryKeyValuePair()
        {
            foreach (KeyValuePair<int, string> entry in mesesDoAno)
                Console.WriteLine($"{entry.Key}: {entry.Value}");

            foreach (var key in mesesDoAno.Keys)
            {
                var value = mesesDoAno[key];
                Console.WriteLine($"{key}: {value}");
            }
        }

        [Benchmark]
        public void SubDictionaryForLoop()
        {
            for (int index = 0; index < mesesDoAno.Count; index++)
            {
                KeyValuePair<int, string> mes = mesesDoAno.ElementAt(index);

                Console.WriteLine($"{mes.Key} : {mes.Value}");
            }
        }

        [Benchmark]
        public void SubDictionaryParallelEnumerable()
        {
            mesesDoAno
                .AsParallel()
                .OrderBy(mes => mes.Key)
                .ForAll(mes => Console.WriteLine($"{mes.Key} : {mes.Value}"));
        }

        [Benchmark]
        public void SubDictionaryStringJoin()
        {
            Console.WriteLine(String.Join(Environment.NewLine, mesesDoAno));
        }
    }
}
