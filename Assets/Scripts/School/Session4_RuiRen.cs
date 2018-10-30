using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4_RuiRen : MonoBehaviour
{
    // Variable
    public GameObject prefabReference;
    IEnumerator creatPrefabs;

	void Start () {
        //How do we instantiate (make) a new pre fab?- give a object position,rotation and parent
		Vector3 prefabPosition = new Vector3(UnityEngine.Random.Range(-10,10), UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10));
        Quaternion prefabRotation = Quaternion.identity;

	    for (int i = 0; i < 10; i++)
	    {
            GameObject myPrefab = Instantiate(prefabReference, prefabPosition, prefabRotation);

	        foreach (Transform child in myPrefab.transform)
	        {
	            child.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);
	        }
            myPrefab.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }

	    creatPrefabs = DropPrefabsFromHeight();
	}

    void Update()
    {
        StartCoroutine(creatPrefabs);
        Debug.Log(Time.time);
        if (Time.time > 5)
        {
            StopCoroutine(creatPrefabs);
            StopAllCoroutines();
        }
    }

    //Implement the coroutine
    IEnumerator DropPrefabsFromHeight()
    {
        while (true)
        {
            Vector3 prefabPos = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRot = new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), 1);
            Instantiate(prefabReference, prefabPos, prefabRot);
            yield return new WaitForSeconds(1);


        }
    }
}
