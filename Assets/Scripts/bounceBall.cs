using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceBall : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Vector2 lastVelocity;
    void Awake()
    {
     rb = this.GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name == "BottomZone") return;
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);
        rb.velocity = direction * speed;
    }
}
