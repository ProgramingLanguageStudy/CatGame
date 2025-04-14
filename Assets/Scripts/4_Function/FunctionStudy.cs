using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 0. 코드 블록
// 여러 줄의 코드를 하나의 그룹으로 묶어 주는 것
// 중괄호 {} 안에 들어가는 코드들이 하나의 코드 블록
// 어떤 코드 블록 안에서 선언된 변수는 그 코드 블록 안에서만 유효하다.

// 1. 함수(기능, 명령)
// C#에서는 '메서드'라고 부르기도 함.
// 특정 작업을 수행하는 코드 블록
// 코드를 재사용할 때 사용
// 입력(매개변수)를 받을 수도 있고 출력(반환값)을 줄 수도 있음

// Debug.Log()도 함수
// Start(), Update()도 함수

/*
반환자료형 함수이름(매개변수)
{
    실행할 코드;
    ....

    return 반환값;
}

*/

public class FunctionStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ----- 코드 블록 ----- //
        int outerNum = 0;       // 바깥 코드 블록에서 선언
        {
            int innerNum = 10;  // 안쪽 코드 블록에서 선언
            outerNum = innerNum;
        }
        //outerNum = outerNum + innerNum;
        // innerNum은 이미 자신이 선언된 블록이 끝났으므로 사용 불가

        float damage = 10.0f;
        if(damage > 5.0f)
        {
            string msg = "방패 사용!";
        }
        //Debug.Log(msg);
        // ----- 코드 블록 ----- //

        // ----- 함수 활용 ----- //
        // 1. 반환값이 없고 매개변수가 없는 함수
        SayHello();

        // 2. 반환값이 없고 매개변수가 1개 있는 함수
        string abc = "유니티 함수 연습 중!";
        PrintMessage(abc);
        PrintMessage("유니티 함수 연습 중!");

        // 3. 반환값이 없고 매개변수가 여러 개 있는 함수
        PrintSum(1, 3, 5);

        // 4. 반환값이 있고 매개변수가 없는 함수
        int num = ReturnOne();
        Debug.Log("받은 숫자: " + num);

        // 5. 반환값이 있고 매개변수가 있는 함수
        int sumA = Add(9, 8);
        Debug.Log("9 + 8 = " + sumA);

        int number = 17;
        if (IsEven(number))
        {
            Debug.Log(number + "은(는) 짝수입니다.");
        }
        else
        {
            Debug.Log(number + "은(는) 홀수입니다.");
        }

        // 6. 함수의 오버로딩
        int sumB = Add(6, 7, 8);
        Debug.Log("6 + 7 + 8 = " + sumB);

        float sumC = Add(7.5f, 12.345678f);
        Debug.Log(sumC);
        // ----- 함수 활용 ----- //

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // 1. 반환값이 없고 매개변수가 없는 함수
    void SayHello()
    {
        Debug.Log("안녕하세요!");
    }

    // 2. 반환값이 없고 매개변수가 1개 있는 함수
    void PrintMessage(string message)
    {
        Debug.Log("메시지: " + message);
    }

    // 3. 반환값이 없고 매개변수가 여러 개 있는 함수
    void PrintSum(int a, int b, int c)
    {
        int sum = a + b + c;
        Debug.Log("숫자의 합: " + sum);
    }

    // 4. 반환값이 있고 매개변수가 없는 함수
    int ReturnOne()
    {
        return 1;
    }

    // 5. 반환값이 있고 매개변수가 있는 함수
    int Add(int a, int b)
    {
        return a + b;
    }

    // 주어진 숫자 number가 짝수인지 홀수인지 여부를 되돌려 주는 함수
    bool IsEven(int number)
    {
        bool isEven = number % 2 == 0;
        return isEven;

        //return number % 2 == 0;
    }

    // 6. 함수의 오버로딩
    int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    float Add(float a, float b)
    {
        return a + b;
    }
}
