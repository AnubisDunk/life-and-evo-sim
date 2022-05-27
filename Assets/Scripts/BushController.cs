using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushController : MonoBehaviour
{
    public GameObject bush;
    public GameObject waterSource;
    public Transform bushHolder;
    public Transform creatureHolder;
    public Transform waterHolder;
    public int mapSpacing = 10;

    public int bCount;
    int mapSize;
    int popTemp,spawnx,spawny;
    bool flag;
    private int bushCount = 0;
    //private UIController uiController;
    void Start()
    {
        flag = true;
    }
    private void Update()
    {
        if (flag)
        {
            mapSize = Utils.mapSize;
            GenerateBushes(Utils.noiseMap);
            flag = !flag;
        }

    }
    public void GenerateBushes(float[,] noiseMap)
    {
        popTemp = 0;
        while (popTemp != bCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(bush, new Vector3((spawnx * mapSpacing) - (mapSize * 5), 100, (spawny * -mapSpacing) + (mapSize * 5)), Quaternion.identity, bushHolder);
                StatsUi.bushCount++;
                popTemp++;

            }
        }
        for (int y = 0; y < mapSize; y++)
        {
            for (int x = 0; x < mapSize; x++)
            {
                if (noiseMap[x, y] <= 0.4f && noiseMap[x, y] >= 0.35f)
                {
                    Instantiate(waterSource, new Vector3((x * mapSpacing) - (mapSize * 5), 5, (y * -mapSpacing) + (mapSize * 5)), Quaternion.identity, waterHolder);
                }
            }
        }

        //uiController.UpdateBushCount(bushCount);

    }
    bool CheckPos(int spawnx, int spawny, float[,] noisemap)
    {
        if (noisemap[spawnx, spawny] > 0.5f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void DeleteBushes()
    {
        foreach (Transform bush in bushHolder.transform)
        {
            GameObject.Destroy(bush.gameObject);
        }
        foreach (Transform creature in creatureHolder.transform)
        {
            GameObject.Destroy(creature.gameObject);
        }
        //uiController.UpdateBushCount(bushCount);
    }
}
