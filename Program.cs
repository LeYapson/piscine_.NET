using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(ContainsSpecificSubstring_Exercice.ContainsSpecificSubstring("helloworld", "hello"));
            Console.WriteLine(ContainsSpecificSubstring_Exercice.ContainsSpecificSubstring("helloworld", "monde"));
        }
    }
}