using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public GameObject lEye;
    public GameObject rEye;
    public GameObject body;
    public int genomeSize;
    public Genes genes;
    public Color eyeColor;
    public Color bodyColor;
    public Color bodyColorFemale;
    public string geneSignature;

    //public float hunger = 30f;
    public bool isMale;
    public float hungerSpeed = 1f;
    public float senseRadius;
    public float moveSpeed;
    public float thirstSpeed;
    public float growingSpeed;

    CreatureGenome cg;

    MeshRenderer bodyMeshRenderer;
    MeshRenderer lEyeMeshRenderer;
    MeshRenderer rEyeMeshRenderer;


    // Start is called before the first frame update
    void Start()
    {
        bodyMeshRenderer = body.GetComponent<MeshRenderer>();
        lEyeMeshRenderer = lEye.GetComponent<MeshRenderer>();
        rEyeMeshRenderer = rEye.GetComponent<MeshRenderer>();
        cg = GetComponent<CreatureGenome>();
        genomeSize = cg.genome.Length;
        genes = Genes.RandomGenes(cg);
        geneSignature = genes.ShowGenome();
        DecodeGene();
        if (isMale)
        {
            bodyMeshRenderer.material.color = bodyColor;
        }
        else
        {
            bodyMeshRenderer.material.color = bodyColorFemale;
        }
        lEyeMeshRenderer.material.color = eyeColor;
        rEyeMeshRenderer.material.color = eyeColor;
    }
    public void EncodeGene(Genes newgenes){
        genes = newgenes;
        geneSignature = genes.ShowGenome();
        DecodeGene();
    }
    void DecodeGene()
    {
        isMale = genes.genes[0] > 0.5f ? true : false;
        senseRadius = genes.genes[1];
        moveSpeed = genes.genes[2];
        hungerSpeed = genes.genes[3];
        thirstSpeed = genes.genes[4];
        growingSpeed = genes.genes[5];  


    }
    public void UpdateColors()
    {
        bodyMeshRenderer.material.color = bodyColor;
        lEyeMeshRenderer.material.color = eyeColor;
        rEyeMeshRenderer.material.color = eyeColor;
    }


    public enum State
    {
        Idle,
        Wander,
        Dead,
        LookingForFood,
        LookingForWater,
        LookingForMate
    }
}
