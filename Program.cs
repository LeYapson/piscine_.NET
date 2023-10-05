using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            Console.WriteLine(BeginsWithSpecificCharacter_Exercice.BeginsWithSpecificCharacter("helloworld", 'h'));
            Console.WriteLine(BeginsWithSpecificCharacter_Exercice.BeginsWithSpecificCharacter("helloworld", 'w'));
        }
    }
}