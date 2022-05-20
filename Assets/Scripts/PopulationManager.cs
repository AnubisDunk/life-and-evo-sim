using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public GameObject creature;
    public int hCount,cCount,oCount;

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
        //StatsUi.populationValue = popCount;
        ExportData data = new ExportData();
        data.InitDataExport(creature.GetComponent<CreatureController>());
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
        while (popTemp != hCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx*10)-(mapSize * 5)  , 100, (spawny*-10)+(mapSize*5)), Quaternion.identity, creatureHolder);
                instance.name = $"a{popTemp}";
                instance.GetComponent<CreatureController>().size = 100;
                instance.GetComponent<Creature>().genes.genes[9] = Random.Range(0f,0.33f);
                StatsUi.hPopulation++;
                popTemp++;
                
            }
        }
        popTemp=0;
        while (popTemp != cCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx*10)-(mapSize * 5)  , 100, (spawny*-10)+(mapSize*5)), Quaternion.identity, creatureHolder);
                instance.name = $"A{popTemp}";
                instance.GetComponent<CreatureController>().size = 100;
                instance.GetComponent<Creature>().genes.genes[9] = Random.Range(0.34f,0.59f);
                StatsUi.cPopulation++;
                popTemp++;
            }
        }
        popTemp=0;
        while (popTemp != oCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx*10)-(mapSize * 5)  , 100, (spawny*-10)+(mapSize*5)), Quaternion.identity, creatureHolder);
                instance.name = $"O{popTemp}";
                instance.GetComponent<CreatureController>().size = 100;
                instance.GetComponent<Creature>().genes.genes[9] = Random.Range(0.6f,1f);
                StatsUi.oPopulation++;
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
