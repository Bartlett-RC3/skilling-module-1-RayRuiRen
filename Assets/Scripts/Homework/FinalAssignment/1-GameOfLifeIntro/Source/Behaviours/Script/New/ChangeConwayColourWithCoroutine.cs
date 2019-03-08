using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSlur;

namespace Assignment
{

    public class ChangeConwayColourWithCoroutine : MonoBehaviour
    {
        private MaterialPropertyBlock _properties;
        [SerializeField] private ModelManager _modelManager;

        [Space(12)]
        [SerializeField] private Material _ageMaterial;
        [SerializeField] private int _ageDisplayMin = 0;
        [SerializeField] private int _ageDisplayMax = 10;

        void Start()
        {
            _properties = new MaterialPropertyBlock();
        }

        // Update is called once per frame
        void Update()
        {
            StartCoroutine(ChangeColour());
        }

        private IEnumerator  ChangeColour()
        {
            const string propName = "_Value";

            foreach (var cell in _modelManager.Cells)
                {
                    // skip dead cells
                    if (cell.State == 0)
                        continue;

                    // update cell material
                    MeshRenderer renderer = cell.Renderer;
                    renderer.sharedMaterial = _ageMaterial;

                    // set material properties
                    {
                        renderer.GetPropertyBlock(_properties);

                        // normalize age
                        float value = SlurMath.Normalize(cell.Age, _ageDisplayMin, _ageDisplayMax);
                        //Debug.Log(cell.Age);
                        _properties.SetFloat(propName, value);

                        renderer.SetPropertyBlock(_properties);
                    }
                }
            yield return null;
        }
    }


}