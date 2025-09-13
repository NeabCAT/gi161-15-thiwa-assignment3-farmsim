using UnityEngine;
class Cow
{
    private string name;
    public string Name //Property
    {
        get { return name; }
        set { name = value; }
    }

    private int hunger;
    public int Hunger //Property
    {
        get { return hunger; }
        set
        {
            if (value > 50) hunger = 50;
            else if (value < 0) hunger = 0;
            else hunger = value;
        }
    }

    private int happiness;
    public int Happiness //Property
    {
        get { return happiness; }
        set
        {
            if (value > 50) happiness = 50;
            else if (value < 0) happiness = 0;
            else happiness = value;
        }
    }

    private float milk;
    public float Milk //Property
    {
        get { return milk; }
        set
        {
            if (value < 0) milk = 0;
            else milk = value;
        }
    }

    public Cow(string newName, int newHunger, int newhappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newhappiness;
        Milk = 0f;
    }

    public void AdjustHunger(int amount)
    {
        Hunger += amount;
    }

    public void AdjustHappiness(int valueHappy) 
    { 
        Happiness += valueHappy;
    }

    public void MakeSound()
    {
        Debug.Log($"{Name} says Moo!! ");
    }

    public void Feed(string food)
    {
        AdjustHunger(-20);
        AdjustHappiness(10);
        Debug.Log($"{Name} eats {food} happily. ");

    }

    public void GetStatus()
    {
        Debug.Log($"Name cow is : {Name} | Hunger : {Hunger} | Happiness : {Happiness} | Milk : {Milk} ");
    }

    public void Moo()
    {
        AdjustHappiness(15);
        Debug.Log($"{Name} gives a lound MooMooMoo!! | Current Happiness : {Happiness} ");
    }

}