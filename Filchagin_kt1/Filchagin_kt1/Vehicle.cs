using System;

namespace Filchagin_kt1;

public class Vehicle : Property
{
    private float _engineСapacity;
    public Vehicle(float worth, float engineСapacity) : base(worth)
    {
        _engineСapacity = engineСapacity;
    }

    public override float Tax()
    {
        return Worth * _engineСapacity / 3000;
    }

    public override string ToString()
    {
        return $"Стоимость:{Worth}, налог{Tax()},объем двигателя{_engineСapacity}.";
    }
}

