using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{
    // i. Declare a int variable and set a value
    public int publicationYear = 2018;

    // ii. Declare a float variable and set a value
    float price = 5.0f;

    // iii. Declare a string variable and set a value
    private string name = "The Bartlett School of Architecture of Architecture UCL B-Pro Show 2018";

    // iv. Create a function that prints the declared variables
    void PrintBookInformation()
    {
        Debug.Log(publicationYear);
        Debug.Log(price);
        Debug.Log(name);
    }

    // v. Declare and initialize an array
    string[,] famousArchitects = new string[2, 3]
    {
        {"Frank Lloyd Wright" , "Frank Gehry" , "Zaha Hadid"},
        {"Le Corbusier" , "Ludwig Mies van der Rohe" , "Philip Johnson"}
    };

    // vi. Declare and initialize a list
    List<string> futureArchitects = new List<string>( ){"RR"};

    // vii.Create and initialize a Dictionary
    Dictionary<string, string> architects = new Dictionary<string, string>();





    //"You need to pay!"
    float receipt(float number, float price)
    {
        number = Convert.ToInt32(futureArchitects);
        return number * price;
    }



    void Start()
    {
        futureArchitects.Add("CBR");
        futureArchitects.Add("WXW");
        futureArchitects.Add("SLY");
        Debug.Log(futureArchitects[futureArchitects.Count - 1]);



        architects.Add("1800s", "Alvar Aalto");
        architects.Add("1800s", "Buckminster Fuller");
        architects.Add("1900s", "Oscar Niemeyer");
        architects.Add("1900s", "Louis Kahn");
        if (architects.ContainsKey("1900s"))
        {
            Debug.Log( architects.Values + " is born in :"+ architects.Keys);
            //string output = string.Format( "{0} is born in : {1}",architects.Values,architects.Keys);
            //Console.WriteLine(output);
        }
    }


}	


