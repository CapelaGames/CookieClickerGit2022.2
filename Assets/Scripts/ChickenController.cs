using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Makes sure there is an Animator on this gameobject
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class ChickenController : MonoBehaviour
{
    private float _speed;
    [SerializeField] private float _WalkSpeed = 2f;
    [SerializeField] private float _RunSpeed = 5f;
    private Animator _animator;
    private SpriteRenderer _sprite;

    void Start()
    {
        //Look for an Animator and store it in _animator
        _animator = GetComponent<Animator>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        bool hasMoved = false;
        string animation;
        _animator.SetBool("IsRunning", false);
        _animator.SetBool("IsWalking", false);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = _RunSpeed;
            animation = "IsRunning";
        }
        else
        {
            _speed = _WalkSpeed;
            animation = "IsWalking";
        }
        
        //GetKey checks if the key is currently being pressed <-- continuous 
        //GetKeyUp check if the key is released that frame   <-- just once
        //GetKeyDown check if the key is pressed that frame  <-- just once
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 chickenPos = transform.position; //get the objects position
            chickenPos.x += _speed * Time.deltaTime; //update the variable to the new position
            transform.position = chickenPos; //set the object position with the updated variable
            _animator.SetBool(animation, true);
            _sprite.flipX = false;
            hasMoved = true;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 chickenPos = transform.position; //get the objects position
            chickenPos.x -= _speed * Time.deltaTime; //update the variable to the new position
            transform.position = chickenPos; //set the object position with the updated variable
            _animator.SetBool(animation, true);
            _sprite.flipX = true;
            hasMoved = true;
        }

        if (hasMoved == false)
        {
            _animator.SetBool("IsRunning", false);
            _animator.SetBool("IsWalking", false);
        }
    }
}
