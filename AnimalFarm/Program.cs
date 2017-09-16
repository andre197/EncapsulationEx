
using System;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        
        Chicken chick = null;

        try
        {
            chick = new Chicken(name, age);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine($"Chicken {chick.Name} (age {chick.Age}) can produce {chick.productPerDay()} eggs per day.");

    }
}

