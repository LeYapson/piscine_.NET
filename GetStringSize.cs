namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
            if (str == "")
            {
                return 0;
                
            }
            else
            {
                int numberOfLetters = str.Length;
                return numberOfLetters;  
            }
            
        }
    }
}