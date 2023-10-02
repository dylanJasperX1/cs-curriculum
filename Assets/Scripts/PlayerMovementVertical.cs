using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementVertical : MonoBehaviour
{ 
    float walkingSpeed;
    float yDirection;
    float yVector;
    // Start is called before the first frame update
    void Start()
    {
        walkingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * walkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, yVector, 0);
    }
}
