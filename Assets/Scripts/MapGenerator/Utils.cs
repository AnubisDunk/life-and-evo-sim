using UnityEngine;

public class Utils : MonoBehaviour
{
    public static Utils ut = null;
    void Awake(){
        ut = this;
    }
    public static float[,] noiseMap;
    public static int mapSize;
}
