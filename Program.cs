using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main()
        {
            var inputTab = new int[] { 1, 32, 7, 33 };
            Console.WriteLine("{0}", string.Join(" ", DoubleArrayForEvenInteger_Exercice.DoubleArrayForEvenInteger(inputTab)));
        }
    }
}
