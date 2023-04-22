using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOfEnemyFlamethrower : MonoBehaviour
{
    private float damadge = 0.5f;
    PlayerUnit playerDamadge;
    void Start()
    {
        damadge = EnemyManadger.damadgeFlamethrower;
        // time = 0;
    }
    void FixedUpdate()
    {
        transform.position += transform.forward * 12f * Time.deltaTime;
        //time += time + Time.time;
        Destroy(gameObject, 0.3f);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject whois = other.gameObject;

        if (whois.tag == "Player")
        {
            playerDamadge = whois.GetComponent<PlayerUnit>();
            Debug.Log("Zadel Player");
            Destroy(gameObject);
            playerDamadge.DamadgePlayer(damadge);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
