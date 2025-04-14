using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 비교 연산자(==, !=, >, <, >=, <=)
// 두 값을 비교하여 참(true) 또는 거짓(false)을 반환하는 것.

// 1. 동등 연산자(Equal Operator)
// a == b
// a와 b가 동일한 값이면 true, 아니면 false

// 2. 부등 연산자(Not-equal Operator)
// a != b
// a와 b가 다른 값이면 true, 아니면 false

// 3. (대소) 비교 연산자(>, <, >=, <=)
// a > b: a가 b보다 크면 true
// a < b: a가 b보다 작으면 true
// a >= b: a가 b보다 크거나 같으면 true
// a <= b: a가 b보다 작거나 같으면 true


// 논리 연산자(AND(&&), OR(||), NOT(!))
// a && b: a와 b가 둘 다 true일 때만 true
// a || b: a와 b가 하나라도 true이면 true
// !a: a가 true이면 false, a가 false이면 true

public class COperatorStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ----- 동등 연산자(==) ----- //
        int numA = 1;
        int numB = 3;

        bool isEqual = numA == numB;
        Debug.Log("숫자 A와 B가 동일한 값인가요?");
        Debug.Log(isEqual);
        //Debug.Log(numA == numB);
        // ----- 동등 연산자(==) ----- //

        // ----- 부등 연산자(!=) ----- //
        bool isNotEqual = numA != numB;
        Debug.Log("숫자 A와 B가 다른 값인가요?");
        Debug.Log(isNotEqual);
        // ----- 부등 연산자(!=) ----- //

        // ----- 비교 연산자(>, <, >=, <=) ----- //
        Debug.Log("숫자 A가 B보다 큰가요?");
        Debug.Log(numA > numB);

        Debug.Log("숫자 A가 B보다 작나요?");
        Debug.Log(numA < numB);

        Debug.Log("숫자 A가 B보다 크거나 같은가요?");
        Debug.Log(numA >= numB);

        Debug.Log("숫자 A가 B보다 작거나 같은가요?");
        Debug.Log(numA <= numB);
        // ----- 비교 연산자(>, <, >=, <=) ----- //

        // ----- 예시 ----- //
        // 주인공 캐릭터의 체력(Hp)이 0 이하인지 확인
        float playerHp = 10.0f;
        bool isDead = playerHp <= 0.0f;

        // 경험치가 충분하면 레벨 업
        int playerExp = 100;
        bool isLevelUp = playerExp >= 100;

        // 두 캐릭터의 이름이 같은지 확인(==, !=은 문자열에도 사용 가능)
        string nicknameA = "강아지";
        string nicknameB = "고양이";
        bool isSame = nicknameA == nicknameB;
        // bool isSame = false;
        // ----- 예시 ----- //

        // ----- int, float 비교 연산자 ----- //
        int a = 5;
        float x = 5.5f;
        Debug.Log("5.5가 5보다 크거나 같은가요?");
        Debug.Log(x >= a);

        // x = 5.0f;
        // Debug.Log(a == x);
        // 추천드리지 않음
        // (float 변수는 특성상 연산에 따라 정확한 값이 아닐 수 있음.)
        // 단순 대소 비교는 얼마든지 사용해도 좋다.
        // ----- int, float 비교 연산자 ----- //


        // ----- 논리 연산자 ----- //
        bool isSunny = true;        // 날씨가 맑은가?
        bool isWarm = true;         // 날씨가 따뜻한가?
        bool picnicable = isSunny && isWarm;
        // 날씨가 맑고, 따듯해서 피크닉을 갈 수 있는가?
        Debug.Log("날씨가 맑고, 따뜻해서 피크닉을 갈 수 있나요?");
        Debug.Log(picnicable);


        bool hasUmbrella = false;   // 우산이 있는가?
        bool hasRaincoat = true;   // 우비가 있는가?
        bool isOK = hasUmbrella || hasRaincoat;
        // 비를 피할 수 있는가?
        Debug.Log("우산이 있거나, 우비가 있어서 비를 피할 수 있나요?");
        Debug.Log(isOK);

        bool isRainy = !isSunny;
        Debug.Log("비가 오나요?");
        Debug.Log(isRainy);
        // ----- 논리 연산자 ----- //

        // ----- 논리 연산자 예시 ----- //
        bool hasKey = false;        // 열쇠가 있는가?
        bool isThief = true;        // 도둑 캐릭터인가?
        bool canOpenDoor = hasKey || isThief;
        // 열쇠가 있거나, 도둑 캐릭터여서 문을 열 수 있는가?

        float playerMp = 70.0f;     // 주인공의 마나
        float skillMp = 50.0f;      // 스킬 사용 필요 마나
        bool isSkillButtonPressed = true;   // 유저가 스킬 버튼을 눌렀는가?
        bool isSkillActivated
            = playerMp >= skillMp && isSkillButtonPressed;
        // 주인공의 마나가 스킬 사용 필요 마나보다 크거나 같고,
        // 유저가 스킬 버튼을 눌렀는가?
        // -> 스킬이 사용되었는가?
        // ----- 논리 연산자 예시 ----- //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
