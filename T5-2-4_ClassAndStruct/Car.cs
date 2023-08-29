using System;
namespace T5_2_4_ClassAndStruct;


/// <summary>
/// A standard car.
/// </summary>
public abstract class Car : Vehicle
{
    private Transmission transmission;

    public Car(string name, Transmission transmission) : base(name)
    {
        this.transmission = transmission;
    }

    // Implementing a getter as a function.
    public override string VehicleType
    {
        get
        {
            return "Car";
        }
    }
    
    // Impementing a getter with a Lambda.
    public override int NumberOfWheels => 2;

    //private readonly Transmission transmission;
    //public override Transmission Transmission
    //{
    //    get
    //    {
    //        return transmission;
    //    }
    //}

    //public Car(string name, Transmission transmission) : base(name)
    //{
    //    this.transmission = transmission;
    //}

    public override string ToString()
    {
        return $"{VehicleType} - {Name} ({Transmission})";
    }
}
