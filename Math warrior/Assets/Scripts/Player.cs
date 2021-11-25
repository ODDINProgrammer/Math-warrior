using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("HP")]
    [SerializeField] private int _maxHP;
    private int _currentHP;

    [Header("DMG")]
    [SerializeField] private int _damage;

    private Enemy _currentEnemy;

    [Header("Accessors")]
    [SerializeField] private UI_Handler _ui;
    [SerializeField] private GameManager _gameManager;

    [Header("Animator")]
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _currentHP = _maxHP;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            GetComponent<Player_move>().StopPlayer();
            _currentEnemy = collision.transform.GetComponent<Enemy>();

            _ui.SetEnemyStatus(_currentEnemy.GetComponentInChildren<SpriteRenderer>().sprite, _currentEnemy._currentHP, _currentEnemy._damage, _currentEnemy._description);
            _ui.PlayUIShowAnimation();

            _gameManager.StartBattle();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _animator.SetTrigger("Win");
    }

    public void PlayAttackAnimation()
    {
        _animator.SetTrigger("Attack");
    }

    internal void Attack_enemy()
    {
        _currentEnemy.ReceiveDamage(_damage);
    }
}
