using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Rigidbody2D _rb;
    private int _movingSpeed = 2;
    private Animator _animator;

    private bool _isMoving = true;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_isMoving)
        {
            _animator.SetBool("isMoving", true);
            transform.position += Vector3.right * _movingSpeed * Time.deltaTime;
        }
    }

    public void StopPlayer()
    {
        _isMoving = false;
        _animator.SetBool("isMoving", false);
    }

    public void LetPlayerMove()
    {
        _isMoving = true;
    }
}
