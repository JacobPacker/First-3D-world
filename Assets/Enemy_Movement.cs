using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public GameObject player;
    public float timeRemaining = 10;
    public int state = 0;
    private float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeRemaining - time.DeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (state == 0)
        {
            speed = 0;
        }
        if (timeRemaining > 0)
        {
            state == 1;
        }
        if (timeRemaining = -5)
        {
            timeRemaining -= time.DeltaTime;
            state == 0;
        }
    }
}
