
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Pizza pizza = null;
        List<Topping> toppings = new List<Topping>();
        Dough dough = null;

        string pizzaName = null;
        int pizzaNofToppings = 0;

        int cnt = 0;
        while (cnt <= pizzaNofToppings)
        {

            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "END")
            {
                break;
            }

            if (input[0] == "Pizza")
            {
                pizzaName = input[1];
                pizzaNofToppings = int.Parse(input[2]);
                if (pizzaNofToppings<0||pizzaNofToppings>10)
                {
                    Console.WriteLine("Number of toppings should be in range [0..10].");
                    return;
                }
            }
            else if (input[0] == "Dough")
            {
                try
                {
                    string flourType = input[1];
                    string backingTechnique = input[2];
                    double weight = double.Parse(input[3]);

                    dough = new Dough(flourType, backingTechnique, weight);


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;

                }
            }
            else if (input[0] == "Topping")
            {
                try
                {
                    string name = input[1];
                    double weight = double.Parse(input[2]);

                    Topping topping = new Topping(name, weight);

                    toppings.Add(topping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                cnt++;
            }
        }

        if (pizzaName == null)
        {
            try
            {

                pizza = new Pizza(pizzaName, pizzaNofToppings, toppings, dough);
                Console.WriteLine($"{pizza.Name} - {pizza.GetSumOfCalories():f2} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        else if (b)
        {
            
        }
        

    }
}

