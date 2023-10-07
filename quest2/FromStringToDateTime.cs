using System;
using System.Globalization;

namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            if (string.IsNullOrEmpty(dateStr))
                throw new ArgumentException("Input string cannot be null or empty.");

            try
            {
                DateTime result = DateTime.ParseExact(dateStr, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                return result;
            }
            catch (FormatException)
            {
                throw new FormatException($"Input string '{dateStr}' is not in the correct format.");
            }
        }
    }
}