using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turelController : MonoBehaviour
{
    public VariableJoystick _fixedJoystick;
    private float speedOfAngleTurel;
    public Rigidbody rb;
    private float angle;
    public GameObject turel;
    public GameObject point;
    public GameObject bulet;
    private float reload;
    private void Start()
    {
        speedOfAngleTurel = PlayerManager.speedOfAngle;
        rb= GetComponent<Rigidbody>();
        reload = .5f;
        Invoke("FireTurel", 1f);
    }
    public void FixedUpdate()
    {
        angle= angle + _fixedJoystick.Horizontal*speedOfAngleTurel;
        
        if (_fixedJoystick.Horizontal != 0)
        {
            turel.transform.rotation = Quaternion.Euler(rb.rotation.x,angle, rb.rotation.z);
            

        }
        if (Mathf.Abs(angle) > 360)
        {
            angle = 0;
        }
       // Vector3 input = new Vector3(_fixedJoystick.Horizontal, _fixedJoystick.Vertical);
       // Vector3 velocity = input.normalized * speed;
       //transform.position += velocity * Time.deltaTime;
    }
    void FireTurel()
    {
        Instantiate(bulet,point.transform.position,turel.transform.rotation);
        bulet.transform.position += transform.forward * 5f * Time.deltaTime;
        Invoke("FireTurel", reload);
    }
}
