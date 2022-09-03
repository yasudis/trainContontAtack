using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public float healf;
    
    void Start()
    {
       healf = PlayerManager.healf;


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
