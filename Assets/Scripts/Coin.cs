using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    public int coins;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Initial coins: " + coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            Debug.Log("Coins: " + coins);
            Destroy(collision.gameObject);
        }
    }
}
