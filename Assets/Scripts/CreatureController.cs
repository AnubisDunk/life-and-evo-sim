using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class CreatureController : MonoBehaviour
{
    public float timeToDirectionChange = 1; // change direction every second
    public float hunger = 500f;
    public float thirst = 500f;

    bool isMale;
    float hungerBase;
    float thirstBase;
    float senseRadius;
    float moveSpeed; // move units per second
    float absSpeed;
    float hungerSpeed,thirstSpeed,growingSpeed;


    public Creature.State state = Creature.State.Idle;
    public Text stateText;
    public RectTransform hungerBar;
    public RectTransform thirstBar;

    public GameObject desiredCreature;
    public GameObject replica;
    public float size;
    GameObject creatureHolder;
    public bool isLooking, isFound, desire; //Desire |true - male false - female
    Vector3 randomDirection;
    Vector3 foodDirection, waterDirection;

    float lastDirectionChange = 0;
    
    bool foodDetected = false;
    bool waterDetected = false;
    bool mateDetected = false;
    bool isHungry, isThirsty, isResting, isMating;

    Creature creature;

    Vector3 moveVector;
    public Vector3 creatureWayPoint;
    SphereCollider triggerCol;
    Bush bush;

    int layerMask;
    // Start is called before the first frame update
   
    public float GetSenseRadius(){
        return senseRadius;
    }
    public bool isCreatureMale(){
        return isMale;
    }
    void Start()
    {
        creatureHolder = GameObject.Find("PopulationManager");
        creature = GetComponent<Creature>();
        triggerCol = GetComponent<SphereCollider>();
        creatureWayPoint = gameObject.transform.position;
        GeneDecode();
        absSpeed = moveSpeed;
        hungerBase = hunger;
        thirstBase = thirst;
        //size = 1;
        layerMask = 1 << 8;
        Moving();
    }
    void GeneDecode()
    {
        isMale = creature.isMale;
        senseRadius = creature.senseRadius;
        moveSpeed = creature.moveSpeed;
        hungerSpeed = creature.moveSpeed;
        thirstSpeed = creature.thirstSpeed;
        growingSpeed = creature.growingSpeed;
        // hunger = creature.hunger;
    }
    // Update is called once per frame
    void Update()
    {
        Hunger();
        Growing();
        triggerCol.radius = senseRadius / 3;
        stateText.text = state.ToString();
        Restrictions();
        switch (state)
        {
            case Creature.State.Idle:
                break;
            case Creature.State.Dead:
                Die();
                break;
            case Creature.State.Wander:
                Exploring();
                break;
            case Creature.State.LookingForFood:
                LookingForFood();
                break;
            case Creature.State.LookingForWater:
                LookingForWater();
                break;
            case Creature.State.LookingForMate:
                LookingForMate();
                break;
        }
    }
    void Growing(){
        if(size<=100){
            transform.localScale = new Vector3(size*0.03f,size*0.03f,size*0.03f);
            size = size + growingSpeed * Time.deltaTime;
        }
    }
    private void LookingForMate()
    {
        isLooking = true;
        desire = isMale ? false : true;
        if (isFound)
        {
            creatureWayPoint = desiredCreature.transform.position;
            Moving();
            if (((transform.position - creatureWayPoint).magnitude < 1))
            {
                Mating();
                isLooking = false;
                isFound = false;
                desiredCreature = null;
                state = Creature.State.Wander;
            }
        }
        else
        {
            Exploring();
        }
    }

    private void Mating()
    {
        if ((!isMale)&&(!isResting))
        {
            string motherName = creature.name;
            Childbirth(creature.genes, desiredCreature.GetComponent<Creature>().genes,motherName);
        }
        StartCoroutine(Resting());
    }

    private void Childbirth(Genes mother, Genes father, string name)
    {
        Genes rng;
        if (Random.value > 0.5f)
        {
            rng = mother;
        }
        else
        {
            rng = father;
        }
        GameObject child = Instantiate(replica, transform.position, Quaternion.identity, creatureHolder.transform);
        child.name = $"C|{name}";
        StatsUi.bornValue++;
        StatsUi.populationValue++;
        child.GetComponent<CreatureController>().size = 1;
        child.GetComponent<Creature>().EncodeGene(rng);
    }
    IEnumerator Resting()
    {

        isResting = true;
        yield return new WaitForSeconds(30);
        isResting = false;

    }
    private void Exploring()
    {
        if ((transform.position - creatureWayPoint).magnitude < 1)
        {
            creatureWayPoint = NewWayPoint(senseRadius);
            foodDetected = false;
            waterDetected = false;
        }
        else
        {
            Moving();
        }
    }

    void LookingForWater()
    {
        isThirsty = true;
        if (waterDetected)
        {
            creatureWayPoint = waterDirection;
        }
        if (((transform.position - creatureWayPoint).magnitude < 1) && (waterDetected && isThirsty))
        {
            ThirstRefill();
            waterDetected = false;
        }
        else
        {
            Exploring();
        }
    }

    void LookingForFood()
    {
        isHungry = true;
        if (foodDetected)
        {
            creatureWayPoint = foodDirection;
        }
        if (((transform.position - creatureWayPoint).magnitude < 1) && (foodDetected && isHungry) && (bush.isEatable == true))
        {
            bush.Eat();
            HungerRefill();
            foodDetected = false;
        }
        else
        {
            Exploring();
        }
    }

    void Restrictions()
    {
        if (transform.position.y < 0)
        {
            moveSpeed = absSpeed / 2f;
        }
        else
        {
            moveSpeed = absSpeed;
        }
    }
    void Die()
    {
        StatsUi.deadValue++;
        StatsUi.populationValue--;
        creature.eyeColor = Color.white;
        creature.bodyColor = Color.grey;
        //AlignSurfaceNormal();
        transform.rotation = Quaternion.Euler(90, 0, 0);
        creature.UpdateColors();
        foreach (var comp in gameObject.GetComponents<Component>())
        {
            if (!(comp is Transform))
            {
                Destroy(comp);
            }
        }

    }
    void Hunger()
    {
        if (hunger <= 0 || thirst <= 0)
        {
            state = Creature.State.Dead;
        }
        if (hunger >= 0)
        {
            if (hunger < hungerBase / 2)
            {
                state = Creature.State.LookingForFood;
            }
            hunger = hunger - hungerSpeed * Time.deltaTime;
            float scaledvalue = hunger / hungerBase * 40;
            hungerBar.sizeDelta = new Vector2(scaledvalue, 3);
        }
        if (thirst >= 0)
        {
            if (thirst < thirstBase / 2)
            {
                state = Creature.State.LookingForWater;
            }
            thirst = thirst - thirstSpeed * Time.deltaTime;
     
            float scaledvalue = thirst / thirstBase * 40;
            thirstBar.sizeDelta = new Vector2(scaledvalue,3);
        }
        if ((hunger > hungerBase * 0.6f) && (thirst > thirstBase * 0.6f) && !isResting && size >=100)
        {
            state = Creature.State.LookingForMate;
        }
    }
    void HungerRefill()
    {
        hunger = hungerBase;
        isHungry = false;
        state = Creature.State.Wander;
    }
    void ThirstRefill()
    {
        thirst = thirstBase;
        isThirsty = false;
        state = Creature.State.Wander;
    }
    void MoveTowardsWaypoint()
    {
        var step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, creatureWayPoint, step);
        LookAtWaypoint();
    }
    void Moving()
    {
        AlignSurfaceNormal();
        AlignWaypointNormal();
        MoveTowardsWaypoint();
        Debug.DrawRay(transform.position, transform.position + creatureWayPoint * -1, Color.cyan);
    }
    private Vector3 NewWayPoint(float radius)
    {
        //float rng = Random.value;
        //if (rng > 0.9f)
        var vector2 = Random.insideUnitCircle.normalized * radius;
        moveVector = new Vector3(vector2.x, 0, vector2.y);
        moveVector += transform.position;
        //Debug.Log("Random:"+rng+"MOVEvec: "+ moveVector);

        return moveVector;
    }
    void LookAtWaypoint()
    {
        transform.LookAt(creatureWayPoint, Vector3.up);

    }
    void AlignWaypointNormal()
    {
        RaycastHit hit;
        if (Physics.Raycast(creatureWayPoint + Vector3.up * 100, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(creatureWayPoint, Vector3.down * hit.distance, Color.red);
            creatureWayPoint = hit.point;
            //Debug.Log($"Did Hit {hit.collider.gameObject.name}");
        }
    }
    void AlignSurfaceNormal()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up * 10, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.yellow);
            transform.localPosition = hit.point;
            transform.localRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            //Debug.Log($"Did Hit {hit.collider.gameObject.name}");
        }
    }


    private void OnDrawGizmos()
    {
        Vector3 origin = transform.position;
        Handles.DrawWireDisc(origin, new Vector3(0, 1, 0), senseRadius);
        Handles.DrawWireDisc(creatureWayPoint, new Vector3(0, 1, 0), 2);
        Handles.DrawLine(transform.position, creatureWayPoint);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bush"))
        {
            if (!foodDetected)
            {
                if (isHungry)
                {
                    foodDetected = true;
                    foodDirection = other.transform.position;
                    state = Creature.State.LookingForFood;
                    bush = other.GetComponent<Bush>();
                }
            }

        }
        if (other.gameObject.CompareTag("Watersource"))
        {
            if (!waterDetected)
            {
                if (isThirsty)
                {
                    waterDetected = true;
                    waterDirection = other.transform.position;
                    state = Creature.State.LookingForWater;
                }
            }
        }
        if (other.gameObject.CompareTag("Creature"))
        {
            if (isLooking)
            {
                if (other.GetComponent<CreatureController>().isLooking && (desire != other.GetComponent<CreatureController>().desire))
                {
                    desiredCreature = other.gameObject;
                    isFound = true;
                    other.gameObject.GetComponent<CreatureController>().desiredCreature = gameObject;
                    other.gameObject.GetComponent<CreatureController>().isLooking = false;
                    other.gameObject.GetComponent<CreatureController>().isFound = true;
                }
            }
        }
    }
}
