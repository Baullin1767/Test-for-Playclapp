using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField, Tooltip("���� ��� �����")]
    InputField field;
    [SerializeField, Tooltip("�����")]
    int number;
    [SerializeField, Tooltip("����� ������")]
    Text text;

    private void Start()
    {
        text.text = number.ToString();
    }

    public void SetNumber() 
    {
        field.text += number.ToString();
    }
}
