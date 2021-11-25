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
        _currentQuestionAnswer = GetComponent<QuestionGeneration>().GenerateRandomSumQuestion();
    }

    public void GenerateNewQuestion()
    {
        _currentQuestionAnswer = GetComponent<QuestionGeneration>().GenerateRandomSumQuestion();
    }

    public void CheckAnswer()
    {
        if (int.TryParse(_inputFieldText.GetComponent<Text>().text, out _playerAnswer))
            //  WRONG
            if (_playerAnswer != _currentQuestionAnswer)
                Debug.Log("Wrong answer!");

            //  CORRECT
            else
            {
                _player.PlayAttackAnimation();
                GetComponent<UI_Handler>().PlayQuestionUIAnimation();
            }

    }
}
