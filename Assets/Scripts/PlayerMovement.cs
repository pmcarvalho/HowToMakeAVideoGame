﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // This value was made into a variable in order to modify it in the inspector
    public float fowardForce = 4000f;
    public float sidewaysForce = 120f;

    void Start()
    {

        rb.AddForce(0, 0, fowardForce);

    }
    
    // FixedUpdate is to be used when messing with physics
    public void FixedUpdate()
    {

        // Time.deltaTime is the time since the last frame was loaded, it makes so that slower computer will run the game at the same speed
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if ( Input.GetKey("d") ) 
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 

        }

        if ( Input.GetKey("a") )
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if( rb.position.y < 0.9f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
