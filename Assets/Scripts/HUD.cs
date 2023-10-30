using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    
    public Coin purse;
    public Spike spike;
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins: "+purse.coins;
        healthText.text = "Health: " + spike.health;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
