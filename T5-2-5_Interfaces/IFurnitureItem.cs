using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// Represents an item of furniture.
/// </summary>
public interface IFurnitureItem : IBelonging
{
    /// <summary>
    /// The furniture item's name.
    /// </summary>
    public string Name { get; set; }


    /// <summary>
    /// Number of legs the furniture has.
    /// </summary>
    public uint NumberOfLegs { get; set; }
}
