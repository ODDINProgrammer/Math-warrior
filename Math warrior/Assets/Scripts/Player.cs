using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHP;
    private int _currentHP;

    private Enemy _currentEnemy;

    [SerializeField] private GameManager _gameManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            GetComponent<Player_move>().StopPlayer();
            _currentEnemy = collision.transform.GetComponent<Enemy>();
        }
    }
}
