using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// Describes items that belong indoors.
/// </summary>
public interface IIndoorItem : IBelonging
{
    /// <summary>
    /// The room the item belongs in.
    /// </summary>
    RoomName RoomName { get; set; }
}
