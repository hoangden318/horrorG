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

    private void Start()
    {
        actionKey.gameObject.SetActive(false);
    }

    public virtual void CaculateDistance()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }
    void FixedUpdate()
    {
       this.CaculateDistance();
        
    }

    private void OnMouseOver()
    {
        if(theDistance <= 3)
        {
            actionKey.gameObject.SetActive(true);
        }

        if(Input.GetKey(KeyCode.E) && theDistance <=3)
        {
            theDoor.GetComponentInParent<Animation>().Play("FirstOpenTheDoor");
            creakDoor.Play();
            actionKey.gameObject.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        actionKey.gameObject.SetActive(false);
    }
  

    

}
