using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Update()
    {
        transform.position = _player.position + new Vector3(13, 0, -10);
    }
}
