using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public GameObject creature;
    public int popCount;

    public Transform creatureHolder;
    public int mapSpacing = 10;
    int mapSize;
    int popTemp;
    public MapGenerator mg;
    bool flag;
    int spawnx;
    int spawny;
    void Start()
    {
        flag = true;
        StatsUi.populationValue = popCount;
    }
    private void Update()
    {
        if (flag)
        {
            mapSize = Utils.mapSize;
            GeneratePopulation(Utils.noiseMap);
            flag = !flag;
        }

    }
    public void GeneratePopulation(float[,] noiseMap)
    {
        //var spawnRn = new System.Random(123);
        while (popTemp != popCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx*10)-(mapSize * 5)  , 100, (spawny*-10)+(mapSize*5)), Quaternion.identity, creatureHolder);
                instance.name = $"C{popTemp}";
                instance.GetComponent<CreatureController>().size = 100;
                popTemp++;
            }
        }

    }
    bool CheckPos(int spawnx, int spawny, float[,] noisemap)
    {
        if (noisemap[spawnx, spawny] >= 0.5f)
        {
            return true;
        }else{
            return false;
        }
    }
    // Update is called once per frame

}
