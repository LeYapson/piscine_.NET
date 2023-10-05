using System.Linq; // Required for the Contains method

namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            if (tab == null)
            {
                return false;
            }

            if (tab.Contains(value))
            {
                return true;
            }

            return false;
        }
    }
}