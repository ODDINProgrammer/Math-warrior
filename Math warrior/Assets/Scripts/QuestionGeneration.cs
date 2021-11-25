using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGeneration : MonoBehaviour
{
    public int GenerateRandomResult()
    {
        int _rand1 = Random.Range(0, 100);
        int _rand2 = Random.Range(0, 100);

        GetComponent<UI_Handler>().DisplayQuestion(_rand1, _rand2);
        return _rand1+_rand2;
    }
}
