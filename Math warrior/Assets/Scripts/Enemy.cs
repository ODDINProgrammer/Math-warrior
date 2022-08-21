using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy settings")]
    [SerializeField] internal int _maxHP;
    internal int _currentHP;
    [SerializeField] private bool _canAttack = false;

    [SerializeField] internal int _damage;

    [TextArea] [SerializeField] internal string _description;

    [Header("Accessors")]
    [SerializeField] private GameManager _gameManager;

    [Header("Animator")]
    [SerializeField] private Animator _animator;



    public void ReceiveDamage(int _value)
    {
        _currentHP -= _value;
        _animator.SetTrigger("Attacked");
        _gameManager.GetComponent<UI_Handler>().UpdateEnemyHP(_currentHP);

        if (_currentHP <= 0)
        {
            _gameManager.EndBattle();
            Invoke("DelayedDestroy", 0.2f);
            return;
        }

        if (_canAttack)
        {
            Invoke("AttackPlayer", 0.5f);
            return;
        }
        PlayQuestAnimation();
    }

    public void PlayQuestAnimation()
    {
        _gameManager.GetComponent<UI_Handler>().PlayQuestionUIAnimation();
    }

    private void Start()
    {
        _currentHP = _maxHP;
    }

    private void DelayedDestroy()
    {
        Destroy(gameObject);
    }
    private void AttackPlayer()
    {
        _animator.SetTrigger("Attack");
    }
}
