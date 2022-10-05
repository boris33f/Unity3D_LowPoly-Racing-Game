using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    public WheelCollider frontDriverW, frontPassengerW, rearDriverW, rearPassengerW;
    public Transform frontDriverT, frontPassengerT, rearDriverT, rearPassengerT;

    public float motorForce = 500;

    // Update Methods
    public void UpdateWheelPoses()
    {

    }

    public void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        
    }

    // Input Actions
    public void _Move(InputAction.CallbackContext context)
    {
        float inputValue = context.ReadValue<Vector2>().x;
        frontDriverW.steerAngle = 30 * inputValue;
        frontPassengerW.steerAngle = 30 * inputValue;
    }

    public void _MoveCamera(InputAction.CallbackContext context)
    {
        
    }

    public void _Accelerate(InputAction.CallbackContext context)
    {
        float inputValue = context.ReadValue<float>();
        frontDriverW.motorTorque = motorForce * inputValue;
        frontPassengerW.motorTorque = motorForce * inputValue;
    }

    public void _Brake(InputAction.CallbackContext context)
    {

    }


}
