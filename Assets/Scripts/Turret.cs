using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject projectile;
    public float cooldown;
    private float cooldownTimer;
    private Transform target;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        target = null;
        speed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer < 0)
        {
            if (target != null)
            {
                print("Shot fired");
                //Create projectile
                GameObject clone;
                Instantiate(projectile, transform.position + new Vector3(0, .5f, 0), transform.rotation);
                var step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                /*
                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    target.position *= -1.0f;

                }
                */
                
                //Reset timer
                cooldownTimer = cooldown;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Target acquired");
            target = collision.gameObject.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Target gone");
            target = null;
        }
    }
}
