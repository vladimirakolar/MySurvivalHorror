using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            enemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("Walk");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0f;
            theEnemy.GetComponent<Animation>().Play("Attack");
            StartCoroutine(InFlactDamage());
        }
    }

    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }

    IEnumerator InFlactDamage()
    {
        isAttacking = true;
        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 5;
        yield return new WaitForSeconds(0.5f);
        isAttacking = false;

    }

}
