using UnityEngine;

public class MovingPipe : MonoBehaviour
{
    private Camera _camera;
    public float pipeSpeed = 0.3f;
    private const float randYMin = 0f;
    private const float randYMax = 1f;

    public Transform otherPipes;
    
    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        MovePipe();
        RelocatePipeIfOutOfScreen();
    }

    void MovePipe()
    {
        transform.position += Vector3.left * (pipeSpeed * Time.deltaTime);
    }

    bool IsGameObjectOnScreen()
    {
        Vector3 screenPoint = _camera.WorldToViewportPoint(transform.position);
        return screenPoint.x > -0.1f;
    }

    void RelocatePipeIfOutOfScreen()
    {
        if (!IsGameObjectOnScreen())
        {
            float randomY = Random.Range(randYMin, randYMax);

            float distanceX = otherPipes.position.x - transform.position.x;
            
            transform.position = new Vector3(
                transform.position.x + 2 * distanceX, 
                randomY
            );
        }
    }

}