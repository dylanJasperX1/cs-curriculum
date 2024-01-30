using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
float xSpeed;
float xDirection;
float xVector;

float ySpeed;
float yDirection;
float yVector;
public bool inCaves;

private Rigidbody2D rb;
private bool onGround;
public float rayDistance;
public float jumpAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = ySpeed = 5f;
        if (inCaves)
        {
            ySpeed = 0;
        }

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * xSpeed * Time.deltaTime;
        
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * ySpeed * Time.deltaTime;
        
        transform.position = transform.position + new Vector3(xVector, yVector, 0);

        if (inCaves)
        {
            if (Input.GetKeyDown("space") && onGround)
            {
                print("jump was pressed");
                //jump using the rigid body
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            }
        }

        onGround = Physics2D.Raycast(transform.position, Vector2.down, rayDistance);
        
        //Uncommenting the line below will make the rays that detect whether the
        //player is on the ground visible
        //Debug.DrawRay(transform.position, Vector2.down,Color.green);
        

        
    }
}
