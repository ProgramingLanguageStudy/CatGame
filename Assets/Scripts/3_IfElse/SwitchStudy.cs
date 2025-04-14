using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Switch문.
// 분기문.
// 하나의 대상을 여러 케이스에 대해 비교할 때 매우 유용
// if, else문으로 치환이 가능

/*

switch(조건을 확인할 대상)
{
    case 상수:
        실행될 코드;
    break;
    case 상수:
        실행될 코드;
    break;
    ...
    default:
        실행될 코드;
    break;
}

*/
public class SwitchStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int mouseButtonIndex = 7;   // 0: 좌클릭, 1: 우클릭, 2: 휠클릭
        switch (mouseButtonIndex)
        {
            case 0:
                Debug.Log("좌클릭!");
                break;
            case 1:
                Debug.Log("우클릭!");
                break;
            case 2:
                Debug.Log("휠클릭!");
                break;
            default:
                Debug.Log("클릭 안 함");
                break;
        }

        if (mouseButtonIndex == 0)
            Debug.Log("좌클릭!");
        else if (mouseButtonIndex == 1)
            Debug.Log("우클릭!");
        else if (mouseButtonIndex == 2)
            Debug.Log("휠클릭!");
        else
            Debug.Log("클릭 안 함");


        string day = "금요일";
        switch (day)
        {
            case "월요일":
                Debug.Log("오늘은 월요일입니다.");
                break;
            case "화요일":
            case "수요일":
            case "목요일":
                Debug.Log("오늘은 화요일이거나 수요일이거나 목요일입니다.");
                break;
            case "금요일":
                Debug.Log("오늘은 불금입니다.");
                break;
            case "토요일":
            case "일요일":
                Debug.Log("오늘은 주말입니다.");
                break;
            default:
                Debug.Log("올바른 요일을 입력해 주세요.");
                break;
        }


        // 연습 문제
        // 위의 switch문을 if, else문으로 번역해서
        // 동일한 결과가 나오도록 작성해 주세요!
        if(day == "월요일")
            Debug.Log("오늘은 월요일입니다.");
        else if(day == "화요일" || day == "수요일" || day == "목요일")
            Debug.Log("오늘은 화요일이거나 수요일이거나 목요일입니다.");
        else if(day == "금요일")
            Debug.Log("오늘은 불금입니다.");
        else if(day == "토요일" || day == "일요일")
            Debug.Log("오늘은 주말입니다.");
        else
            Debug.Log("올바른 요일을 입력해 주세요.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
