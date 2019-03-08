using UnityEngine;

namespace Assignment
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ModelInitializer : ScriptableObject
    {
        public abstract void Initialize(int[,] state);
    }
}
