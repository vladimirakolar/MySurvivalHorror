using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BFirstTrriger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject TheMarker;

    void OnTriggerEnter()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(SceenePlayer());
    }

    IEnumerator SceenePlayer()
    {
        TextBox.GetComponent<Text>().text = "Looks like a weapon on that table";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        TheMarker.SetActive(true);
    }
}
