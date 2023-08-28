using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// A sofa.
/// </summary>
public class Sofa : IIndoorItem, IFurnitureItem
{
    public string Name { get; set; }
    public uint NumberOfLegs { get; set; }
    public RoomName RoomName { get; set; }

    public Sofa(string name, uint numberOfLegs, RoomName roomName)
    {
        Name = name;
        NumberOfLegs = numberOfLegs;
        RoomName = roomName;
    }

    public override string ToString()
    {
        return $"Sofa - {Name}, {NumberOfLegs} legs, {RoomName}";
    }
}

