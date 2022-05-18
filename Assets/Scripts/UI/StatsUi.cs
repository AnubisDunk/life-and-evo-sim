using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StatsUi : MonoBehaviour
{
    public static int populationValue = 0;
    public static int bornValue = 0;
    public static int deadValue = 0;
    public Text popText;
    public Text bornText;
    public Text deadText;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        popText.text = "Population:" + populationValue.ToString();
        bornText.text = "Born:" + bornValue.ToString();
        deadText.text = "Died:" + deadValue.ToString();
    }
}
