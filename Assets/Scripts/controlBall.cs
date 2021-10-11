using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlBall : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(Constants.initialSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        // this.GetComponent<Rigidbody2D>().
    }
}
