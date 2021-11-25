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

    internal bool _isBattle = false;

    public void StartBattle()
    {
        _isBattle = true;
        _currentQuestionAnswer = GetComponent<QuestionGeneration>().GenerateRandomSumQuestion();
    }

    public void EndBattle()
    {
        _isBattle = false;
        GetComponent<UI_Handler>().HideBattleUI();
    }

    public void NewQuestion()
    {
        _currentQuestionAnswer = GetComponent<QuestionGeneration>().GenerateRandomSumQuestion();
    }

    public void CheckAnswer()
    {
        if (int.TryParse(_inputFieldText.GetComponent<Text>().text, out _playerAnswer))
            //  WRONG
            if (_playerAnswer != _currentQuestionAnswer)
                return;

        _player.PlayAttackAnimation();
    }
}
