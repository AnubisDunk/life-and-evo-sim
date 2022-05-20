using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;

public class StatsUi : MonoBehaviour
{
    public static int populationValue = 0;
    public static int hPopulation,cPopulation,oPopulation = 0;
    public static int bornValue = 0;
    public static int deadValue = 0;
    public static int time = 0;
    public Text popText;
    public Text hText,cText,oText;
    public Text bornText;
    public Text deadText;
    public Text timeText;
    List<int> popTime;
    float elapsed = 0f;
    bool isDone = false;
    void Start(){
        popTime = new List<int>();
    }
    void StorePopulation()
    {
        if(populationValue !=0){
            popTime.Add(populationValue);
        }else{
            if(!isDone)WriteToFile();
            isDone = true;
        }
    }

    void WriteToFile()
    {
        string filename = Application.dataPath + "/population.csv";
        TextWriter tw = new StreamWriter(filename, false);
        tw.WriteLine("Time,Population");
        for (int i = 0; i < popTime.Count; i++)
        {
            tw.WriteLine($"{i},{popTime[i]}");
        }
        tw.Close();
        Debug.Log("Pop data");
    }

    void Update()
    {
        popText.text = "Population:" + populationValue.ToString();
        hText.text = "Herbivores:" + hPopulation.ToString();
        cText.text = "Carnivores:" + cPopulation.ToString();
        oText.text = "Omnivores:" + oPopulation.ToString();
        bornText.text = "Born:" + bornValue.ToString();
        deadText.text = "Died:" + deadValue.ToString();
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
