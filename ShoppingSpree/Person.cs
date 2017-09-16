using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private double money;
    private List<Product> bag;

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public double Money
    {
        get { return this.money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }
    public List<Product> Bag { get; set; }
   

    public void BuyProduct(Product prod)
    {
        if (this.Money >= prod.Price)
        {
            this.Money -= prod.Price;
            this.Bag.Add(prod);
        }
        else
        {
            throw new ArgumentException($"{this.Name} can't afford {prod.Name}");
        }
    }


}