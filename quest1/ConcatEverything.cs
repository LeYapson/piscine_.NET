namespace CSharpDiscovery.Quest01
{
    public class ConcatEverything_Exercice
    {
        public static string ConcatEverything(params string[] str)
        {
            string concatenatedString = string.Join("", str);
            return concatenatedString;
        }
    }
}