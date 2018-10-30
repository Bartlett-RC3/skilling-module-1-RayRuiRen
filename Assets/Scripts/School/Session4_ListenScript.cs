using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_ListenScript : MonoBehaviour
{
    public bool seen ;

	void Start () {
		
	}
	
	void Update ()
	{
        if (!seen){
	        GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
	        GetComponent<MeshRenderer>().material.color = Color.red;
        }
	    seen = false;
    }
}
