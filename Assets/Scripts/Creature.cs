using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public GameObject lEye;
    public GameObject rEye;
    public GameObject body;
    
    public Color eyeColor;
    public Color bodyColor;

    MeshRenderer bodyMeshRenderer;
    MeshRenderer lEyeMeshRenderer;
    MeshRenderer rEyeMeshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        bodyMeshRenderer = body.GetComponent<MeshRenderer>();
        lEyeMeshRenderer = lEye.GetComponent<MeshRenderer>();
        rEyeMeshRenderer = rEye.GetComponent<MeshRenderer>();
        bodyMeshRenderer.material.color = bodyColor;
        lEyeMeshRenderer.material.color = eyeColor;
        rEyeMeshRenderer.material.color = eyeColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
