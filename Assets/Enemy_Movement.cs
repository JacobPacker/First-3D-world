using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Movement : MonoBehaviour
{
    public GameObject player;
    public float timeRemaining = 10;
    public int state = 0;
    private float speed = 5f;
    private Rigidbody rb;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                state == 0;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                state == 1;
            }
        }
        Vector3 velocity = rb.velocity;
        velocity.x = 0;
        if (state == 0)
        {
            speed = 0f;
            velocity.x = 0;
        }
        if (state == 1)
        {
            speed = 5f;
            velocity.x = 5;
        }
        
        
    }
}
