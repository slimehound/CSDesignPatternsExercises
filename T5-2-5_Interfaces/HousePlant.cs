using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// A house plant
/// </summary>
public class HousePlant : IIndoorItem, IPlant
{
    public string Name { get; set; }
    public RoomName RoomName { get; set; }
    public string PreferredConditions { get; set; }

    public HousePlant(string name, RoomName roomName, string preferredConditions)
    {
        Name = name;
        RoomName = roomName;
        PreferredConditions = preferredConditions;
    }

    public override string ToString()
    {
        return $"House Plant - {Name}, {RoomName}, {PreferredConditions}";
    }
}

