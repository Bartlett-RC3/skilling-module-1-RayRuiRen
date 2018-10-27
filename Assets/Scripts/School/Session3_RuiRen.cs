using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3_RuiRen : MonoBehaviour
{
    public GameObject cubePrefab;
    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;
    public GameObject light;
    public GameObject objectReference;


    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity, this.transform);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        // Time
        Debug.Log("This computer can render a frame in : " + Time.deltaTime);
        Debug.Log("Since I started playing the game this amount of time has passed: " + Time.time);
        Debug.Log("Computer has counted this amount of frames " + Time.realtimeSinceStartup);

        //Translation
        //Move children gameobjects in x axis
        foreach (Transform child in this.transform)
        {

            child.Translate(0, 0, Random.Range(-1f, 1f));
        }

        //Rotating
        foreach (Transform child in this.transform)
        {
            //child.Rotate(0,Random.value,0);
            child.RotateAround(Vector3.up, Random.value);
        }

        //Scaling
        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(4,8), Random.Range(4, 8), Random.Range(4, 8));
        }

        Vector3[] originalScale = new Vector3[this.transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            originalScale[i] = transform.GetChild(i).localScale;
        }
        //Keyboard input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Transform child in this.transform)
            {
                child.localScale = child.localScale * 10f;
            }
        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localScale = originalScale[i];
            }


        }
        //Mouse Pressed (0 left , 1 right, 2 middle)

        if (Input.GetMouseButton(0)) {
            light.GetComponent<Light>().color = new Color(Random.Range(0,255), Random.Range(0, 255), Random.Range(0, 255));
        }

    }
}