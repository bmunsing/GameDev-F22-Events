using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    Rigidbody2D rb;

    void Start()
    {
        //Get the rigidbody2d of the gameObject this script is assigned to.
        //rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        
        //Determine the direction of the movement based on user input.
        float moveDir = Input.GetAxis("Horizontal");

        //Calculate the velocity of the gameObject.
        //rb.velocity = new Vector2(moveDir * speed, rb.velocity.y);

        // Your jump code:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
            pos.y += jumpHeight;
        }

    

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


      /*  if (Input.GetMouseButton(0))
        {
            pos.x = Random.Range(-4.0F, 4.0F);
            pos.y = Random.Range(-2.0F, 2.0F);

        } */

        transform.position = pos;
    }

}


