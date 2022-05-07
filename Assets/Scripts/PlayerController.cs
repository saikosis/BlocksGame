using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const int temp = 0;
    public Rigidbody2D rigidbody2d;
    public float speed;
    private float def_speed; //default speed
    private float accelration = 1f;
    private int count_var;

    // Start is called before the first frame update
    void Start()
    {
        def_speed = speed;
        count_var = temp;
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis("Jump") > 0 -> float value is retured
        if (Input.GetKeyDown("space")) // boolean returned
        {
            count_var += 1;
            Debug.Log($"count_var : {count_var}");
        }

        if (count_var % 2 == 0)
        {

            if (Input.GetAxis("Horizontal") > 0)
            {
                speed += accelration * Time.deltaTime;
                rigidbody2d.velocity = new Vector2(speed, 0f);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                speed += accelration * Time.deltaTime;
                rigidbody2d.velocity = new Vector2(-speed, 0f);
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                speed += accelration * Time.deltaTime;
                rigidbody2d.velocity = new Vector2(0f, speed);
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                speed += accelration * Time.deltaTime;
                rigidbody2d.velocity = new Vector2(0f, -speed);
            }
            else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
            {
                rigidbody2d.velocity = new Vector2(0f, 0f);
                // resetting speed to 
                speed = def_speed;
            }
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Door")
            Debug.Log("Level Complete!!!");
    }
}
