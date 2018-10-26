using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Homework2Dog;

public class Session2Homework : MonoBehaviour
{
    // ii Write a for loop
    void HitTheTarget(int myAnswer)
    {
        var secreteLists = new List<int>();
        for (var i = 1; i <= 4; i++)
        {
            var secrets = Random.Range(1, 10);
            secreteLists.Add(secrets);
        }


        var array = secreteLists.ToArray();

        foreach (var numbers in array)
        {
            Debug.Log(numbers);
        }
        if (myAnswer == secreteLists[0] || myAnswer == secreteLists[1] || myAnswer == secreteLists[2] || myAnswer == secreteLists[3])
            Debug.Log("you win");
        else
        {
            Debug.Log("you lose");
        }
    }


    // i Write a function that uses a condition

    long phoneNumber = 447902980535;
    void Start ()
{
    if (phoneNumber % 12 == 86)
    {
        Debug.Log("It is from China");
    }
    else if (phoneNumber % 11 == 44)
    {
        Debug.Log("It is from the UK");
    }
    else
    {
        Debug.Log("Unknown");
    }
}




	
	// Update is called once per frame
	void Update () {
		
	}
}
