using UnityEngine;
using System.IO;

public class ExportData
{
    static string filename = "";
    string sex;


    public void InitDataExport(CreatureController cc)
    {
        filename = Application.dataPath + "/data.csv";
        TextWriter tw = new StreamWriter(filename, false);
        CreatureGenome cg = cc.GetComponent<CreatureGenome>();
        tw.Write("Name,Type,MotherName,FatherName,Sex,");
        for (int i = 0; i < cg.genome.Length; i++)
        {
            tw.Write(cg.genome[i].geneName + ",");
        }
        tw.WriteLine();
        tw.Close();
        Debug.Log("Data init");
    }
    public void WriteData(CreatureController cc,Creature c)
    {
        //filename = Application.dataPath + "/data.csv";
        TextWriter tw = new StreamWriter(filename, true);
        sex = cc.isCreatureMale() ? "Male" : "Female";
        tw.Write($"{cc.name},{cc.cratureType},{cc.mName},{cc.fName},{sex},");
        for (int i = 0; i < c.genomeSize; i++)
        {
            tw.Write(c.genes.genes[i].ToString() + ",");
        }
        tw.WriteLine();
        tw.Close();
        

    }
}
