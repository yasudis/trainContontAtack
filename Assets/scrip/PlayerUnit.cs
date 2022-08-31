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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamadgEPlayer(float damadge)
    {
        healf -= damadge;
        if (healf < 0)
        {
            Destroy(gameObject);
            
        }
    }
}
