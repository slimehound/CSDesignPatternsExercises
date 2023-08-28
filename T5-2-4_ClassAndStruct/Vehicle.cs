using System;
namespace T5_2_4_ClassAndStruct;

/// <summary>
/// An abstract vehicle class.
/// </summary>
public abstract class Vehicle
{
    /// <summary>
    /// The type of vehicle in question.
    /// </summary>
    public abstract string VehicleType { get; }


    /// <summary>
    /// The number of wheels the vehicle has.
    /// </summary>
    public abstract int NumberOfWheels { get; }


    /// <summary>
    /// The vehicles type of transmission.
    /// </summary>
    public abstract Transmission Transmission { get; }


    /// <summary>
    /// The vehicle's name, set in the constructor.
    /// </summary>
    public string Name { get; private set; }


    public Vehicle(string name)
    {
        Name = name;
    }
}

