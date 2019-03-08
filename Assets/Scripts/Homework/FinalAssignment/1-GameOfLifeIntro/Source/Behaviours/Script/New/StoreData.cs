using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment

{
    


public class StoreData : MonoBehaviour
{
    // Store alive cells position
    private List<Vector3> alives;
    private List<Vector3>[] perFrame;
    [SerializeField] private ModelManager _model;
    private int preStep;
    [SerializeField] private int _storeSteps = 1000;

    void Start()
    {
        preStep = 1;
        perFrame = new List<Vector3>[_storeSteps];
        alives = new List<Vector3>();
    }

    void Update()
    {
        if (preStep == _model.Step)
        {
            alives = new List<Vector3>();
            for (int i = 0; i < _model.CountX; i++)
            {
                for (int j = 0; j < _model.CountY; j++)
                {
                    if (_model.Cells[i,j].State == 1)
                    alives.Add(new Vector3(i,j,0));
                }
            }

            preStep++;

            //for (int i = 0; i < alives.Count; i++)
            //    Debug.Log($"{alives[i].x},{alives[i].y},0");

            if (preStep <= _storeSteps)
                perFrame[preStep - 1] = alives;
        }


    }
}
}