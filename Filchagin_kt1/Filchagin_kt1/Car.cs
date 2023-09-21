using System;

namespace Filchagin_kt1;

public class Car : Vehicle
{
    public Car(float worth,float engineCapacity): base(worth,engineCapacity)
    {
        
    }

    public override string ToString()
    {
        Console.Write("Машина-");
        return base.ToString();
    }
}