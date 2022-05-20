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
    public Genes genes;

    public float age, ageGene, yield, productionSpeed, maturationSpeed;
    float growSize;

    bool isGrowing;
    Animator anim;
    MeshRenderer leavesMeshRender;
    MeshRenderer fruitMeshRender;
    BoxCollider collider;
    CreatureGenome cg;

    public void Eat()
    {
        isEatable = false;
        isGrowing = true;
        growSize = 0;
    }
    void Start()
    {
        leavesMeshRender = leaves.GetComponent<MeshRenderer>();
        fruitMeshRender = fruit.GetComponent<MeshRenderer>();
        anim = GetComponent<Animator>();
        collider = GetComponent<BoxCollider>();
        leavesMeshRender.material.color = leavesColor;
        fruitMeshRender.material.color = fruitColor;
        RotateObjectOnFloor();
        cg = GetComponent<CreatureGenome>();
        genes = Genes.RandomGenes(cg);
        DecodeGenome();
    }
    void RotateObjectOnFloor()
    {
        int layerMask = 1 << 8;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            transform.localPosition = hit.point;
            transform.localRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }
    }
    void DecodeGenome()
    {
        ageGene = genes.genes[0];
        maturationSpeed = genes.genes[1];
        yield = genes.genes[2];
        productionSpeed = genes.genes[3];


    }
    void BushProporties()
    {
        age = age + 0.1f * Time.deltaTime;
        leavesMeshRender.material.color = leavesColor;
        fruitMeshRender.material.color = fruitColor;
    }
    void Growing()
    {
        if (isGrowing)
        {
            if (growSize < 100)
            {
                growSize = growSize + maturationSpeed * Time.deltaTime;
            }
            else
            {
                isGrowing=false;
                isEatable = true;
                fruit.transform.localScale *=yield;
            }

        }
    }
    void Update()
    {
        BushProporties();
        Growing();
        anim.SetBool("IsEatable", isEatable);
        if (isEatable)
        {
            collider.enabled = true;
        }
        else
        {
            collider.enabled = false;
        }
    }
}
