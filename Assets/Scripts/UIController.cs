using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    public Label bushCount;
    string bushCountbase;
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        bushCount = root.Q<Label>("BCount_label");
        bushCountbase = bushCount.text;
    }

    // Update is called once per frame
    public void UpdateBushCount(int count)
    {
        bushCount.text = bushCountbase + count.ToString();
    }
}
