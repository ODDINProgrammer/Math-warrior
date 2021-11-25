using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy settings")]
    [SerializeField] internal int _maxHP;
    internal int _currentHP;

    [SerializeField] internal int _damage;

    [TextArea][SerializeField] internal string _description;

    [Header("Accessors")]
    [SerializeField] private GameManager _gameManager;

    [Header("Animator")]
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _currentHP = _maxHP;
    }

    public void ReceiveDamage(int _value)
    {
        _currentHP -= _value;
        _animator.SetTrigger("Attacked");
        _gameManager.GetComponent<UI_Handler>().UpdateEnemyHP(_currentHP);
    }
}
