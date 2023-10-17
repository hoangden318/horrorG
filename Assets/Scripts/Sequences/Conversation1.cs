using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation1 : MonoBehaviour
{
    [SerializeField] protected Text convers1;
    [SerializeField] protected GameObject Player;
    [SerializeField] protected GameObject FadeScreenIn;
    void Start()
    {
        Player.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenceBeginPlayer());
    }

    IEnumerator ScenceBeginPlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreenIn.SetActive(false);
        convers1.GetComponent<Text>().text = "Đây là đâu? Tôi phải ra khỏi đây!!!";
        yield return new WaitForSeconds(2.25f);
        convers1.GetComponent<Text>().text = "";

        Player.GetComponent<FirstPersonController>().enabled = true;
    }


}
