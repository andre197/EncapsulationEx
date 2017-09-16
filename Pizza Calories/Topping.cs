
using System;

public class Topping
{
    private string name;
    private double weight;

    public Topping(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    private string Name
    {
        set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.name = value;
        }
    }

    private double Weight
    {

        set
        {
            if (value <= 0 || value > 50)
            {
                throw new ArgumentException($"{this.name} weight should be in the range [1..50].");
            }
            this.weight = value;
        }
    }

    public double Calories()
    {
        double nameValue = GetCaloriesValue();
        double calories = 2 * this.weight * nameValue;
        return calories;
    }

    private double GetCaloriesValue()
    {
        if (this.name.ToLower() == "meat")
        {
            return 1.2;
        }
        if (this.name.ToLower() == "veggies")
        {
            return 0.8;
        }
        if (this.name.ToLower() == "cheese")
        {
            return 1.1;
        }
        return 0.9;
    }
}

