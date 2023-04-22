using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public int reload;
    public GameObject point;
    public int whereGoEnemy;
    void Start()
    {       
        Invoke("SpawnForEnemy", reload);
    }  
    void SpawnForEnemy()
    {
        Instantiate(Enemy, point.transform.position, transform.rotation);
        
        switch (whereGoEnemy)
        {
            case 1:
                Enemy.transform.Rotate(0f, 0f, 0f);
                break;
            case 2:
                Enemy.transform.Rotate(0f, 90f, 0f);
                break;

        }
        Enemy.transform.position += transform.forward * 5f * Time.deltaTime;
        Invoke("SpawnForEnemy", reload);
    }
}
