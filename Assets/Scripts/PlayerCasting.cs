using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float distanceFromTarget;
    [SerializeField] protected float target;

    // Update is called once per frame
    void Update()
    {
        this.TheDistance();
    }

    public virtual void TheDistance()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward, out hit))
        {
            distanceFromTarget = hit.distance;
            target = distanceFromTarget;
        }
    }
}
