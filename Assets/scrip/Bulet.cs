using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulet : MonoBehaviour
{
    public float damadge;
    EnemyFollow enemyFollow;
    void Start()
    {
        damadge = PlayerManager.damedgePlaer;
        // time = 0;
    }
    void FixedUpdate()
    {
        transform.position += transform.forward * 100f * Time.deltaTime;
        //time += time + Time.time;
        Destroy(gameObject, 2f);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject whois = other.gameObject;
        enemyFollow = whois.GetComponent<EnemyFollow>();

        if (whois.tag == "Enemy")
        {
            Debug.Log("Zadel Enemy");
            Destroy(gameObject);
            enemyFollow.DamadgeEnemy(damadge);
        }

    }
}
