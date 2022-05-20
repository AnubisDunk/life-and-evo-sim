using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    Camera cam;
    private Transform target;
    void Start()
    {
        cam = Camera.main;
        target = cam.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        
    }
}
