using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody = default;
    [SerializeField] private Animator animator = default;
    [SerializeField] private float _xvalue = default;
    [SerializeField] private float _speed = default;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        _xvalue = Input.GetAxisRaw("Horizontal");
        Movement();
    }

    private void Movement()
    {
        _rigidbody.velocity = new Vector3(-_xvalue * _speed, 0, 0);
        animator.SetInteger("Velocidad", Mathf.FloorToInt(_xvalue));
    }
}
