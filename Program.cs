using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            PointOfInterest PorteCailhau = new HistoricalMonument(44.838336, -0.569446, "Porte Cailhau", 1493);
            Console.WriteLine(PorteCailhau.ToString());
        }
    }
}