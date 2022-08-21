using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPopUp : MonoBehaviour
{
    [TextArea] [SerializeField] private string _text;
    [SerializeField] private GameObject _popUpText;
    [SerializeField] private float _disableAfter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            _popUpText.SetActive(true);
            _popUpText.GetComponent<TextMeshProUGUI>().SetText("You: " + _text);
            Invoke("DisableTextObject", _disableAfter);
        }
    }

    private void DisableTextObject()
    {
        _popUpText.SetActive(false);
    }
}
