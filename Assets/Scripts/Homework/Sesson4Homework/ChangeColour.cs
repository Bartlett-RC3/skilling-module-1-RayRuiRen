using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {


    private MeshRenderer[] meshRender = new MeshRenderer[6];
    private GameObject[] staff = new GameObject[6];

    [SerializeField] private GameObject[] GameObjects = new GameObject[6];
    IEnumerator _changeColour;

    void Start ()
    {
        for (int i = 0; i < GameObjects.Length; i++)
        {
            staff[i] = Instantiate(GameObjects[i], new Vector3(i*1.5f,0,i*1.5f), Quaternion.identity);
           
        }

        for (int i = 0; i < GameObjects.Length; i++)
        {
            meshRender[i] = staff[i].GetComponent<MeshRenderer>();
            _changeColour = ChangeColor();

            StartCoroutine(_changeColour);
        }
    }

    void Update () {
        //Debug.Log(Time.realtimeSinceStartup);
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            for (int i = 0; i < GameObjects.Length; i++)
            {
                meshRender[i].material.color = new Color(Random.value, Random.value, Random.value);
            }

            yield return StartCoroutine(_changeColour);

            if (Time.realtimeSinceStartup > 5)
            {
                StopCoroutine(_changeColour);
                StopAllCoroutines();
            }
        }
    }
}
