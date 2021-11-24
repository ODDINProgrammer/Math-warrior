using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] internal int _maxHP;
    internal int _currentHP;

    [SerializeField] internal int _damage;


    [TextArea][SerializeField] internal string _description;
}
