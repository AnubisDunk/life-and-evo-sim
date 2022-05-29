using UnityEngine;

public class GeneticAlgorithm
{
    Genes mother, father, child;
    float mutationRate;
    CreatureGenome cg;
    public GeneticAlgorithm(Genes mother, Genes father,CreatureGenome cg,float mutationRate)
    {
        this.mother = mother;
        this.father = father;
        this.mutationRate = mutationRate;
        this.cg = cg;
    }
    public Genes Execute(){
        Crossover();
        Mutate();
        return child;
    }
    void Mutate(){
        for (int i = 0; i < child.genes.Length; i++)
        {
            if((Random.value <= mutationRate) && (cg.genome[i].isMatatable)){
                float mgene = Random.Range(cg.genome[i].geneMinValue,cg.genome[i].geneMaxValue);
                child.genes[i] = Mathf.Round(mgene * 100f) * 0.01f;
               
            }
        }
    }
    void Crossover()
    {
        child = mother;
        int cut = Random.Range(0, mother.genes.Length);
        for (int i = 0; i < cut; i++)
        {
            child.genes[i] = mother.genes[i];

        }
        for (int j = cut; j < father.genes.Length; j++)
        {
            child.genes[j] = father.genes[j];
        }
    }
}
