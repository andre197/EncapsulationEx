using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        Dictionary<string, Person> allPersons = new Dictionary<string, Person>();
        Dictionary<string, Product> allProducts = new Dictionary<string, Product>();

        string[] persons = Console.ReadLine().Trim().Split(';');
        foreach (var person in persons)
        {
            string[] sep = person.Split('=');
            try
            {
                Person per = new Person(sep[0], double.Parse(sep[1]));

                allPersons.Add(per.Name, per);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

        }
        string[] products = Console.ReadLine().Trim().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var product in products)
        {
            string[] sep = product.Split('=');
            try
            {
                Product prod = new Product(sep[0], double.Parse(sep[1]));
                allProducts.Add(prod.Name, prod);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        string input = Console.ReadLine();
        while (input != "END")
        {
            string[] command = input.Split();
            try
            {
                allPersons[command[0]].BuyProduct(allProducts[command[1]]);
                Console.WriteLine($"{command[0]} bought {command[1]}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            input = Console.ReadLine();
        }

        foreach (var person in allPersons)
        {
            Console.Write($"{person.Key} - ");

            if (person.Value.Bag.Count < 1)
            {
                Console.WriteLine("Nothing bought");
            }
            else
            {

                Console.Write(string.Join(", ", person.Value.Bag.Select(x => x.Name)));
                //int count = 0;
                //foreach (var inBag in person.Value.Bag)
                //{

                //    if (count == 0)
                //    {
                //        Console.Write(inBag.Name);
                //    }
                //    else
                //    {
                //        Console.Write(", " + inBag.Name);
                //    }
                //    count++;
                //}
            }
            Console.WriteLine();
        }

    }
}
