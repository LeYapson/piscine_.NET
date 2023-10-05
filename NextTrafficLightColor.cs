using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            switch (currentColor)
            {
                case TrafficLightColor.Green:
                    return TrafficLightColor.Orange;
                case TrafficLightColor.Orange:
                    return TrafficLightColor.Red;
                case TrafficLightColor.Red:
                    return TrafficLightColor.Green;
                default:
                    return TrafficLightColor.None;
            }
            
        }
    }
}