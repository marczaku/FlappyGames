using DefaultNamespace;
using UnityEngine;

public class SampleUsage : MonoBehaviour
{
    void Start()
    {
        FakeSensor sensor = FakeSensor.instance;
        Vector3Data data = FakeSensor.instance.fakeStuff;
        Debug.Log(FakeSensor.instance.sampleRate);
        FakeSensor.instance.sampleRate = 16;
        
        FakeSensor.OtherCoolStuff();
        FakeSensor.instance.DoCoolStuff();
    }
}