using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    
    private List<PowerUp> _powerUps;

    [SerializeField] private int baseCost = 5;

    // Start is called before the first frame update
    void Start()
    {
        _powerUps = new List<PowerUp>( FindObjectsOfType<PowerUp>());
        
        int previousCost = baseCost;
        //loop through each item in _powerUps
        foreach (PowerUp powerUp in _powerUps)
        {
            powerUp.cost = previousCost * 2;
            
            previousCost = powerUp.cost;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
