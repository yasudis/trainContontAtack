using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public float healf;
    GameObject pointEnd;
    
    void Start()
    {
       healf = PlayerManager.healf;
       pointEnd = GameObject.FindGameObjectWithTag("PointEnd");

    }
    public void Update()
    {
        if ((transform.position.z >= pointEnd.transform.position.z-10)&&((transform.position.x >= pointEnd.transform.position.x - 10)))
        {
            MenuManager.LevelComplete();
            Debug.Log("Level comlete");
        }
    }

    public void DamadgePlayer(float damadge)
    {
        healf -= damadge;
        if (healf < 0)
        {
            MenuManager.GameOver();
            Destroy(this.gameObject);
            Debug.Log("Game Over");
            

        }
    }
}
