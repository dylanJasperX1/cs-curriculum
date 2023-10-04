using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COINS : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin collected");

        }
    }
}
