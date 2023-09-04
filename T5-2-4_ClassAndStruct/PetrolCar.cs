using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_2_4_ClassAndStruct;

public sealed class PetrolCar : Car
{
    private readonly Transmission transmission;
    public override Transmission Transmission
    {
        get
        {
            return transmission;
        }
    }

    // Implementing a getter as a function.
    public override string VehicleType
    {
        get
        {
            return "Petroleum Car";
        }
    }

    public PetrolCar(string name, Transmission transmission, double milesPerGallon, double tankSizeLitres) : base(name)
    {
        this.transmission = transmission;

        MilesPerGallon = milesPerGallon;
        TankSizeLitres = tankSizeLitres;
    }

    public double MilesPerGallon { get; private set; }

    public double TankSizeLitres { get; private set; }

    public override double GetRange() => MilesPerGallon * TankSizeLitres * 0.21997;

    public override string ToString()
    {
        return $"{VehicleType} - {Name} ({Transmission}), {MilesPerGallon:N2} MPG, {TankSizeLitres:N2} l";
    }
}


