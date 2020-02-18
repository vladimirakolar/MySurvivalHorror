using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasaBreck : MonoBehaviour
{
    public GameObject fakeVase;
    public GameObject brockenVasa;
    public GameObject sfereObject;
    
    public void DemageZombie(int DamageAmount)
    {
        StartCoroutine(BreakVase());
    }

    IEnumerator BreakVase()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        fakeVase.SetActive(false);
        brockenVasa.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sfereObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        sfereObject.SetActive(false);
    }
}
