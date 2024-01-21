using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _messageBoxTextField;
    [SerializeField] private TMP_InputField _answerInputField;
    [SerializeField] private MonsterManager _monsterManager;


    [SerializeField] int answer;

    // Start is called before the first frame update
    void Start()
    {
        GenerateQuestion();
    }


    private void GenerateQuestion()
    {
        var qa = GenerateAddSubtract(1, 100);

        _messageBoxTextField.text = qa.question;

        ClearInputField();
    }

    //Example of requesting 2 return types
    private (string question, int answer) GenerateAddSubtract(int min, int max)
    {
        int operand1 = Random.Range(min, max);
        int operand2 = Random.Range(min, max);

        string question = "";
        if (Random.value < 0.5f)
        {
            question = $"{operand1} + {operand2} =";
            answer = operand1 + operand2;
        }
        else
        {
            question = $"{operand1} - {operand2} =";
            answer = operand1 - operand2;
        }

        return (question, answer);
    }

    public void ValidateAnswer()
    {
        if (_answerInputField.text == answer.ToString())
        {

            _monsterManager.KillMonster(0);
            _monsterManager.MonsterAttacks(0);
            _monsterManager.MoveNextMonsterToQueue();
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
