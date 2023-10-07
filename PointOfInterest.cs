﻿using System.Net;

namespace CSharpDiscovery.Quest03;

public class PointOfInterest
{
    // Properties
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Name { get; set; }  // Nullable string

    // Static property
    public static string GoogleMapsUrlTemplate { get; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

   //default constructor
    public PointOfInterest()
    {
        Name = "Bordeaux Ynov Campus";
        Latitude = 44.854186;
        Longitude = -0.5663056;
    }
    
    //parameterized constructor
    public PointOfInterest(string name, double latitude, double longitude)
    {
        Name = name;
        Latitude = latitude;
        Longitude = longitude;
    }
    
    // Method to get Google Maps URL
    public string GetGoogleMapsUrl()
    {
        string encodedName = WebUtility.UrlEncode(Name);
        return string.Format(GoogleMapsUrlTemplate, encodedName, Latitude, Longitude);
    }
    
    // Override the ToString method
    public override string ToString()
    {
        return $"{Name} (Lat={Latitude}, Long={Longitude})";
    }
}