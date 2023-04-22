using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    private float speedOfAnglyTurel;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void Start()
    {
        speedOfAnglyTurel = PlayerManager.speedAngle;
    }
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speedOfAnglyTurel * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}