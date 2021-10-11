﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlDeadzone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // Probably better way to do this
        if (other.gameObject.name == "Ball") {
            print("Game Over!");
            other.gameObject.GetComponent<Rigidbody2D>().position = new Vector2(0, 0);
            other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Constants.initialSpeed);
        }
    }
}
