using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuletOFEbemy : MonoBehaviour
{
    public float damadge;
    EnemyFollow enemyFollow;
   // private float time;
    // Start is called before the first frame update
    void Start()
    {
        damadge = EnemyManadger.damadgeSolder;
       // time = 0;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * 10f * Time.deltaTime;
        //time += time + Time.time;
       Destroy(gameObject,2f);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject whois = other.gameObject;
        enemyFollow=whois.GetComponent<EnemyFollow>();
        
        if (whois.tag == "Enemy")
        {
            Debug.Log("Zadel Enemy");
            Destroy(gameObject);
           enemyFollow.DamadgeEnemy(damadge);
           // Destroy(whois);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
