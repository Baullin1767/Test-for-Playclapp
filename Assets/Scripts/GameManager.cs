using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region ���� �����
    [SerializeField, Tooltip("���� ����� ������� ������ �����")]
    InputField Time;
    [SerializeField, Tooltip("���� ����� �������� ����")]
    InputField Speed;
    [SerializeField, Tooltip("���� ����� ����, ������� ������ ���")]
    InputField Way; 
    #endregion

    [SerializeField, Tooltip("������ ����")]
    GameObject cubePrefab;

    Cube cubeClone;

    #region ��������� ����
    float time;
    float speed;
    float way;
    #endregion

    bool isGameStart = false;
    bool isCubeExist = false;

    void Update()
    {
        if (isGameStart)
        {
            time = System.Convert.ToInt16(Time.text);
            speed = System.Convert.ToInt16(Speed.text);
            way = System.Convert.ToInt16(Way.text);
            if (!isCubeExist)
            {
                isCubeExist = true;
                StartCoroutine(InvokeCube());
            }
        }
        
    }

    IEnumerator InvokeCube() 
    {
        yield return new WaitForSeconds(time);
        Instantiate(cubePrefab, transform);
        cubeClone = FindObjectOfType<Cube>();
        StartCoroutine(LifeCube());
        cubeClone.SetVelosity(speed);
    }

    IEnumerator LifeCube()
    {
        yield return new WaitForSeconds(way);
        cubeClone.Destroyer();
        isCubeExist = false;
    }

    public void Start_Stop() 
    {
        if (isGameStart)
        {
            isGameStart = false;
            Time.text = "";
            Speed.text = "";
            Way.text = "";
        }
        else
        {
            isGameStart = true;
        }
    }
}
