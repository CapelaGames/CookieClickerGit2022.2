using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Search;
using UnityEditor.UI;
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
    
    public int _ballCount = 0;

    public int _ClickMultiplier = 1;

    //List
    //A collection
    //advantage: dynamic resize freely, pretty okay fast
    //disadvantage: not as fast as arrays
    //The count starts at 0
    //The last element in a List is the count of the array, minus 1.
    [SerializeField] private List<GameObject> _ballList;

    //for loop
    // for( int x = 0 ; x < y ; x++)
    // { 
    // }
    private void Start()
    {
        _ballList = new List<GameObject>(); //initialize the list, creating the list in memory

        for (int x = 0; x < 10; x++)
        {
            SpawnOnButton();
        }

        
        //GameObject destoryThisBall = _ballList[2];
        //Delete something from the array:
       // _ballList.Remove(destoryThisBall);
        //we can reference list's just like an array
       // Destroy( destoryThisBall);
        //clean up that spot
        
        
        //_ballList.RemoveAt(0);
        
    }

    public int BallCount()
    {
        return _ballCount;
    }

    public void DeleteOnButton()
    {
        Destroy(_ballList[0]);
        _ballList.RemoveAt(0);
        _ballCount--;
        _text.text = _ballCount.ToString();
    }
    
    public void DeleteAllOnButton()
    {
        for (int x = _ballList.Count - 1; x >= 0 ; x--)
        {
            Destroy(_ballList[x]);
            _ballList.RemoveAt(x);
        }
        _ballCount = 0;
        _text.text = _ballCount.ToString();
    }

    public void SpawnOnButton()
    {
        for (int x = 0; x < _ClickMultiplier; x++)
        {
            _ballCount++; 
            _text.text = _ballCount.ToString();
           // InternalSpawnOnButton();
        }
    }
    public void Remove(int cost)
    {
        if (_ballCount < cost)
        {
            _ballCount -= cost;
        }
        else
        {
            _ballCount = 0;
        }
        _text.text = _ballCount.ToString();
    }
    //variables store values/data
    /*private void InternalSpawnOnButton() //function is called SpawnOnButton
    {
        
        Debug.Log("We have activated the button");
        //variable we made is called randomX
        float randomX = Random.Range(-0.1f, 0.1f); //the f means float
        _position.x += randomX;

        GameObject newBall = Instantiate(ballPrefab, _position, Quaternion.identity);
        _ballList.Add(newBall);
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

    }*/
}




