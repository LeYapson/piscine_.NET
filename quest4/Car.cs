using System;
namespace CSharpDiscovery.Quest04;

public class Car : Vehicule
{
    public string Model { get; set; }

    public Car() : base()
    {
        Model = "Unknown";
    }
    
    // Constructor with Model, Brand, Color, and CurrentSpeed
    public Car(string model, string brand, string color, int currentSpeed = 0) 
        : base(brand, color, currentSpeed)
    {
        Model = model;
    }

    public override string ToString()
    {
        return $"{Color} {Brand} {Model}";
    }

    public override void Accelerate(int Speed)
    {
        if (CurrentSpeed + Speed >= 180)
        {
            CurrentSpeed = 180;
        }
        else
        {
            CurrentSpeed += Speed;
        }
        
    }

    public override void Brake(int BrakePower)
    {
        if (CurrentSpeed - BrakePower <= 0)
        {
            CurrentSpeed = 0;
        }
        else
        {
            CurrentSpeed -= BrakePower;
        }
        
    }
}