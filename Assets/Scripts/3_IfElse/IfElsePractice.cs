using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1) 주어진 숫자(number)가 짝수이면 "짝수",
        // 홀수이면 "홀수"라는 답이 출력되도록 해 주세요.
        Debug.Log("1번 문제");
        int number = 36;
        if (number % 2 == 0)
            Debug.Log("짝수입니다.");
        else
            Debug.Log("홀수입니다.");

        // 2) 주어진 점수(score)가 90점 이상이면 "A"
        // 80점 이상이면 "B", 70점 이상이면 "C",
        // 나머지는 "D"가 출력되도록 해 주세요.
        // 여러 등급의 메시지가 연달아 출력되는 게 아니라
        // 한 번만 출력되어야 합니다!
        Debug.Log("2번 문제");
        int score = 73;
        if(score >= 90)
        {
            Debug.Log("A");
        }
        else if(score >= 80)
        {
            Debug.Log("B");
        }
        else if(score >= 70)
        {
            Debug.Log("C");
        }
        else
        {
            Debug.Log("D");
        }

        // 3) 주인공의 레벨(heroLevel)이 5 이상이고
        // 체력(hp)가 100.0 이상이면 "아이템 장착 가능!"이
        // 출력되게 해 주세요!
        Debug.Log("3번 문제");
        int heroLevel = 7;
        float heroHp = 150.0f;

        if(heroLevel >= 5 && heroHp >= 100.0f)
        {
            Debug.Log("아이템 장착 가능!");
        }

        // 4) 주인공의 레벨이 10 이상이고
        // 열쇠를 가지고 있으면 "보스방 입장 가능!"
        // 주인공의 레벨이 10 이상이지만, 열쇠가 없으면 "열쇠 필요"
        // 주인공의 레벨이 10 미만이면 "레벨이 부족합니다."
        // 가 출력되도록 해 주세요!
        Debug.Log("4번 문제");
        int playerLevel = 10;       // 주인공 레벨
        bool hasKey = false;        // 열쇠 소유 여부

        if(playerLevel >= 10)
        {
            if (hasKey)
            {
                Debug.Log("보스방 입장 가능!");
            }
            else
            {
                Debug.Log("열쇠 필요");
            }
        }
        else
        {
            Debug.Log("레벨이 부족합니다.");
        }

        // 5) 추가 도전 과제
        // 영화관.
        // 12살 이하 어린이이거나, 65세 이상 노인이면 50% 할인
        // 12살 초과 19살 이하 청소년이면 20% 할인
        // 평일이면 10% 추가 할인
        // 오전 6시부터 오전 10시까지 10% 추가 할인
        // 어떤 것도 해당되지 않으면 할인 X
        // 조건에 따라 몇 % 할인이 되는지 출력해 보세요!
        Debug.Log("5번 추가 문제");
        int age = 13;           // 나이
        bool isWeekday = true;  // 지금 평일인지 여부
        int hour = 9;           // 현재 시간(오전 9시)
        float discountRate = 0.0f;  // 할인 %

        if(age <= 12 || age >= 65)
        {
            discountRate += 50.0f;
        }
        else if(age <= 19)
        {
            discountRate += 20.0f;
        }

        if (isWeekday)
        {
            discountRate += 10.0f;
        }

        if(hour >= 6 && hour <= 10)
        {
            discountRate += 10.0f;
        }

        Debug.Log(discountRate + "% 할인됩니다!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
