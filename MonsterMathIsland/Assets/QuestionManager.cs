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
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerateQuestion()
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

        ClearInputField();
    }

    public void ValidateAnswer()
    {
        if (_answerInputField.text == answer.ToString())
        {
            Debug.Log("Correct");
            GenerateQuestion();
        }
        else
        {
            Debug.Log("Incorrect");
            ClearInputField();
        }

    }

    private void ClearInputField()
    {
        _answerInputField.text = "";
        _answerInputField.ActivateInputField();
    }
}
