using System;



public class Dough
{
    private string flourType;
    private string backingTechnique;
    private double weight;
    private double baseModifier = 2;
    

    public Dough(string flourType, string backingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BackingTechnique = backingTechnique;
        this.Weight = weight;
    }

    private string FlourType
    {
        set
        {
            if (value.ToLower()!="white" && value.ToLower()!= "wholegrain")
            {
                InvalidDough();
            }
            this.flourType = value;
        }
    }
    private string BackingTechnique
    {

        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                InvalidDough();
            }
            this.backingTechnique = value;
        }
    }


    private double Weight
    {

        set
        {
            if (value<=0 || value>200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }

    public double CaloriesPerGram()
    {
        double flourTypeValue = GetFlourTypeValue();
        double backingTechniqueValue = GetBackingTechniqueValue();
        double weight = this.weight;

        double calPerGram = (2 * weight) * flourTypeValue * backingTechniqueValue;
        return calPerGram;
    }

    private double GetFlourTypeValue()
    {
        if (this.flourType.ToLower() == "white")
        {
            return 1.5;
        }
        return 1;
    }

    private double GetBackingTechniqueValue()
    {
        if (this.backingTechnique.ToLower() == "crispy")
        {
            return 0.9;
        }
        if (this.backingTechnique.ToLower() == "chewy")
        {
            return 1.1;
        }
        return 1;
    }


    private void InvalidDough()
    {
        throw new ArgumentException("Invalid type of dough.");
    }
}

