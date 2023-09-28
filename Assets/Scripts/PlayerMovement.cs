using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
float walkingSpeed;
float xDirection;
float xVector;


    // Start is called before the first frame update
    void Start()
    {
        

        walkingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkingSpeed * Time.deltaTime;
        //Cannot access non-static property 'position' in static context
        //Transform.position = Transform.position + new Vector3(xVector, 0, 0);
    }
}
