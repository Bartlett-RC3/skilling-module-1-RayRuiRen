using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment.Unity
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class InitializationScheduler : InitializableBehavior
    {
        [SerializeField] private InitializableBehavior[] _objects;


        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            foreach (var obj in _objects)
                obj.Initialize();
        }
    }
}
