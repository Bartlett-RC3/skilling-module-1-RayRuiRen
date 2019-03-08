using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session5 : MonoBehaviour {

    // Variables
    public GameObject columnPrefab;
    IEnumerator createColumnCoroutine;

	// Use this for initialization
	void Start () {
        createColumnCoroutine = DropColumns();
	    StartCoroutine(createColumnCoroutine);

    }

    // Update is called once per frame
    void Update () {
        Debug.Log(Time.time);
    }

    // Coroutines
    IEnumerator DropColumns()
    {
        while (true)
        {
            Vector3 columnPosition = new Vector3(Random.Range(-5f, 3f), Random.Range(8f, 15f), Random.Range(-7f, 0f));
            Quaternion columnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            GameObject newColumn = Instantiate(columnPrefab, columnPosition, columnRotation);
            yield return new WaitForSeconds(0.05f);

            if (Time.time > 5f)
            {
                //Debug.Break();
                StopCoroutine(createColumnCoroutine);
                StopAllCoroutines();
            }
        }
    }
}
