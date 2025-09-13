using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {

        Chicken chicken1 = new Chicken("ChickyNub",15,15);
        Cow cow1 = new Cow("MilkeeWay", 30, 5);

        Debug.Log("-- Welcome to Farm Sim  --");
        Debug.Log($"= {chicken1.Name} and {cow1.Name} are living in the farm =");

        //Chicken
        chicken1.GetStatus();

        chicken1.MakeSound();

        chicken1.Feed("corn");

        chicken1.GetStatus();

        chicken1.Sleep();

        chicken1.GetStatus();

        Debug.Log("");

        //Cow
        cow1.GetStatus();

        cow1.MakeSound();

        cow1.Feed("Hay");

        cow1.GetStatus();

        cow1.Moo();

    }

}
