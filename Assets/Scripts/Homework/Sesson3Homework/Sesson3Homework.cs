using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesson3Homework : MonoBehaviour {

    public GameObject cubePrefab;
    public float speed = 0.1f;
    public Material material;
    private Color originalColor;
    private Mesh mesh;


    void Start () {
    Instantiate(cubePrefab, this.transform);
    originalColor = material.color;
        cubePrefab.AddComponent<MeshFilter>().mesh = mesh;
        gameObject.AddComponent<MeshRenderer>().material = material;
    }

    void Update ()
	{
        // i Create a cube and move it across the screen

	    //First Method
        this.transform.Translate(speed, 0, 0);
	    //Second Method
        this.GetComponent<Transform>().transform.Translate(speed, 0, 0);


        // ii Create a cube and change its colour when key is pressed or mouse is pressed
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
	    {
            //First Method
            material.color = new Color(Random.value, Random.value, Random.value); 

            //Second Method
            //cubePrefab.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
	        this.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
            //SomeProblems
	    }
    }

    void OnApplicationQuit()
    {
        material.color = originalColor;
    }
}
