using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    public int health = 5;
    public HUD hud;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Start");

        }

        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spikes"))
        {
            Debug.Log("Touching spike");
            health -= 1;
            hud.healthText.text = "Health: " + health;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 1;
            Destroy(collision.gameObject);
            hud.healthText.text = "Health: " + health;
        }

    }
}