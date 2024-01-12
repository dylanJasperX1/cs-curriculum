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
    
    // Start is called before the first frame update
    void Start()
    {
        target = null;
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
                Instantiate(projectile, transform.position + new Vector3(0, .5f, 0), transform.rotation);
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
}
