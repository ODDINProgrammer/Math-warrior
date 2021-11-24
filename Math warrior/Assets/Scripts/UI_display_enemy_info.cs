using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_display_enemy_info : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthText;
    [SerializeField] private TextMeshProUGUI _damageText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    [SerializeField] private Image _image;
    public void DisplayEnemyStatus(Sprite _enemySprite, int _enemyHP, int _enemyDMG, string _enemyDescription)
    {
        _image.sprite = _enemySprite;
        _healthText.SetText(_enemyHP.ToString());
        _damageText.SetText(_enemyDMG.ToString());
        _descriptionText.SetText(_enemyDescription);
    }
}
