using System;

namespace Filchagin_kt1;

public class Appartment : Immovable
{
    public Appartment(float worth,float square): base(worth,square)
    {
        
    }
    public override string ToString()
    {
        Console.Write("Аппартаменты-");
        return base.ToString();
    }
}