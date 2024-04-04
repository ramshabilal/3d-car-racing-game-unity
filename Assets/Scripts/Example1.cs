using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class Example1 : MonoBehaviour
{
    public float maxSteeringAngle;
    public float maxMotorTorque;
    public float maxBrakeTorque;

    public WheelCollider leftWheel;
    public WheelCollider rightWheel;

    public GameObject visualLeftWheel;
    public GameObject visualRightWheel;


    public void FixedUpdate()
    {
        // We collect from the Input the acceleration values,
        // turn and brake.
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        float brake = maxBrakeTorque * Input.GetAxis("Jump");

        // We apply these values to each wheel
        leftWheel.steerAngle = steering;
        leftWheel.motorTorque = motor;
        leftWheel.brakeTorque = brake;

        rightWheel.steerAngle = steering;
        rightWheel.motorTorque = motor;
        rightWheel.brakeTorque = brake;

        Vector3 position;
        Quaternion rotation;

        // We assign to the mesh of the wheel the position
        // and the collider spin
        // These position and rotation values belong
        // to the calculations done in the previous loop, so
        // will always be one iteration behind.
        leftWheel.GetWorldPose(out position, out rotation);
        visualLeftWheel.transform.position = position;
        visualLeftWheel.transform.rotation = rotation;

        rightWheel.GetWorldPose(out position, out rotation);
        visualRightWheel.transform.position = position;
        visualRightWheel.transform.rotation = rotation;

    }
}

