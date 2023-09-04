using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_2_4_ClassAndStruct;

public sealed class ElectricCar : Car
{
    public override Transmission Transmission => Transmission.Automatic;

    // Implementing a getter as a function.
    public override string VehicleType
    {
        get
        {
            return "Electric Car";
        }
    }

    public ElectricCar(string name, double milesPerKwh, double batteryCapacityKwh) : base(name)
    {
        MilesPerKwh = milesPerKwh;
        BatteryCapacityKwh = batteryCapacityKwh;
    }

    /// <summary>
    /// yo
    /// </summary>
    public double MilesPerKwh { get; private set; }
     
    /// <summary>
    /// yo2
    /// </summary>
    public double BatteryCapacityKwh { get; private set; }

    //public double KwhPerHundredKilometers
    //{
    //    get
    //    {
    //        return 100 / (1.6 * MilesPerKwh);
    //    }
    //}

    //public double KwhPerHundredKilometers => 100 / (1.6 * MilesPerKwh);

    public override double GetRange() => MilesPerKwh * BatteryCapacityKwh;

    public override string ToString()
    {
        return $"{VehicleType} - {Name}, {MilesPerKwh:N2} M/kWh, {BatteryCapacityKwh:N2} kWh";
    }
}
