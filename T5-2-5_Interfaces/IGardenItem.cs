using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// Describes items that belongs in the garden.
/// </summary>
public interface IGardenItem : IBelonging
{
    /// <summary>
    /// The location the item belongs in.
    /// </summary>
    GardenLocation GardenLocation { get; set; }
}
