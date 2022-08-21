using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAudio : MonoBehaviour
{
    [SerializeField] private AudioClip _audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<Camera>().GetComponentInChildren<AudioSource>().clip = _audioClip;
        FindObjectOfType<Camera>().GetComponentInChildren<AudioSource>().Play();
    }
}
