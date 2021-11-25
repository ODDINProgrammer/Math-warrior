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

    [SerializeField] private Animator _enemyUIAnimator;
    public void DisplayEnemyStatus(Sprite _enemySprite, int _enemyHP, int _enemyDMG, string _enemyDescription)
    {
        _image.sprite = _enemySprite;
        _healthText.SetText(_enemyHP.ToString());
        _damageText.SetText(_enemyDMG.ToString());
        _descriptionText.SetText(_enemyDescription);
    }

    public void PlayEnemyUIAnimation()
    {
        _enemyUIAnimator.SetTrigger("Show");
    }

    public void DisplayQuestion(int value1, int value2)
    {
        _questionText.SetText(value1 + " + " + value2);
    }
}
