using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGeneration : MonoBehaviour
{
    [SerializeField] private int _minNumber;
    [SerializeField] private int _maxNumber;
    public int GenerateRandomSumQuestion()
    {
        int rand1 = Random.Range(_minNumber, _maxNumber + 1);
        int rand2 = Random.Range(_minNumber, _maxNumber + 1);

        GetComponent<UI_Handler>().DisplayQuestion(rand1, rand2);
        return rand1 + rand2;
    }
}
