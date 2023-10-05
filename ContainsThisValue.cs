namespace CSharpDiscovery.Quest02
{
    public class ContainsThisValue_Exercice
    {
        public static bool ContainsThisValue(int[] tab, int value)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == value)  // Corrected this line
                {
                    return true;
                }
            }

            return false;
        }
    }
}