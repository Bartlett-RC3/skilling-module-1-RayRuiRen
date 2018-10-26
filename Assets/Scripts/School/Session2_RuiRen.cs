using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3Students;

public class Session2_RuiRen : MonoBehaviour {

    //Variables

    private int number1 = 10;
    private int number2 = 20;
    private int number3;
    private string someName = "name";

    private bool someBool = false;

    private string[] tutorNames = {"Dave","Tyson","Jordi","Octavian","Panos"};



	// Use this for initialization
	void Start ()
	{

        Student RuiRen = new Student("Rui", "Null", "Ren", 23, "China");
        Debug.Log(RuiRen.GetHomeCountry());
        Debug.Log(RuiRen.GetStudentName());


	    Debug.Log("A tutor is: " + tutorNames[0]);
	    Debug.Log("A tutor is: " + tutorNames[1]);
	    Debug.Log("A tutor is: " + tutorNames[2]);

        // Navigate data
        // For loop
	    for (int count = 0; count < number2 - 1; count++)
	    {
            Debug.Log("A tutor is: "+ tutorNames[count]);
	        
	    }

	    for (int i = tutorNames.Length - 1; i > 0; i--)
	    {
	        Debug.Log("Counting..." + i);
	    }

        //For each loop
	    foreach (var tutorNumber in tutorNames)
	    {
	        Debug.Log(tutorNumber);
	    }


        //Conditions
        if (number1<number2)  //Question
	    {
	        // Action if true
            Debug.Log("Number1 is smaller than number 2");
        }
	    else
	    {
            // Action if true
	        Debug.Log("Number1 is bigger than number 2");
        }

	    //Question we Canvas as
	    // If somgthing is smaller or bigger
	    //<>

	    //equal
	    //==

	    //Asking multiple question
	    //&&
	    if (number1 < number2 && someBool == true)
	    {
	        //Action
            Debug.Log("Answer to both questions is yes!");
	    }

	    if (number1 < number2 || someBool == true)
	    {
	        //Action
            Debug.Log("Answer to one of the questions is yes!");
	    }

        //Complex question by concatenation and by embedding sub questions

        if ((number1 < number2 && someBool == true)&&(someBool == true && someName == "name"))
        {
            Debug.Log("This question is too confusion! Simply please");
        }


        // Shorthand if 
	    number3 = (number1 < number2) ? 100 : 200;

	}





    // Update is called once per frame
    void Update () {
		
	}
}
