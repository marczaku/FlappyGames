using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    public float flapPower = 3;
    private Rigidbody2D _rb;
    private bool _isDead;
    public int score;

    public UnityEvent<int> ScoreChange;
    
    void Start()
    {
        
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
        Input.simulateMouseWithTouches = true;
    }

    void Update()
    {
        if (_isDead) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            if (_rb.simulated)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, flapPower);
            }
            else
            {
                _rb.simulated = true;
            }
        }
        UpdateRotation();
    }

    void UpdateRotation()
    {
        float targetRotation = 0f;
        if (_rb.velocity.y > 0.2f)
        {
            targetRotation = 30f;
        }
        else if (_rb.velocity.y < -1.5f)
        {
            targetRotation = -90f;
        } else if (_rb.velocity.y < -0.2f)
        {
            targetRotation = -30f;
        }
        Debug.Log(_rb.velocity.y);
        transform.rotation = Quaternion.Slerp(
            transform.rotation, 
            Quaternion.Euler(0f, 0f, targetRotation),
            Time.deltaTime * 8);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(Co_OnDeath());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreChange.Invoke(++score);
    }

    IEnumerator Co_OnDeath()
    {
        _isDead = true;
        gameObject.layer = LayerMask.NameToLayer("GameOver");
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
