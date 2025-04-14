using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 대입연산자(=, +=, -=, *=, /=)
// 오른쪽의 값을 왼쪽 변수의 값으로 설정(대입)해 주는 것.

// 증감연산자(++, --)
// int 변수의 값을 +1, -1 해 주는 것.

public class BOperatorStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ----- 대입 연산자 ----- //
        int a = 7;
        int b = 5;

        a += b;     // a = a + b;
        Debug.Log(a);       // 12

        a -= b;     // a = a - b;
        Debug.Log(a);       // 7

        a *= b;     // a = a * b;
        a /= b;     // a = a / b;
        // ----- 대입 연산자 ----- //

        // ----- 증감 연산자 ----- //
        int score = 0;
        score++;        // score = score + 1;
        Debug.Log(score);

        score--;        // score = score - 1;
        Debug.Log(score);
        // ----- 증감 연산자 ----- //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
