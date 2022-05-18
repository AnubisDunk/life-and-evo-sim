using UnityEngine;
public class Genes
{
    public float[] genes;
    public Genes(float[] values){
        this.genes = values;
    }
    public string ShowGenome(){
        string res = "Genome: ";
        foreach (float item in genes)
        {
            res += item + "|";
        }
        return(res);
    }
    public static Genes RandomGenes (CreatureGenome cg) {
        float[] values = new float[cg.genome.Length];
        for (int i = 0; i < cg.genome.Length; i++) {
            values[i] = Random.Range(cg.genome[i].geneMinValue,cg.genome[i].geneMaxValue);
            values[i] = Mathf.Round(values[i] * 100f) *0.01f; 
        }
        return new Genes (values);
    }
}
