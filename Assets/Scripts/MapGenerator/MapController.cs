using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public MapGenerator mapGenerator;
    public float timeScaler = 0.1f;

    public bool isScrolling = false;
    private BushController bushController;
    private void Awake()
    {
        mapGenerator.GenerateMap();
      
        
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) isScrolling = !isScrolling;
        if (Input.GetKeyDown(KeyCode.R)) RegenerateMap();
        if (isScrolling) MapScroller();


    }
    public void MapScroller()
    {
        mapGenerator.offset.x = Time.time * timeScaler;
        mapGenerator.offset.y = Time.time * timeScaler;
        mapGenerator.GenerateMap();
    }
    void RegenerateMap()
    {
        bushController.DeleteBushes();
        mapGenerator.seed = Random.Range(0, 100);
        mapGenerator.GenerateMap();
    }
}
