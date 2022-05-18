using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureGenome : MonoBehaviour
{
    public Gene[] genome;

   
}
[System.Serializable]
    public struct Gene {
        public string geneName;
        public float geneMinValue;
        public float geneMaxValue;
    }
