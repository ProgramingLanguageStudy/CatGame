using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스
// 객체(오브젝트)를 만들기 위한 설계도
// 변수(데이터)와 함수(기능)을 묶어 하나의 단위 관리

// 변수의 적용 범위
// 1) 지역 변수
// 코드 블록 안에서 선언된 변수
// 선언된 코드 블록 안에서만 유효

// 2) 멤버 변수
// 클래스 안에서 선언된 변수
// 클래스 전체에서 사용 가능

// 3) 정적 (멤버) 변수
// 클래스 안에서 static 키워드로 선언된 변수
// 객체(오브젝트)를 생성하지 않고도 사용 가능


// 접근 한정자
// 1) public
// 공개적인
// 클래스 외부에서도 접근 가능
// 다른 스크립트에서 해당 변수/함수를 사용할 수 있다.
// 유니티 인스펙터뷰에서 변수 값을 수정할 수 있다.

// 2) private
// 사적인
// 클래스 내부에서만 접근 가능
// 다른 스크립트에서 해당 변수/함수를 사용할 수 없다.
// 유니티 인스펙터뷰에서 변수 값을 수정할 수 없다.
// 클래스 안에서 사용할 때 접근 한정자를 쓰지 않으면
// 기본적으로 private으로 설정된다.

public class VariableStudy : MonoBehaviour
{
    public string PlayerName = "김철수";
    private int _gold = 0;
    //int _gold = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerName + "입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _gold++;
            // _gold = _gold + 1;
            Debug.Log("현재 골드: " + _gold);
        }
    }
}
