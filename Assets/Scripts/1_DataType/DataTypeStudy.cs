using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 0. 주석
// 코드를 읽는 사람이 쉽게 이해할 수 있게 도와주는 메모 기능
// 프로그램에는 영향을 미치지 않는다.
// //: 해당 한 줄을 주석으로 처리
// /* {주석 내용} */: 감싸진 부분을 주석으로 처리

// Ctrl + K, C: 선택된 줄들 맨앞에 '//'를 생성해 주석 처리
// Ctrl + K, U: 선택된 줄들 맨앞의 '//'를 제거해 주석 해제

// 1. 변수와 자료형
// 게임을 포함한 모든 프로그램은 자료(데이터)와 명령(로직)으로 이루어진다.
// 자료(데이터)는 숫자, 글자, 캐릭터의 체력 같은 정보이다.
// 명령(로직)은 이 자료를 계산하거나 바꿔서 원하는 결과를 만드는 역할이다.

// 1) 변수
// 코드에서 자료를 저장하는 역할

// 2) 자료형
// 변수 안에 어떤 종류의 자료를 넣을 수 있는지 정하는 규칙

// 2. 대표적인 기본 자료형 4가지
// 1) 정수형(int)
// integer(정수)
// 소수점 없이 딱 떨어지는 수
// ..., -2, -1, 0, 1, 2, ...

// 2) 실수형(float)
// 부동소수점. 소수점이 둥둥 떠다닌다고 해서 부동.
// 소수점이 있는 수(그래서 정확한 값이 아닐 수 있다.)
// 3.14f, 17.1f, -10.05f

// 3) 문자열(string)
// 글자
// "Hello, World!", "김철수", "소환사의 협곡에 오신 것을 환영합니다."

// 4) 불리언(bool)
// 참(true) 또는 거짓(false)
// 배경음이 켜져 있는 여부, 캐릭터가 살아 있는지 여부


public class DataTypeStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 변수 선언(변수 만들기)
        int a;  // 'a'라는 이름의 정수형 변수를 하나 만든 것

        // 변수의 값을 설정하기
        a = 3;  // 'a'라는 변수의 값을 3으로 설정

        // 변수 선언 + 초기값 설정(초기화)
        int score = 100;

        score = a;
        Debug.Log(score);

        // ----- 정수형 ----- //
        Debug.Log("강아지의 다리 개수는?");
        int dogLegs;
        dogLegs = 4;
        Debug.Log(dogLegs);
        // ----- 정수형 ----- //

        // ----- 실수형 ----- //
        Debug.Log("원주율의 소수점 둘째 자리까지 값은?");
        float pi = 3.14f;
        Debug.Log(pi);
        // ----- 실수형 ----- //

        // ----- 문자열 ----- //
        Debug.Log("내가 가장 좋아하는 게임은?");
        string favoriteGame = "문명";
        Debug.Log(favoriteGame);
        Debug.Log("문명");
        // ----- 문자열 ----- //

        // ----- 불리언 ----- //
        Debug.Log("강아지는 식물입니까?");
        bool isDogPlant = false;
        Debug.Log(isDogPlant);

        Debug.Log("강아지는 동물입니까?");
        isDogPlant = true;
        Debug.Log(isDogPlant);
        // ----- 불리언 ----- //
    }


    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
