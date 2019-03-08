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

        ///// IF 
        //if (!seen)
        //{
        //    //GetComponent<Transform>().localScale = scale;
        //    if (GetComponent<MeshRenderer>() != null)
        //    {
        //        GetComponent<MeshRenderer>().enabled = true;
        //    }
        //}



        if (seen)
        {
            //GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
            if (GetComponent<MeshRenderer>() != null)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }

        }
        seen = false;

    }
}
