using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTriggerWeapon : MonoBehaviour
{
    [SerializeField] protected GameObject thePlayer;
    [SerializeField] protected Text convers2;
    [SerializeField] protected GameObject theMarker;
    [SerializeField] protected GameObject firstTrigger;
    void Start()
    {
        theMarker.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        thePlayer.GetComponent<FirstPersonController>().playerCamera.enabled = true;
        StartCoroutine(ScenceWeaponPlayer());

    }

    IEnumerator ScenceWeaponPlayer()
    {
        yield return new WaitForSeconds(1f);
        convers2.GetComponent<Text>().text = "Trông như là một khẩu súng!!";
        yield return new WaitForSeconds(1.5f);
        convers2.GetComponent<Text>().text = "";
        thePlayer.GetComponent<FirstPersonController>().enabled = true;
        theMarker.SetActive(false);
        firstTrigger.GetComponent<BoxCollider>().enabled = false;
    }
}
