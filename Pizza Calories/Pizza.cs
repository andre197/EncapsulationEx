using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private int numberOfToppings;
    private List<Topping> toppings;
    private Dough dough;

    public Pizza(string name,int numberOfToppings, List<Topping> toppings, Dough dough)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = toppings;
        this.dough = dough;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length>15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    private int NumberOfToppings
    {
        set
        {
            if (value<0||value>10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.numberOfToppings = value;
        }
    }

    public IReadOnlyCollection<Topping> Toppings
    {
        get { return this.toppings.AsReadOnly(); }
    }

    public double GetSumOfCalories()
    {
        double doughCal = this.dough.CaloriesPerGram();
        double toppingsCallories = this.toppings.Sum(x => x.Calories());
        double result = doughCal + toppingsCallories;
        return result;
    }
}

