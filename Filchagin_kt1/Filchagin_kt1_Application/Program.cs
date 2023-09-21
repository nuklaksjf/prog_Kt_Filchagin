using System;
using Filchagin_kt1;
internal static class Program
{
    private static void Main(string[] args)
    {
        Property[] properties = {
            new Appartment(5000000, 90),
            new Appartment(10000000, 150),
            new Appartment(100000000, 350),
            new Car(1000000, 150),
            new Car(2000000, 300),
            new Car(3000000, 350),
            new Boat(500000, 100),
            new Boat(700000, 150),
            new CountryHouse(3000000, 99),
            new CountryHouse(18000000, 500)
        };

        foreach (Property props in properties)
        {
            Console.WriteLine(props);
        }
    }
}

