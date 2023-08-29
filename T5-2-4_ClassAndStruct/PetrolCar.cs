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

    public PetrolCar(string name, Transmission transmission) : base(name, transmission)
    {
        this.transmission = transmission;
    }
}


