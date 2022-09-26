using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public int cost = 1;
    
    private Button _powerUpButton;
    private SpawnBall _spawnBall;
    
    void Start()
    {
        _powerUpButton = GetComponent<Button>();
        _spawnBall = FindObjectOfType<SpawnBall>();
    }
    void Update()
    {
        if (_spawnBall._ballCount >= cost)
        {
            _powerUpButton.interactable = true;
        }
    }

    public void IncreaseClickMultiplier(int increaseAmount)
    {
        if (_spawnBall._ballCount >= cost)
        {
            _spawnBall._ClickMultiplier += increaseAmount;
            _spawnBall.Remove(cost);
        }
    }


    //The following shows how you would call a Coroutine (you have to use StartCoroutine())
    public void DelayedIncreaseClickMultiplier(int increaseAmount)
    {
        StartCoroutine(DelayBeforeActivating(increaseAmount, 5f));
    }

    //To delay running code it must be placed in a coroutine (special function that allows for delays).
    //following line is an example on how you would create a coroutine
    //IEnumerator CoroutineName()
    IEnumerator DelayBeforeActivating(int increase, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Whatever code you want to be delayed goes here.
        //example below:
        IncreaseClickMultiplier(increase);
    }
}
