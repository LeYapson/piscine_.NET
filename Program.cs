using System;
using System.Collections.Generic;
using CSharpDiscovery.Quest02;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new HashSet<string> { "Arnaud", "Marie", "Alexandre", "Audrey", "Adrien", "Mathilde", "Théophile", "Hanako" };
            var draw = SecretSanta_Exercice.SecretSantaDraw(people);

            foreach (KeyValuePair<string, string> pair in draw) {
                Console.WriteLine("{0} is offering to {1}", pair.Key, pair.Value);
            }
        }
    }
}