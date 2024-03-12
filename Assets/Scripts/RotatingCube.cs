using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello World!");
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 90f*Time.fixedDeltaTime, 0);
        Debug.Log("Next Step.");
    }
}
