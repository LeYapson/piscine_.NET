namespace CSharpDiscovery.Quest01
{
    public class IsOdd_Exercice
    {
        public static bool IsOdd(int a)
        {
            if (a % 2 == 0 || a == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}