using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public Camera camera;
    private Transform target;
    void Start()
    {
        camera = Camera.main;
        target = camera.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        
    }
}
