using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GravitySynchronizer : MonoBehaviour
{
    void Start()
    {
        if (Accelerometer.current == null)
        {
            Debug.LogWarning("No Accelerometer found. This game won't work without.");
            return;
        }
        InputSystem.EnableDevice(Accelerometer.current);
        Debug.Log($"Is Gravity Sensor enabled? {Accelerometer.current.enabled}");
        Debug.Log("Default Sampling Frequency: " + Accelerometer.current.samplingFrequency);
        Accelerometer.current.samplingFrequency = 30;
    }

    void Update()
    {
        if (Accelerometer.current == null)
        {
            Debug.LogWarning("No Accelerometer found. This game won't work without.");
            return;
        }
        var gravity = Accelerometer.current.acceleration.value;
        Debug.Log($"Current Gravity: {gravity}");
        Debug.Log($"Gravity Magnitude: {gravity.magnitude}");
        
        // Flip Z axis, since flat-placed phone yields negative Z gravity
        gravity.z *= -1;
        // Scale gravity, since sensor returns normalized values
        gravity *= 9.81f;
        Physics.gravity = gravity;
    }
}
