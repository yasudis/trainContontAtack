using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TrainMotor : MonoBehaviour
{
    private NavMeshAgent player;
    Vector3 taget;
    GameObject pointEnd;
    void Start()
    {
        pointEnd = GameObject.FindGameObjectWithTag("PointEnd");
        taget = pointEnd.transform.position;
        player = GetComponent<NavMeshAgent>();
        player.SetDestination(taget);
    }
}
