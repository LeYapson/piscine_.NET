using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDiscovery.Quest02
{
    public class SecretSanta_Exercice
    {
        public static Dictionary<string, string> SecretSantaDraw(HashSet<string> people)
        {
            if (people == null || !people.Any())
            {
                throw new ArgumentException("People set cannot be null or empty.");
            }

            List<string> shuffledPeople = people.ToList();
            Random rng = new Random();
            
            // Shuffle the list using Fisher-Yates shuffle
            for (int i = shuffledPeople.Count - 1; i > 0; i--)
            {
                int j = rng.Next(0, i + 1);
                string temp = shuffledPeople[i];
                shuffledPeople[i] = shuffledPeople[j];
                shuffledPeople[j] = temp;
            }

            Dictionary<string, string> assignments = new Dictionary<string, string>();
            for (int i = 0; i < shuffledPeople.Count - 1; i++)
            {
                assignments[shuffledPeople[i]] = shuffledPeople[i + 1];
            }

            // Assign last person to first person
            assignments[shuffledPeople[^1]] = shuffledPeople[0];

            return assignments;
        }
    }
}