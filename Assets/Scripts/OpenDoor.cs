using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] protected float theDistance;
    [SerializeField] protected GameObject theDoor;
    [SerializeField] protected Text actionKey;
    [SerializeField] protected AudioSource creakDoor;

    // Update is called once per frame
    void Update()
    {
       this.CaculateDistance();
        this.Open();
    }

    public virtual void CaculateDistance()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    public void Open()
    {
        if (theDistance <= 2)
        {
            actionKey.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                actionKey.gameObject.SetActive(false);
                theDoor.GetComponentInParent<Animation>().Play("FirstOpenTheDoor");
                creakDoor.Play();
            }
        }
        return;
    }

    public void OnMouseExit()
    {
        actionKey.gameObject.SetActive(false);
    }

}
