using System;

namespace Filchagin_kt1;

public abstract class Property
{
    public float Worth { get; private set; }

    public Property(float worth)
    {
        Worth = worth;
    }

    public virtual float Tax()
    {
        return 0;
    }
}

