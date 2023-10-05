using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            switch (currentColor)
            {
                case Models.TrafficLightColor.Green:
                    return Models.TrafficLightColor.Orange;
                case Models.TrafficLightColor.Orange:
                    return Models.TrafficLightColor.Red;
                case Models.TrafficLightColor.Red:
                    return Models.TrafficLightColor.Green;
                default:
                    return Models.TrafficLightColor.None;
            }
            
        }
    }
}