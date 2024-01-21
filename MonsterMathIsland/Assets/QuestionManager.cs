using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _messageBoxTextField;

    // Start is called before the first frame update
    void Start()
    {
        //FInd random numbers for operand
        int operand1 = Random.Range(1, 100);
        int operand2 = Random.Range(1, 100);

        Debug.Log(operand1);
        Debug.Log(operand2);

        _messageBoxTextField.text = $"{operand1} + {operand2} =";

    }

    // Update is called once per frame
    void Update()
    {

    }
}
