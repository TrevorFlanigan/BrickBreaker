using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPaddle : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 30f;
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)) {
            print("right arrow key is down!");
            Vector2 newPosition = transform.position;
            newPosition.x += speed * Time.deltaTime;
            this.GetComponent<Rigidbody2D>().MovePosition(newPosition);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            print("left arrow key is down!");
            Vector2 newPosition = transform.position;
            newPosition.x -= speed * Time.deltaTime;
            this.GetComponent<Rigidbody2D>().MovePosition(newPosition);
        }
    }
}
