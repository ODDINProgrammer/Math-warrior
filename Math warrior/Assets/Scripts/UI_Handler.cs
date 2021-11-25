using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Handler : MonoBehaviour
{
    [Header("Enemy")]
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private TextMeshProUGUI _damageText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private Image _image;

    [Header("Question")]
    [SerializeField] private TextMeshProUGUI _questionText;
    [SerializeField] private InputField _questionInputField;

    [Header("Animators")]
    [SerializeField] private Animator _enemyUIAnimator;
    [SerializeField] private Animator _questionUIAnimator;
    public void SetEnemyStatus(Sprite _enemySprite, int _enemyHP, int _enemyDMG, string _enemyDescription)
    {
        _image.sprite = _enemySprite;
        _healthText.SetText(_enemyHP.ToString());
        _damageText.SetText(_enemyDMG.ToString());
        _descriptionText.SetText(_enemyDescription);
    }

    public void UpdateEnemyHP(int _enemyCurrentHP)
    {
        _healthText.SetText(_enemyCurrentHP.ToString());
    }

    public void PlayUIShowAnimation()
    {
        _enemyUIAnimator.SetTrigger("Show");
        _questionUIAnimator.SetTrigger("Show");
    }

    public void PlayQuestionUIAnimation()
    {
        _questionUIAnimator.SetTrigger("GenerateQuestion");
    }    

    public void DisplayQuestion(int value1, int value2)
    {
        _questionInputField.Select();
        _questionInputField.text = "";
        _questionText.SetText(value1 + " + " + value2);
    }
}
