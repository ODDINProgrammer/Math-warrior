using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int _currentQuestionAnswer;
    private int _playerAnswer;
    [SerializeField] private GameObject _inputFieldText;

    [SerializeField] private Player _player;


    public void StartBattle()
    {
        _currentQuestionAnswer = GetComponent<QuestionGeneration>().GenerateRandomResult();
    }

    public void CheckAnswer()
    {
        if (int.TryParse(_inputFieldText.GetComponent<Text>().text, out _playerAnswer))
            if (_playerAnswer != _currentQuestionAnswer)
                Debug.Log("Wrong answer!");
            else
                _player.Attack();
    }
}
