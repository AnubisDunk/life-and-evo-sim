using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreatureController : MonoBehaviour
{

    public float senseRadius = 1;
    public float timeToDirectionChange = 1; // change direction every second
    public float moveSpeed = 5; // move 5 units per second

    Vector3 randomDirection;
    Vector3 foodDirection;
    float lastDirectionChange = 0;
    bool foodDetected =false;
    SphereCollider triggerCol;
    int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        triggerCol = GetComponent<SphereCollider>();
        layerMask = 1 << 8;
    }

    // Update is called once per frame
    void Update()
    {
        AlignSurfaceNormal();
    }
    void AlignSurfaceNormal(){
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, Vector3.down * hit.distance, Color.yellow);
            transform.localPosition = hit.point;
            transform.localRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
            Debug.Log($"Did Hit {hit.collider.gameObject.name}");
        }
    }
    
    private void OnDrawGizmos()
    {
        Vector3 origin = transform.position;
        Handles.DrawWireDisc(origin, new Vector3(0, 1, 0), senseRadius);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bush"))
        {
            Debug.Log("Food on sight");
            foodDetected = true;
            foodDirection = other.transform.position;
        }

    }
}
