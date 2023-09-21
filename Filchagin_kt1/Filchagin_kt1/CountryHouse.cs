using System;

namespace Filchagin_kt1;

public class CountryHouse : Immovable
{
    public CountryHouse(float worth,float square): base(worth,square)
    {
        
    }
    public override string ToString()
    {
        Console.Write("Загородный дом-");
        return base.ToString();
    }
}