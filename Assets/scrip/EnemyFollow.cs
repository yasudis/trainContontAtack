using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    private float moveSpeed;
    public int moveAngle;
    private float damadge;
    private float healf;
    public GameObject point;
    public GameObject BuletOfEnemy;
    private float reload;
    void Start()
    {
        reload = EnemyManadger.reloadOfSolder;
        //damadge = EnemyManadger.damadgeSolder;
        moveSpeed = EnemyManadger.moveSolder;
        healf = EnemyManadger.lifeSolder;
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
    }
    public void DamadgeEnemy(float damadge)
    {
        healf-=damadge;
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
