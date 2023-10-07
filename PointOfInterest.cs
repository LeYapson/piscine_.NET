namespace CSharpDiscovery.Quest03;

public class PointOfInterest
{
    // Properties
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Name { get; set; }  // Nullable string

    // Static property
    public static string GoogleMapsUrlTemplate { get; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";   
}