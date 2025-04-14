using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 조건문.
// 목표
// true, false 불리언 값에 따라
// 실행되는 코드가 달라지도록 코드 흐름을 제어할 수 있다.

// if: 조건이 참(true)이면 실행되는 코드 블록
// else: 조건이 거짓(false)이면 실행되는 코드 블록

/*
if (조건(bool))
{
조건이 true일 경우 실행되는 코드
}
else
{
조건이 false일 경우 실행되는 코드
}
*/

public class IfElseStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ----- 조건문 ----- //

        // 1. if, else 기본 조건문 사용
        float enemyHp = -10.0f;
        bool isDead = enemyHp <= 0.0f;

        if (isDead)
        {
            Debug.Log("적 처치!");
        }
        else
        {
            Debug.Log("적 생존");
        }

        // 2. if만 사용
        float rage = 80.0f;
        if(rage >= 50.0f)
        {
            Debug.Log("보스 스킬 발동!");
        }

        // 3. if, else if, else 사용
        float speed = 12.0f;
        if(speed >= 20.0f)
        {
            Debug.Log("전력 질주 중");
        }
        else if(speed >= 15.0f)
        {
            Debug.Log("달리는 중");
        }
        else if(speed >= 10.0f)
        {
            Debug.Log("빠르게 걷는 중");
        }
        else
        {
            Debug.Log("천천히 걷는 중");
        }

        // 4. if 여러 개 사용
        int numA = 11;
        if(numA > 10)
        {
            Debug.Log("numA는 10보다 큽니다.");
        }

        if(numA >= 10)
        {
            Debug.Log("numA는 10보다 크거나 같습니다.");
        }

        if(numA > 11)
        {
            Debug.Log("numA는 11보다 큽니다.");
        }

        if(numA >= 11)
        {
            Debug.Log("numA는 11보다 크거나 같습니다.");
        }

        // 5. if문 안에 if문 사용
        int numB = 25;
        if(numB >= 20)
        {
            if(numB % 2 == 0)
            {
                Debug.Log("numB는 20 이상인 짝수입니다.");
            }
            else
            {
                Debug.Log("numB는 20 이상인 홀수입니다.");
            }
        }
        else
        {
            Debug.Log("numB는 20보다 작은 수입니다.");
        }
        // ----- 조건문 ----- //

        // ----- 예시 ----- //
        float playerMp = 70.0f;     // 주인공의 마나
        float skillMp = 50.0f;      // 스킬 사용 필요 마나
        bool isSkillButtonPressed = true;   // 유저가 스킬 버튼을 눌렀는가?
        //bool isSkillActivated
        //    = playerMp >= skillMp && isSkillButtonPressed;
        if(playerMp >= skillMp && isSkillButtonPressed)
        {
            Debug.Log("스킬 사용!");
        }


        bool hasKey = false;    // 열쇠를 갖고 있는지 여부
        bool isThief = true;    // 주인공 캐릭터가 도둑인지 여부
        if (isThief)
        {
            Debug.Log("도둑이 잠긴 문을 열었습니다.");
        }
        else
        {
            if (hasKey)
            {
                Debug.Log("열쇠로 잠긴 문을 열었습니다.");
            }
            else
            {
                Debug.Log("열쇠가 없어 문을 열 수 없습니다.");
            }
        }


        int number = 7;
        if(number % 2 == 0)     // 2로 나눈 나머지가 0이면 짝수
        {
            number = number / 2;
        }
        else // 2로 나눈 나머지가 0이 아니면 홀수
        {
            number = number * 2;
        }

        Debug.Log("number는 " + number + "입니다.");
        // ----- 예시 ----- //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
