using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAnim : MonoBehaviour
{
    public GameObject TheZombie;

    public void ChangeAnim()
    {
        TheZombie.GetComponent<Animation>().Play("attack");
    }
}
