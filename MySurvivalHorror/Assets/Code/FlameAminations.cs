using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAminations : MonoBehaviour
{
    public int LightMode;
    public GameObject FlameLight;

    void Update()
    {
        if (LightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }
    }

    IEnumerator AnimateLight()
    {
        LightMode = Random.Range(1, 4);
        if (LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnimation1");
        }
        if (LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnimation2");
        }
        if (LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnimation3");
        }
        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
}
