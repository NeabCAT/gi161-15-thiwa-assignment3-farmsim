using Unity.VisualScripting;
using UnityEngine;

class Chicken
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
        set { if (value > 50) hunger = 50;
              else if (value < 0) hunger = 0;
              else hunger = value; 
            }
    }

    private int happiness;
    public int Happiness //Property
    { 
        get { return happiness; }
        set { if(value > 50) happiness = 50;
              else if (value < 0) happiness = 0;
              else happiness = value;       
            }
    }

    private int eggs;
    public int Eggs //Property
    {
        get { return eggs; }
        set { if (value < 0) eggs = 0;
            else eggs = value;
            }
    }

    public Chicken(string newName, int newHunger , int newhappiness) 
    { 
        Name = newName;
        Hunger = newHunger;
        Happiness = newhappiness;
        Eggs = 0;
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
        Debug.Log($"{Name} say Clucks!! ");
    }

    public void Feed(string food)
    {
        AdjustHunger(-10);
        AdjustHappiness(10);
        Debug.Log($"{Name} eats {food} happily. ");
        
    }

    public void GetStatus()
    {
        Debug.Log($"Name chicken is : {Name} | Hunger : {Hunger} | Happiness : {Happiness} | Eggs : {Eggs} ");
    }

    public void Sleep()
    {
        AdjustHunger(2);
        AdjustHappiness(15);
        Debug.Log($"{Name} slept and feels a little hungry, but very happy! ");

    }

}