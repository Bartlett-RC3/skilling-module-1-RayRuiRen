using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session6 : MonoBehaviour
{


    // Variables 
    public GameObject cube;

    private MeshRenderer meshRender;


    IEnumerator createCubeCoroutine;
    IEnumerator createStartCoroutine;



    // Use this for initialization 
    void Start()
    {
        createCubeCoroutine = DropCubes();
        createStartCoroutine = ChangeColors();

        meshRender = GetComponent<MeshRenderer>();


        StartCoroutine(createCubeCoroutine);
        Debug.Log(Time.time);
        if (Time.time > 2)
        {
            StopCoroutine(createCubeCoroutine);
            StopAllCoroutines();
        }

        StartCoroutine(createStartCoroutine);
        Debug.Log(Time.time);
        if (Time.time > 2)
        {
            StopCoroutine(createStartCoroutine);
            StopAllCoroutines();
        }





    }


    // Update is called once per frame 
    void Update()
    {
        Debug.Log(Time.time);
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.K))
        {
            Time.timeScale = 1;
        }

        //StartCoroutine(createCubeCoroutine);
        //Debug.Log(Time.time);
        //if (Time.time > 10)
        //{
        //    StopCoroutine(createCubeCoroutine);
        //    StopAllCoroutines();
        //}

        //StartCoroutine(createStartCoroutine);
        //Debug.Log(Time.time);
        //if (Time.time > 5)
        //{
        //    StopCoroutine(createStartCoroutine);
        //    StopAllCoroutines();
        //}

    }






    // Coroutines 
    IEnumerator DropCubes()
    {
        while (true)
        {
            Vector3 cubePosition = new Vector3(UnityEngine.Random.Range(-100f, 100f), UnityEngine.Random.Range(-80f, 80f), UnityEngine.Random.Range(-100f, 100f));
            Quaternion cubeRotation = new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), 1);
            GameObject newCube = Instantiate(cube, cubePosition, cubeRotation);
            yield return new WaitForSeconds(0.1f);

            if (Time.time > 5)
            {
                StopCoroutine(DropCubes());
                StopAllCoroutines();
            }
        }
    }
    IEnumerator ChangeColors()

    {
        while (true)
        {

            yield return new WaitForSeconds(0.1f);
            meshRender.material.color = Color.yellow;
            yield return new WaitForSeconds(0.1f);
            meshRender.material.color = Color.green;
            yield return new WaitForSeconds(0.1f);
            meshRender.material.color = Color.blue;
            yield return new WaitForSeconds(0.2f);
            meshRender.material.color = Color.red;
            yield return new WaitForSeconds(0.2f);
            meshRender.material.color = Color.magenta;
            yield return new WaitForSeconds(0.2f);
            if (Time.time > 5)
            {
                StopCoroutine(ChangeColors());
                StopAllCoroutines();
            }


        }



    }


}