using System;

namespace Filchagin_kt1;

public class Immovable : Property
{
    private float _square;
    public Immovable(float worth, float square) : base(worth)
    {
        _square = square;
    }
    public override float Tax()
    {
        float tax = 1f;
        switch (_square)
        {
            case <= 100:
            {
                tax = Worth / 500;
                break;
            }
            case > 100 and <= 300:
            {
                tax = Worth / 350;
                break;
            }
            case > 300:
            {
                tax = Worth / 250;
                break;
            }
        }
        return tax;
    }

    public float CostPerMetrSquare()
    {
        return Worth / _square;
    }

    public override string ToString()
    {
        return $"Стоимость:{Worth}, налог: {Tax()},площадь: {_square}.";
    }
}

