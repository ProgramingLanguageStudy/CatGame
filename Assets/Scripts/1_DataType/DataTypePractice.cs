using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypePractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("----- 연습 문제 -----");

        Debug.Log("1. 자동차 바퀴는 몇 개인가요?(정수형)");
        int carWheels = 4;
        Debug.Log(carWheels);

        Debug.Log("2. 사람의 정상 체온은 몇 도인가요?(실수형)");
        float bodyHeat = 36.5f;
        Debug.Log(bodyHeat);

        Debug.Log("3. 오늘은 무슨 요일간가요?(문자열)");
        string day = "화요일";
        Debug.Log(day);

        Debug.Log("4. 하늘은 파란색이 맞습니까?(불리언)");
        bool isSkyBlue = true;
        Debug.Log(isSkyBlue);

        Debug.Log("----- 연습 문제 -----");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
