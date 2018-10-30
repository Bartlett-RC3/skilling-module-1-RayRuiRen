using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenScript : MonoBehaviour
{
    public bool seen;
    private Vector3 scale;

    void Start()
    {
        scale = GetComponent<Transform>().localScale;
    }

    void Update()
    {
        if (!seen)
        {
            //GetComponent<Transform>().localScale = scale;
            GetComponent<MeshRenderer>().enabled = true;
            
        }
        else
        {
            //GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
            GetComponent<MeshRenderer>().enabled = false;

        }
        seen = false;

    }
}
