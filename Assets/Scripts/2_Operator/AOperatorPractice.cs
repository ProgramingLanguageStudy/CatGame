using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOperatorPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("문제1: a + b의 값은?");
        int a = 322;
        int b = 6;
        int sum = a + b;
        Debug.Log(sum);

        Debug.Log("문제2: x * y의 값은?");
        float x = 5.5f;
        float y = 2.0f;
        float product = x * y;
        Debug.Log(product);

        Debug.Log("문제3: a 나누기 b의 몫과 나머지는?");
        int quot = a / b;
        int rem = a % b;
        Debug.Log("몫: " + quot + ", 나머지: " + rem);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
