using System;
namespace T5_2_5_Interfaces;


/// <summary>
/// Represents a plant.
/// </summary>
public interface IPlant : IBelonging
{
    /// <summary>
    /// The plants preferred conditions for optimum growth.
    /// </summary>
    string PreferredConditions { get; set; }
}

