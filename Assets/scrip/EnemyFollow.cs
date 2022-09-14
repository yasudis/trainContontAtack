using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    private float moveSpeed, moveSpeedOLd,distantOfFire;
    // public int moveAngle;
    private float damadge;
    private float healf;
    public GameObject point;
    private GameObject Enemy;
    public GameObject BuletOfEnemy;
    private float reload;
    PlayerUnit damadgePlayer;
    void Start()
    {
        Enemy = this.gameObject;
        switch (Enemy.layer)
        {
            case 9:
                reload = EnemyManadger.reloadOfSolder;
                //damadge = EnemyManadger.damadgeSolder;
                moveSpeed= moveSpeedOLd = EnemyManadger.moveSolder;
                healf = EnemyManadger.lifeSolder;
                distantOfFire = EnemyManadger.distantOfFireSolder;
                break;
            case 10:
                reload = EnemyManadger.reloadOfFlamethrower;
                //damadge = EnemyManadger.damadgeSolder;
                moveSpeed=moveSpeedOLd = EnemyManadger.moveFlamethrower;
                healf = EnemyManadger.lifeFlamethrower;
                distantOfFire = EnemyManadger.distantOfFlamethrower;
                break;
            case 11:
                reload = EnemyManadger.reloadOfTurel;
                //damadge = EnemyManadger.damadgeSolder;
                moveSpeed = moveSpeedOLd = EnemyManadger.moveTurel;
                healf = EnemyManadger.lifeTurel;
                distantOfFire = EnemyManadger.distantOfFireTurel;
                break;
            case 12:
                reload = EnemyManadger.reloadOfTank;
                //damadge = EnemyManadger.damadgeSolder;
                moveSpeed = moveSpeedOLd = EnemyManadger.moveTank;
                healf = EnemyManadger.lifeTank;
                distantOfFire = EnemyManadger.distantOfFireTank;
                break;



        }

        player = GameObject.FindGameObjectWithTag("Player");
        Invoke("FireEnemy", reload);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        // transform.rotation = transform.rotation = Quaternion.RotateTowards(transform.rotation, player.transform.rotation, moveAngle *Time.deltaTime);
        // transform.rotation= Quaternion.LookRotation(newDirection);
        transform.LookAt(player.transform);
        if (Vector3.Distance(transform.position, player.transform.position) < distantOfFire)
        {
            moveSpeed = 0f;
        }
        else
        {
            moveSpeed = moveSpeedOLd;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject whois = other.gameObject;
        if (whois.tag == "Player")
        {
            damadgePlayer = whois.GetComponent<PlayerUnit>();
            Debug.Log("Zadel Player");
            damadgePlayer.DamadgePlayer(damadge);
            Destroy(gameObject);
        }
    }
        public void DamadgeEnemy(float damadge)
        {
            healf -= damadge;
            if (healf < 0)
            {
                Destroy(gameObject);
                PlayerManager.score += EnemyManadger.solderOfCoins;
            }
        }
        void FireEnemy()
        {

            Instantiate(BuletOfEnemy, point.transform.position, transform.rotation);
            BuletOfEnemy.transform.position += transform.forward * 5f * Time.deltaTime;
            Invoke("FireEnemy", reload);
        }
    } 
