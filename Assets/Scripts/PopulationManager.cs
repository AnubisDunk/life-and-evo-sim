using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public GameObject creature;
    public int hCount, cCount, oCount;

    public Transform creatureHolder;
    [HideInInspector]
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
        ExportData data = new ExportData();
        data.InitDataExport(creature.GetComponent<CreatureController>());
    }
    public void Generate(){
        flag = true;
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
        while (popTemp != hCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx * mapSpacing) - (mapSize * 5), 100, (spawny * -mapSpacing) + (mapSize * 5)), Quaternion.identity, creatureHolder);
                instance.name = $"a{popTemp}";
                instance.GetComponent<Creature>().Init(true, Random.Range(0f, 0.33f), null);
                instance.GetComponent<CreatureController>().Init();
                instance.GetComponent<CreatureController>().size = 100;
                popTemp++;
            }
        }
        popTemp = 0;
        while (popTemp != cCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx * mapSpacing) - (mapSize * 5), 100, (spawny * -mapSpacing) + (mapSize * 5)), Quaternion.identity, creatureHolder);
                instance.GetComponent<Creature>().Init(true, Random.Range(0.34f, 0.66f), null);
                instance.GetComponent<CreatureController>().Init();
                instance.name = $"A{popTemp}";
                instance.GetComponent<CreatureController>().size = 100;
                popTemp++;
            }
        }
        popTemp = 0;
        while (popTemp != oCount)
        {
            spawnx = Random.Range(0, mapSize);
            spawny = Random.Range(0, mapSize);
            if (CheckPos(spawnx, spawny, noiseMap))
            {
                var instance = Instantiate(creature, new Vector3((spawnx * mapSpacing) - (mapSize * 5), 100, (spawny * -mapSpacing) + (mapSize * 5)), Quaternion.identity, creatureHolder);
                instance.GetComponent<Creature>().Init(true, Random.Range(0.67f, 1f), null);
                instance.GetComponent<CreatureController>().Init();
                instance.name = $"O{popTemp}";
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
        }
        else
        {
            return false;
        }
    }
    // Update is called once per frame

}
