using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOfEnemyFlamethrower : MonoBehaviour
{
    private float damadge=0.5f;
    PlayerUnit damadgePlayer;
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
        Destroy(gameObject, 0.3f);

    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject whois = other.gameObject;
        

        if (whois.tag == "Player")
        {
            damadgePlayer = whois.GetComponent<PlayerUnit>();
            Debug.Log("Zadel Player");
            Destroy(gameObject);
            damadgePlayer.DamadgePlayer(damadge);
            

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
