using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;


//using Unity.UI;

//PascalCasing
    //classes

//camelCasing
    //variables
    //private variables use underscore _camelCasing


//Class is called SpawnBall
public class SpawnBall : MonoBehaviour //MonoBehaviour is for unity
{
    //SerializeField allows unity to access and modify the variable
    //private means that no other class can access the variable/function
    //public means that unity and other classes can access the variable/function
    public GameObject ballPrefab;
    [SerializeField] private GameObject _surpriseImage;
    [SerializeField] private Vector3 _position;
    [SerializeField] private TMP_Text _text;

    private int _ballCount = 0;
    //[SerializeField] private Text text;
    
    //int       - Whole numbers: -3,-2, -1, 0,1,2,3,4,5,6,7
    //float     - Decimals
    //string    - words/character/letter "2"
    //bool      - True or False

    private void Start()
    {
        //text.text = "Hello World!";
    }

    //variables store values/data
    public void SpawnOnButton() //function is called SpawnOnButton
    {
        Debug.Log("We have activated the button");
        //variable we made is called randomX
        float randomX = Random.Range(-0.1f, 0.1f); //the f means float
        _position.x += randomX;

        Instantiate(ballPrefab, _position, Quaternion.identity);
        //ballCount += 1;
        _ballCount++; //the ++ means we will increase the number by 1
        _text.text = _ballCount.ToString();

        // left == right   //checking if the values are the same
        // left < right    // is the left value less than (smaller) than the right
        // left > right    //same as above but is left greater than right
        // left <= right   // less than or equal to
        // left >= right   // greater than or equal to 
        if (_ballCount > 20)
        {
            //we only run this code if the above statement is true
            
            _surpriseImage.SetActive(true); //set surprise image to active
            
        }
        
        
    }
}




