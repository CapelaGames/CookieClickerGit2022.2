using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAnimManager : MonoBehaviour
{
    [SerializeField] private SpawnBall _spawnBall;

    [SerializeField] private Animator _animator;
    //private int _numberOfBalls
        
    void Update()
    {
        int ballCount = _spawnBall.BallCount();
        
        _animator.SetInteger("BallCount", ballCount);
    }
}
