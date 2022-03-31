using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public GameObject leaves;
    public GameObject fruit;
    public Color leavesColor;
    public Color fruitColor;
    public bool isEatable = true;
    Animator anim;
    MeshRenderer leavesMeshRender;
    MeshRenderer fruitMeshRender;

    void Start()
    {
        leavesMeshRender = leaves.GetComponent<MeshRenderer>();
        fruitMeshRender = fruit.GetComponent<MeshRenderer>();
        anim = GetComponent<Animator>();

        leavesMeshRender.material.color = leavesColor;
        fruitMeshRender.material.color = fruitColor;
        RotateObjectOnFloor();
    }
    void RotateObjectOnFloor()
    {
        int layerMask = 1 << 8;
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.yellow);
            transform.localPosition = hit.point;
            transform.localRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            Debug.Log($"Did Hit {hit.collider.gameObject.name}");
        }
        else
        {
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.white);
            Debug.Log("Did not Hit");
        }

    }
    // Update is called once per frame
    void Update()
    {
        anim.SetBool("IsEatable",isEatable);
        leavesMeshRender.material.color = leavesColor;
        fruitMeshRender.material.color = fruitColor;
    }
}
