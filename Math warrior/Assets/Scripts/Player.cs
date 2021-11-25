using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHP;
    private int _currentHP;

    private Enemy _currentEnemy;

    [SerializeField] private UI_Handler _ui;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private Animator _animator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            GetComponent<Player_move>().StopPlayer();
            _currentEnemy = collision.transform.GetComponent<Enemy>();

            _ui.DisplayEnemyStatus(_currentEnemy.GetComponentInChildren<SpriteRenderer>().sprite, _currentEnemy._currentHP, _currentEnemy._damage, _currentEnemy._description);
            _ui.PlayEnemyUIAnimation();

            _gameManager.StartBattle();
        }
    }

    public void Attack()
    {
        _animator.SetTrigger("Attack");
    }
}
