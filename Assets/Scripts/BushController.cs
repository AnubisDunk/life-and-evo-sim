using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushController : MonoBehaviour
{
    public GameObject bush;
    public Transform bushHolder;
    public int mapSpacing = 10;

    public int mapSize;

    private int bushCount = 0;
    private UIController uiController;
    // Start is called before the first frame update
    void OnEnable()
    {
        uiController = FindObjectOfType<UIController>();
    }
    public void GenerateBushes(float[,] noiseMap)
    {
        for (int y = 0; y < mapSize; y++) //noiseMap.Length
        {
            for (int x = 0; x < mapSize; x++)
            {

                if (noiseMap[x, y] > 0.5f && noiseMap[x, y] < 0.7f && Random.Range(0f, 1f) > 0.7f)
                {
                    int randOffset = Random.Range(1, 4);
                    Instantiate(bush, new Vector3(x * mapSpacing + randOffset - (mapSize * 5), 100, y * -mapSpacing - randOffset + (mapSize * 5)), Quaternion.identity, bushHolder);
                    bushCount++;
                }
            }
        }
       
        uiController.UpdateBushCount(bushCount);

    }
    public void DeleteBushes()
    {
        foreach (Transform bush in bushHolder.transform)
        {
            GameObject.Destroy(bush.gameObject);
        }
        bushCount = 0;
        uiController.UpdateBushCount(bushCount);
    }

    // Update is called once per frame
}
