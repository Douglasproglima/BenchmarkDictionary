``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1526 (21H2)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.102
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|                          Method |       Mean |    Error |    StdDev |     Median | Rank |  Gen 0 | Allocated |
|-------------------------------- |-----------:|---------:|----------:|-----------:|-----:|-------:|----------:|
|       SubDictionaryKeyValuePair | 1,528.7 μs | 48.09 μs | 141.79 μs | 1,584.5 μs |    3 |      - |     544 B |
|            SubDictionaryForLoop |   782.4 μs | 15.42 μs |  27.81 μs |   792.8 μs |    1 |      - |     496 B |
| SubDictionaryParallelEnumerable |   807.4 μs | 16.05 μs |  27.69 μs |   820.7 μs |    2 | 5.8594 |  22,345 B |
|         SubDictionaryStringJoin |   780.6 μs | 15.41 μs |  28.94 μs |   792.9 μs |    1 |      - |     480 B |
