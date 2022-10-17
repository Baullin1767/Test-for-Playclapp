using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField, Tooltip("Поле для ввода")]
    InputField field;
    [SerializeField, Tooltip("Цифра")]
    int number;
    [SerializeField, Tooltip("Текст кнопки")]
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
