using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using SpatialSlur;

namespace Assignment
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int _countX = 10;
        [SerializeField] private int _countY = 10;

        private Cell[,] _cells;
        private GameOfLife2D _model;
        private int _stepCount;

        public InterFace _interface;



        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            // create cell array
            _cells = new Cell[_countY, _countX];

            // instantiate cell prefabs and store in array
            for (int y = 0; y < _countY; y++)
            {
                for(int x = 0; x < _countX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);
                    cell.transform.localPosition = new Vector3(x, y, 0);
                    _cells[y, x] = cell;
                }
            }

            // create model
            _model = new GameOfLife2D(_countY, _countX);

            // initialize model
            _initializer.Initialize(_model.CurrentState);

            _interface.SetVALUE(2333);
        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            if (_interface.VALUE == 2333)
            {
                _model.Step2333();
            }

            if (_interface.VALUE == 2323)
            {
                _model.Step2323();
            }


            if (_interface.VALUE == 2525)
            {
                _model.Step2525();

            }


            _stepCount++;
             //Debug.Log($"{_stepCount} steps taken!");

            int[,] state = _model.CurrentState;

            // update cells based on current state of model
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                    _cells[y, x].State = state[y, x];
            }



            CalAge();
        }
        private void CalAge()
        {

            Cell[,] prevCells = _cells;

            for (int i = 0; i < _countX; i++)
            {
                for (int j = 0; j < _countY; j++)
                    _cells[i, j].Age = _model.CurrentState[i, j] > 0 ? prevCells[i, j].Age + 1 : 0;
            }

        }




        public Cell[,] Cells
        {
            get { return _cells; }
        }

        public int Step
        {
            get { return _stepCount; }
        }

        public int CountX
        {
            get { return _countX; }
        }

        public int CountY
        {
            get { return _countY; }
        }

    }
}
