using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _messageBoxTextField;
    [SerializeField] private TMP_InputField _answerInputField;

    string question;
    [SerializeField] int answer;

    // Start is called before the first frame update
    void Start()
    {
        //FInd random numbers for operand
        int operand1 = Random.Range(1, 100);
        int operand2 = Random.Range(1, 100);

        if (Random.value < 0.5f)
        {
            Debug.Log("This is addition");
            question = $"{operand1} + {operand2} =";

            answer = operand1 + operand2;
        }
        else
        {
            Debug.Log("This is subtraction");
            question = $"{operand1} - {operand2} =";

            answer = operand1 - operand2;
        }

        _messageBoxTextField.text = question;

        _answerInputField.Select();


        int rando1 = Random.Range(1, 100);
        Debug.Log(rando1);
        int rando2 = Random.Range(1, 100);
        Debug.Log(rando2);

        if (rando1 < rando2)
        {
            Debug.Log(rando1 + " is less than " + rando2);
        }
        else if (rando2 == rando1)
        {
            Debug.Log(rando1 + " is the same as " + rando2);
        }
        else
        {
            Debug.Log(rando1 + " is more than " + rando2);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
