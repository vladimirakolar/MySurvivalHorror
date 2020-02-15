using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZJumpTrriger : MonoBehaviour
{
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheZombie;
    public GameObject TheDoore;
    public AudioSource AmbMusic;

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoore.GetComponent<Animation>().Play("SecondDoorOpenAnim");
        DoorBang.Play();
        TheZombie.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        AmbMusic.Stop();
        DoorJumpMusic.Play();
    }
}
