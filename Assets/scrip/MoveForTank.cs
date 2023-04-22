using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForTank : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.position += transform.forward * 20f * Time.deltaTime;
        //time += time + Time.time;
    }
}
