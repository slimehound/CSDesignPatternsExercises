using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// A garden bench.
/// </summary>
public class Bench : IGardenItem, IFurnitureItem
{
    public string Name { get; set; }
    public uint NumberOfLegs { get; set; }
    public GardenLocation GardenLocation { get; set; }

    public Bench(string name, uint numberOfLegs, GardenLocation gardenLocation)
    {
        Name = name;
        NumberOfLegs = numberOfLegs;
        GardenLocation = gardenLocation;
    }

    public override string ToString()
    {
        return $"Bench - {Name}, {NumberOfLegs} legs, {GardenLocation}";
    }
}

