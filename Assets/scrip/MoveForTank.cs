using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForTank : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        transform.position += transform.forward * 20f * Time.deltaTime;
        //time += time + Time.time;
       

    }
}
