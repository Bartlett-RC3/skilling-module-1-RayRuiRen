using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sessoin3JustForFun : MonoBehaviour
{
    // Scale a cube bigger and smaller, copy the localscale when click space bar.
    
    private float timeImi;

    public float scale = 10;
    public float speed = 10;

    public GameObject cube;
    public GameObject newC ;


    void Start()
    {
        Vector3 ori = cube.transform.position;
        Instantiate(cube, ori, Quaternion.identity, this.transform);
    }


    void Update()
    {

        Vector3 ori = cube.transform.position;

        if (Time.realtimeSinceStartup % speed < speed / 2)
            timeImi = Time.realtimeSinceStartup % (speed / 2);
        else
        {
            timeImi = speed - Time.realtimeSinceStartup % speed;
        }

        this.transform.localScale = new Vector3(timeImi * scale + 1f, timeImi * scale + 1f, timeImi * scale + 1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            newC.transform.localScale = new Vector3(timeImi * scale + 1f, timeImi * scale + 1f, timeImi * scale + 1f);
            newC = Instantiate(newC, this.transform.position, this.transform.rotation);
        }
        newC.AddComponent<Rigidbody>();
    }

    void OnApplicationQuit()
    {
        newC.transform.localScale = cube.transform.localScale;
    }

}