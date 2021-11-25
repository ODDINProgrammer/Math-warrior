using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_UI : MonoBehaviour
{
    [Header("Accessors")]
    [SerializeField] private GameManager _gameManager;

    public void GenerateNewQuestion()
    {
        _gameManager.GenerateNewQuestion();
    }
}
