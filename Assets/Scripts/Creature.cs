using System;
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
    public Mesh hBody, hLEye, hREye;
    public Mesh pBody, pLEye, pREye;
    public Mesh oBody, oLEye, oREye;
    public bool isMale;
    public float hungerSpeed = 1f;
    public float senseRadius;
    public float moveSpeed;
    public float thirstSpeed;
    public float growingSpeed;
    public float hungerLevel;
    public float thirstLevel;
    public float pregnancyDuriation;
    public float foodtypeGene;
    public CreatureType creatureType;
    CreatureGenome cg;

    MeshRenderer bodyMeshRenderer;
    MeshRenderer lEyeMeshRenderer;
    MeshRenderer rEyeMeshRenderer;
    MeshFilter bodyMeshFilter;
    MeshFilter lEyeMeshFilter;
    MeshFilter rEyeMeshFilter;


    // Start is called before the first frame update
    public void Init(bool isFirst, float range, Genes newgenes)
    {
        BaseInit();
        range = Mathf.Round(range * 100f) *0.01f; 
        if (isFirst)
        {
            genes = Genes.RandomGenes(cg);
            genes.genes[9] = range;
        }
        else
        {
            genes = newgenes;
            geneSignature = genes.ShowGenome();
            DecodeGenome();
        }
        geneSignature = genes.ShowGenome();
        DecodeGenome();
        genomeSize = cg.genome.Length;
        if (isMale)
        {
            bodyMeshRenderer.material.color = bodyColor;
        }
        else
        {
            bodyMeshRenderer.material.color = bodyColorFemale;
        }
    }

    private void BaseInit()
    {
        bodyMeshRenderer = body.GetComponent<MeshRenderer>();
        lEyeMeshRenderer = lEye.GetComponent<MeshRenderer>();
        rEyeMeshRenderer = rEye.GetComponent<MeshRenderer>();
        bodyMeshFilter = body.GetComponent<MeshFilter>();
        lEyeMeshFilter = lEye.GetComponent<MeshFilter>();
        rEyeMeshFilter = rEye.GetComponent<MeshFilter>();
        cg = GetComponent<CreatureGenome>();
        lEyeMeshRenderer.material.color = eyeColor;
        rEyeMeshRenderer.material.color = eyeColor;
        StatsUi.populationValue++;
    }

    public void EncodeGenome(Genes newgenes)
    {
        genes = newgenes;
        geneSignature = genes.ShowGenome();
        DecodeGenome();
    }
    public void DecodeGenome()
    {
        isMale = genes.genes[0] > 0.5f ? true : false;
        senseRadius = genes.genes[1];
        moveSpeed = genes.genes[2];
        hungerSpeed = genes.genes[3];
        thirstSpeed = genes.genes[4];
        growingSpeed = genes.genes[5];
        hungerLevel = genes.genes[6];
        thirstLevel = genes.genes[7];
        pregnancyDuriation = genes.genes[8];
        foodtypeGene = genes.genes[9];
        if (foodtypeGene >= 0.33f)
        {
            if (foodtypeGene >= 0.66f)
            {
                InitCreatureType(CreatureType.Omnivore);
                //Debug.Log("Omnivore: " + foodtypeGene + name);
            }
            else
            {
                InitCreatureType(CreatureType.Carnivore);
                //Debug.Log("Carnivore: " + foodtypeGene + name);
            }
        }
        else
        {
            InitCreatureType(CreatureType.Herbivore);
            //Debug.Log("Herbivore: " + foodtypeGene + name);
        }

    }
    public void UpdateColors()
    {
        bodyMeshRenderer.material.color = bodyColor;
        lEyeMeshRenderer.material.color = eyeColor;
        rEyeMeshRenderer.material.color = eyeColor;
    }
    void InitCreatureType(CreatureType type)
    {
        switch (type)
        { //0 - fruit 1 - meat 2- both
            case CreatureType.Herbivore:
                creatureType = CreatureType.Herbivore;
                break;
            case CreatureType.Carnivore:
                creatureType = CreatureType.Carnivore;
                bodyMeshFilter.mesh = pBody;
                lEyeMeshFilter.mesh = pLEye;
                rEyeMeshFilter.mesh = pREye;
                break;
            case CreatureType.Omnivore:
                creatureType = CreatureType.Omnivore;
                bodyMeshFilter.mesh = oBody;
                lEyeMeshFilter.mesh = oLEye;
                rEyeMeshFilter.mesh = oREye;
                break;
        }
    }

    public enum State
    {
        Idle,
        Wander,
        Dead,
        LookingForFood,
        LookingForWater,
        LookingForMate,
        LookingForPrey,
        Chasing,
        Fleeing
    }
    public enum CreatureType
    {
        Herbivore,
        Carnivore,
        Omnivore
    }
}
