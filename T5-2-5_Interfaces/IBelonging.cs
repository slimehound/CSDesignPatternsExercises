using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// A general item that can be owned by an individual.
/// </summary>
public interface IBelonging
{
    /// <summary>
    /// The item's name.
    /// </summary>
    string Name { get; set; }
}

