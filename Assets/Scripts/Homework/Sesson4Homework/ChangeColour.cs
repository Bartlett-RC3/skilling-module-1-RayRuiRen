using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {


    private MeshRenderer meshRender;
    public GameObject prefabReference;
    private GameObject cube;
    IEnumerator _changeColour;

    void Start ()
    {
        cube = Instantiate(prefabReference, prefabReference.transform.localPosition, Quaternion.identity);
        meshRender = cube.GetComponent<MeshRenderer>();
        _changeColour = ChangeColor();

        StartCoroutine(_changeColour);
    }

    void Update () {
        Debug.Log(Time.realtimeSinceStartup);
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            meshRender.material.color =new  Color(Random.value, Random.value, Random.value);
            yield return StartCoroutine(_changeColour);

            if (Time.realtimeSinceStartup > 5)
            {
                StopCoroutine(_changeColour);
                StopAllCoroutines();
            }
        }
    }
}
