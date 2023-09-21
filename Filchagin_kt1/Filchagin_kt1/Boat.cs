using System;

namespace Filchagin_kt1;

public class Boat : Vehicle
{
    public Boat(float worth,float engineCapacity): base(worth,engineCapacity)
    {
        
    }
    public override string ToString()
    {
        Console.Write("Лодка-");
        return base.ToString();
    }
}