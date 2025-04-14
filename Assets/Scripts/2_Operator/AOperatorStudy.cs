using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 연산자
// 숫자나 값들을 더하고 빼거나 비교하고 판단하는 등,
// 컴퓨터가 계산을 할 수 있도록 도와주는 기호

// 산술 연산자(+, -, *, /, %)

// 연산자 우선순위
// 괄호 ()
// 곱셈 (*), 나눗셈 (/), 나머지 (%)
// 덧셈 (+), 뺄셈(-)


public class AOperatorStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numA = 10;
        int numB = 3;

        int sum = 10 + 3;
        sum = numA + numB;
        sum = numA + 3;
        Debug.Log("A 더하기 B는?");
        Debug.Log(sum);     // 13

        int diff = numA - numB;
        Debug.Log("A 빼기 B는?");
        Debug.Log(diff);        // 7

        int product = numA * numB;
        Debug.Log("A 곱하기 B는?");
        Debug.Log(product);
        Debug.Log(numA * numB);

        int quotient = numA / numB;
        Debug.Log("A 나누기 B의 몫은?");
        Debug.Log(quotient);        // 3(나눗셈의 몫)

        int remainder = numA % numB;
        Debug.Log("A 나누기 B의 나머지는?");
        Debug.Log(remainder);       // 1(나눗셈의 나머지)

        float x = 10.0f;
        float y = 3.0f;
        float result = x / y;
        Debug.Log("실수형 x 나누기 y는?");
        Debug.Log(result);      // 3.3333....


        // 한 번에 여러 연산
        //int a = 1;
        //int b = 2;
        //int c = 3;
        int a = 1, b = 2, c = 3;
        int abcSum = a + b + c;     // 6
        int abcMix = a + b * c;     // 7
        abcMix = (a + b) * c;       // 9


        // 문자열 연결 연산자
        string strA = "제 이름은 ";
        string strB = "입니다.";
        string name = "김철수";
        string sentence = strA + name + strB;
        Debug.Log(sentence);

        string favoriteGame = "문명";
        Debug.Log("제가 가장 좋아하는 게임은 " + favoriteGame + "입니다.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
