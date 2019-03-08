using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    // Ray casting steps 
	    // Step1 : Create ray
	    Vector3 raycastingDirection = transform.forward;

	    // Step 2 : See hat object is in front of me
	    RaycastHit objectInFront;

	    // Step 3 ; Do something with the object in front of me
	    if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
	    {
	        Debug.Log("Object in front is" + objectInFront.transform.name);
	        if (objectInFront.transform.GetComponent<ListenScript>()!=null)
	        {
	        objectInFront.transform.GetComponent<ListenScript>().seen = true;

}
        }
	}

}

