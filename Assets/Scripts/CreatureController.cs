using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class CreatureController : MonoBehaviour
{
    //public float timeToDirectionChange = 1; // change direction every second
    public float hunger = 100f;
    public float thirst = 100f;

    bool isMale;
    float hungerBase, thirstBase;
    float senseRadius;
    float absSpeed, moveSpeed; // move units per second

    float hungerSpeed, thirstSpeed, growingSpeed, hungerLevel, thirstLevel, pregnancyDuriation;


    public Creature.State state = Creature.State.Idle;
    public Text stateText;
    public RectTransform hungerBar;
    public RectTransform thirstBar;
    public float currentDuriation;
    public GameObject desiredCreature, prey;
    public GameObject replica;
    public Creature.CreatureType cratureType;
    public float size = 1;
    public int sizeMultiplier = 3;
    GameObject creatureHolder;
    public bool isLooking, isFound, desire; //Desire |true - male false - female
    Vector3 randomDirection;
    Vector3 foodDirection, waterDirection;

    float lastDirectionChange = 0;

    public string fName, mName;
    bool foodDetected = false;
    bool waterDetected = false;
    bool mateDetected = false;
    bool isHungry, isThirsty, isResting, isMating, isPregnant, isChasing, isLookingForPrey;

    public Creature creature;
    Genes father;
    Vector3 moveVector, shorelinePos;
    public Vector3 creatureWayPoint;
    SphereCollider triggerCol;
    Bush bush;

    int layerMask;
    // Start is called before the first frame update

    public float GetSenseRadius()
    {
        return senseRadius;
    }
    public bool isCreatureMale()
    {
        return isMale;
    }
    public void Init()
    {
        creatureHolder = GameObject.Find("PopulationManager");
        creature = GetComponent<Creature>();
        triggerCol = GetComponent<SphereCollider>();
        creatureWayPoint = gameObject.transform.position;
        GeneDecode();
        cratureType = creature.creatureType;
        InitHunger(cratureType);
        absSpeed = moveSpeed;
        hungerBase = hunger;
        thirstBase = thirst;
        layerMask = 1 << 8;
        Moving();
        desiredCreature = null;

    }

    void InitHunger(Creature.CreatureType creatureType)
    {
        switch (creatureType)
        {
            case Creature.CreatureType.Herbivore:
                break;
            case Creature.CreatureType.Carnivore:
                hunger = hunger * 1;
                thirst = thirst * 1;
                break;
            case Creature.CreatureType.Omnivore:
                hunger = hunger * 3;
                thirst = thirst * 3;
                break;
        }
    }

    void GeneDecode()
    {
        isMale = creature.isMale;
        senseRadius = creature.senseRadius;
        moveSpeed = creature.moveSpeed;
        hungerSpeed = creature.hungerSpeed;
        thirstSpeed = creature.thirstSpeed;
        growingSpeed = creature.growingSpeed;
        hungerLevel = creature.hungerLevel;
        thirstLevel = creature.thirstLevel;
        pregnancyDuriation = creature.pregnancyDuriation;

    }
    // Update is called once per frame
    void Update()
    {
        Hunger();
        Growing();
        triggerCol.radius = senseRadius / 3;
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
            case Creature.State.Fleeing:
                //Fleeing();
                break;
            case Creature.State.LookingForPrey:
                LookingForPrey();
                break;
        }
        stateText.text = state.ToString();
    }



    private void Fleeing(CreatureController hunter)
    {
        Debug.Log($"Fleeing from {hunter.name}");
    }

    void Growing()
    {
        if (size <= 100)
        {
            transform.localScale = new Vector3(size * 0.03f, size * 0.03f, size * 0.03f);
            size = size + growingSpeed * sizeMultiplier * Time.deltaTime;
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
                //desiredCreature = null;
                state = Creature.State.Wander;
            }
        }
        else
        {
            Exploring();
        }
    }

    void Mating()
    {
        if ((!isMale) && (!isResting) && (size >= 100) && !isPregnant)
        {
            currentDuriation = 0;
            isPregnant = true;
            father = desiredCreature.GetComponent<Creature>().genes;
            if (father == null) Debug.Log(this.name);
            fName = desiredCreature.name;

        }
        StartCoroutine(Resting());
    }
    void Pregnant()
    {
        Exploring();
        currentDuriation = currentDuriation + 10 * Time.deltaTime;
        if ((currentDuriation >= 100 * pregnancyDuriation) && (isPregnant))
        {
            string motherName = creature.name;
            Childbirth(creature.genes, father, motherName);
            isPregnant = false;
            currentDuriation = 0;
        }

    }
    void Childbirth(Genes mother, Genes father, string name)
    {
        Genes rng;
        rng = GA(mother, father);
        GameObject child = Instantiate(replica, transform.position, Quaternion.identity, creatureHolder.transform);
        child.GetComponent<Creature>().Init(false, 0, rng);
        //child.GetComponent<Creature>().EncodeGenome(rng);
        child.GetComponent<CreatureController>().Init();
        char childName = name[0];
        char childNumber = name[1];
        childName++;
        child.name = $"{childName}{childNumber}";
        StatsUi.bornValue++;
        // StatsUi.populationValue++;
        child.GetComponent<CreatureController>().size = 1;
        child.GetComponent<CreatureController>().mName = this.name;
        child.GetComponent<CreatureController>().fName = fName;

    }

    private Genes GA(Genes mother, Genes father)
    {
        Genes rng = mother;
        int cut = Random.Range(0, mother.genes.Length);
        for (int i = 0; i < cut; i++)
        {
            rng.genes[i] = mother.genes[i];

        }
        for (int j = cut; j < father.genes.Length; j++)
        {
            rng.genes[j] = father.genes[j];
        }
        // Debug.Log($"cut:{cut}|{mother.ShowGenome()}|{father.ShowGenome()}|rng:{rng.ShowGenome()}");
        return rng;
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
            AlignWaypointNormal();
            if (creatureWayPoint.y <= 2)
            {

                creatureWayPoint = shorelinePos;
            }
            else
            {
                shorelinePos = creatureWayPoint;
            }
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
        isLooking = false;
        isThirsty = true;
        if (waterDetected)
        {
            creatureWayPoint = waterDirection;
            //Debug.Log($"{this.name} - {(transform.position - creatureWayPoint).magnitude}");

        }
        if (((transform.position - creatureWayPoint).magnitude < 5) && (waterDetected && isThirsty))
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
        isLooking = false;
        if (foodDetected)
        {
            creatureWayPoint = foodDirection;
        }
        if ((cratureType == Creature.CreatureType.Carnivore) && (foodDetected) && (!isChasing))
        {
            state = Creature.State.Chasing;
        }
        else
        {
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
    }
    void LookingForPrey()
    {
        isLookingForPrey = true;
        if (prey != null)
        {

            creatureWayPoint = prey.transform.position;
            Moving();
            if ((object.Equals(prey,null)))
            {
                if (((transform.position - creatureWayPoint).magnitude < 1))
                {
                    prey.GetComponent<CreatureController>().Die();
                    HungerRefill();
                    isLookingForPrey = false;
                    prey = null;
                    //desiredCreature = null;
                    state = Creature.State.Wander;
                }
                else
                {
                    Exploring();
                }
            }else{
                 state = Creature.State.Wander;
            }

        }
    }

    void Restrictions()
    {
        if (isPregnant)
        {
            Pregnant();
        }
        if (transform.position.y < 0)
        {
            moveSpeed = absSpeed / 2f;
        }
        else
        {
            moveSpeed = absSpeed;
        }
    }
    public void Die()
    {
        StatsUi.deadValue++;
        StatsUi.populationValue--;
        switch (cratureType)
        {
            case Creature.CreatureType.Herbivore:
                StatsUi.hPopulation--;
                break;
            case Creature.CreatureType.Carnivore:
                StatsUi.cPopulation--;
                break;
            case Creature.CreatureType.Omnivore:
                StatsUi.oPopulation--;
                break;

        }
        creature.eyeColor = Color.white;
        creature.bodyColor = Color.grey;
        //AlignSurfaceNormal();
        transform.rotation = Quaternion.Euler(90, 0, 0);
        creature.UpdateColors();
        state = Creature.State.Dead;
        foreach (var comp in gameObject.GetComponents<Component>())
        {
            if (!(comp is Transform))
            {
                Destroy(comp);
            }
        }

        ExportData data = new ExportData();
        data.WriteData(this, creature);
        //Destroy(gameObject);
    }
    void Hunger()
    {
        if (hunger >= 0)
        {
            if (hunger < hungerBase * hungerLevel)
            {
                if (state != Creature.State.LookingForWater)
                    if (cratureType == Creature.CreatureType.Carnivore)
                        state = Creature.State.LookingForPrey;
                    else
                        state = Creature.State.LookingForFood;
            }
            hunger = hunger - hungerSpeed * Time.deltaTime;
            float scaledvalue = hunger / hungerBase * 40;
            hungerBar.sizeDelta = new Vector2(scaledvalue, 3);
        }
        if (thirst >= 0)
        {
            if (thirst < thirstBase * thirstLevel)
            {
                if (state != Creature.State.LookingForFood)
                    state = Creature.State.LookingForWater;
            }
            thirst = thirst - thirstSpeed * Time.deltaTime;

            float scaledvalue = thirst / thirstBase * 40;
            thirstBar.sizeDelta = new Vector2(scaledvalue, 3);
        }
        if ((hunger > hungerBase * 0.6f) && (thirst > thirstBase * 0.6f) && !isResting && size >= 100)
        {
            state = Creature.State.LookingForMate;
        }
        if (hunger <= 0 || thirst <= 0)
        {
            state = Creature.State.Dead;
            // Die();
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
                if ((isHungry) && ((cratureType == Creature.CreatureType.Herbivore) || cratureType == Creature.CreatureType.Omnivore))
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
                if (other.GetComponent<CreatureController>().isLooking && (desire != other.GetComponent<CreatureController>().desire)
                && (cratureType == other.GetComponent<CreatureController>().cratureType))
                {
                    desiredCreature = other.gameObject;
                    isFound = true;
                    other.gameObject.GetComponent<CreatureController>().desiredCreature = gameObject;
                    other.gameObject.GetComponent<CreatureController>().isLooking = false;
                    other.gameObject.GetComponent<CreatureController>().isFound = true;
                }
            }
            else
            {
                if ((cratureType == Creature.CreatureType.Carnivore) && (isLookingForPrey)
                 && (other.gameObject.GetComponent<CreatureController>().cratureType == Creature.CreatureType.Herbivore))
                {
                    //state = Creature.State.Chasing;
                    prey = other.gameObject;
                    prey.GetComponent<CreatureController>().Fleeing(this);
                    Debug.Log("Chasing");
                }
            }
        }
    }
}
