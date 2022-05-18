using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgentInfo : MonoBehaviour
{
    public GameObject selector;
    public GameObject faceCamera;
    public GameObject portraitFrame;
    public GameObject hud;
    public GameObject senseRadiusDrawer;
    public GameObject GeneData;
    public GameObject GeneName;

    public Text nameText;
    public Text stateText;
    public Text sexText;
    public Text growText;
    public Text hungerText;
    public Text thirstText;
    public Font roboto;

    RaycastHit hit;

    SenseRender sr;
    Transform agent;
    CreatureController cc;

    int layerMask;
    bool isFollowing, isShowingInfo, isPaused = false;
    void Start()
    {
        layerMask = 1 << 9;
        sr = senseRadiusDrawer.GetComponent<SenseRender>();

    }

    void Pause()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isPaused = !isPaused;
        }
        if (cc != null)
        {
            cc.enabled = isPaused ? false : true;
        }
    }
    void Update()
    {
        // if (isFollowing)
        // {
        //     transform.position = agent.transform.position + new Vector3(0, 1, -5);
        // }
        if ((Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, layerMask)))
        {
            cc = hit.transform.gameObject.GetComponent<CreatureController>();
            Creature c = hit.transform.gameObject.GetComponent<Creature>();
            CreatureGenome cg = hit.transform.GetComponent<CreatureGenome>();
            WriteData();
            if (!isShowingInfo)
            {
                hud.SetActive(true);
                for (int i = 0; i < cg.genome.Length; i++)
                {
                    GameObject geneNameUI = new GameObject(cg.genome[i].geneName);
                    GameObject geneDataUI = new GameObject(c.genes.genes[i].ToString());
                    geneNameUI.transform.SetParent(GeneName.transform);
                    geneDataUI.transform.SetParent(GeneData.transform);
                    Text geneNameUIText = geneNameUI.AddComponent<Text>();
                    Text geneDataUIText = geneDataUI.AddComponent<Text>();
                    geneNameUIText.font = roboto;
                    geneDataUIText.font = roboto;
                    geneNameUIText.text = cg.genome[i].geneName;
                    geneDataUIText.text = c.genes.genes[i].ToString();
                }
                isShowingInfo = true;
            }
            
            DrawFace();
            float senseRadius = cc.GetSenseRadius();
            senseRadiusDrawer.transform.position = hit.transform.position;
            sr.DrawCircle(100, senseRadius);
        }
        else
        {
            RemoveFace();
            RemoveData();
            sr.DrawCircle(1, 0);
            senseRadiusDrawer.transform.position = Vector3.zero;
            hud.SetActive(false);
            isShowingInfo = false;

        }
        Pause();
    }
    void DrawFace()
    {
        portraitFrame.SetActive(true);
        faceCamera.transform.parent = hit.transform;
        faceCamera.transform.LookAt(hit.transform);
        faceCamera.transform.Rotate(-20, 0, 0);
        faceCamera.transform.localPosition = new Vector3(0, 2.5f, 2);
        selector.transform.position = hit.transform.position + Vector3.up;
        selector.transform.parent = hit.transform;
        selector.transform.rotation = Quaternion.identity;
        selector.transform.localScale = new Vector3(3, 5, 3);
        selector.SetActive(true);
        faceCamera.SetActive(true);
        isFollowing = true;
        Debug.Log($"Did Hit {hit.collider.gameObject.name}");
    }
    void RemoveFace()
    {
        selector.transform.position = Vector3.zero + Vector3.up;
        faceCamera.transform.position = Vector3.zero;
        faceCamera.transform.rotation = Quaternion.identity;
        selector.SetActive(false);
        faceCamera.SetActive(false);
        portraitFrame.SetActive(false);
    }
    void WriteData()
    {
        if (cc.isCreatureMale())
        {
            sexText.text = "Male";
        }
        else
        {
            sexText.text = "Female";
        }
        nameText.text = cc.gameObject.name;
        stateText.text = cc.stateText.text;
        hungerText.text = cc.hunger.ToString();
        thirstText.text = cc.thirst.ToString();
        growText.text = cc.size.ToString();

    }
    void RemoveData()
    {
        foreach (Transform child in GeneName.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in GeneData.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }


}
