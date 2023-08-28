using System;
using System.Xml.Linq;

namespace T5_2_5_Interfaces;


/// <summary>
/// A garden plant
/// </summary>
public class GardenPlant : IGardenItem, IPlant
{
    public string Name { get; set; }
    public GardenLocation GardenLocation { get; set; }
    public string PreferredConditions { get; set; }

    public GardenPlant(string name, GardenLocation gardenLoation, string preferredConditions)
    {
        Name = name;
        GardenLocation = gardenLoation;
        PreferredConditions = preferredConditions;
    }

    public override string ToString()
    {
        return $"Garden Plant - {Name}, {GardenLocation}, {PreferredConditions}";
    }
}

