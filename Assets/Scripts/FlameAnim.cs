using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnim : MonoBehaviour
{
    [SerializeField] protected int lightMode = 0;
    [SerializeField] protected GameObject flameLight;

    
    void Update()
    {
        this.FlameAnimations();
    }

    protected void FlameAnimations()
    {
        if (lightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }
    }
    IEnumerator AnimateLight()
    {
        
        lightMode = Random.Range(0, 4);
        if (lightMode ==1)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim1");
        }
        if (lightMode == 2)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim2");
        }
        if (lightMode == 3)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim3");
        }
        yield return new WaitForSeconds(0.98f);
        lightMode = 0;
    }
}
