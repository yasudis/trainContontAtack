using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOfEnemy : MonoBehaviour
{
    private float damadge = 2f;
    PlayerUnit playerDamadge;
    // private float time;
    // Start is called before the first frame update
    void Start()
    {
        damadge = EnemyManadger.damadgeSolder;
        // time = 0;
    }
    void FixedUpdate()
    {
        transform.position += transform.forward * 50f * Time.deltaTime;
        //time += time + Time.time;
        Destroy(gameObject, 20f);
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
    }
}
