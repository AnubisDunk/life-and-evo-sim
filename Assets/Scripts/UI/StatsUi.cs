using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;

public class StatsUi : MonoBehaviour
{
    public static int populationValue = 0;
    public static int hPopulation, cPopulation, oPopulation = 0;
    public static int bornValue = 0;
    public static int deadValue = 0;
    public static int time = 0;
    public static int bushCount = 0;
    public Text popText, bornText, deadText, timeText, bushText;
    public Text hText, cText, oText;
    public static List<int> popTime, popHTime, popCTime, popOTime,fpsTime;
    float elapsed = 0f;
    bool isDone = false;

    private int current;

    void Start()
    {
        Reset();
    }
    public static void Reset()
    {
        populationValue = 0;
        hPopulation = 0;
        cPopulation = 0;
        oPopulation = 0;
        bushCount = 0;
        popTime = new List<int>();
        popHTime = new List<int>();
        popCTime = new List<int>();
        popOTime = new List<int>();
        fpsTime = new List<int>();
    }
    void StorePopulation()
    {
        if (populationValue != 0)
        {
            popTime.Add(populationValue);
            popHTime.Add(hPopulation);
            popCTime.Add(cPopulation);
            popOTime.Add(oPopulation);
            fpsTime.Add((int)(1f / Time.unscaledDeltaTime));
        }
        else
        {
            if (!isDone) WriteToFile();
            isDone = true;
        }
    }
    public static void ChangeCountType(Creature.CreatureType creatureType, bool isIncrease)
    {
        switch (creatureType)
        {
            case Creature.CreatureType.Herbivore:
                if (isIncrease) hPopulation++;
                else hPopulation--;
                break;
            case Creature.CreatureType.Carnivore:
                if (isIncrease) cPopulation++;
                else cPopulation--;
                break;
            case Creature.CreatureType.Omnivore:
                if (isIncrease) oPopulation++;
                else oPopulation--;
                break;
        }
    }
    void WriteToFile()
    {
        string filename = Application.dataPath + "/population.csv";
        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("Time,SumPopulation,HerbPopulation,CarnPopulation,OmniPopulation,FPS");
        for (int i = 0; i < popTime.Count; i++)
        {
            tw.WriteLine($"{i},{popTime[i]},{popHTime[i]},{popCTime[i]},{popOTime[i]},{fpsTime[i]}");
        }
        tw.Close();
        Debug.Log("Pop data");
    }
    private void OnApplicationQuit() {
        WriteToFile();    
    }
    void Update()
    {
        popText.text = "Population:" + populationValue.ToString();
        hText.text = "Herbivores:" + hPopulation.ToString();
        cText.text = "Carnivores:" + cPopulation.ToString();
        oText.text = "Omnivores:" + oPopulation.ToString();
        bornText.text = "Born:" + bornValue.ToString();
        deadText.text = "Died:" + deadValue.ToString();
        bushText.text = "Bushes:" + bushCount.ToString();
        timeText.text = "Time:" + time.ToString();
        time = (int)Time.time;
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            elapsed = elapsed % 1f;
            StorePopulation();
        }
    }
}
