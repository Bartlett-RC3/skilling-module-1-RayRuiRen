using UnityEngine;
//My custom class (object)

public class Humans : MonoBehaviour 
{
    // Properties
    string objectName = "RuiRen";
    private int age = 32;
    float height = 170.5f;
    float energy = 100;

    //Behaviors
    void Walking()
    {
    }
    void Sleeping()
    {
    }
    void Eating()
    {
    }
    void WorkingOut()
    {
        energy--;
    }


}