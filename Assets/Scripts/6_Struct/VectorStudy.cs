using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Vector3
// 3D 공간에서 위치, 이동, 방향, 크기 등을 표현하는 중요한 자료형(데이터 타입)
// 기본적으로 x, y, z라는 이름의 float 변수 세 개를 갖고 있는 구조체
// 벡터는 크기와 방향을 둘 다 갖는 값

// x 방향 - 좌우
// y 방향 - 상하
// z 방향 - 전후

public class VectorStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("캐릭터의 위치: " + transform.position);

        // 새 Vector3 변수 선언
        Vector3 pos = new Vector3();

        // pos라는 이름의 Vector3 변수 값 설정
        pos.x = 3.0f;
        pos.y = -3.0f;
        pos.z = 0.0f;

        // 현재 게임오브젝트의 위치를 pos로 설정
        transform.position = pos;

        Debug.Log("변경된 캐릭터의 위치: " + transform.position);

        // 새 Vector3 변수 선언 - 생성자
        Vector3 posA = new Vector3(5.0f, 2.0f, 0.0f);
        Debug.Log("posA.x = " + posA.x + ", posA.y = " + posA.y
            + ", posA.z = " + posA.z);

        // Vector3의 상수 배
        posA = 2.0f * posA;     // (10.0f, 4.0f, 0.0f)
        Debug.Log(posA);

        // Vector3의 크기(길이)
        Debug.Log("벡터의 크기: " + posA.magnitude);

        // Vector3의 방향 벡터(같은 방향을 가리키되 크기가 1인 벡터)
        Debug.Log("벡터의 방향: " + posA.normalized);

        // 현재 Vector를 크기가 1인 벡터로 변환해 주는 함수
        posA.Normalize();

        // 벡터의 합
        Vector3 posC = new Vector3(1.0f, 1.0f, 0.0f);
        Vector3 posD = new Vector3(2.0f, 3.0f, 0.0f);

        Vector3 posE = posC + posD;     // (3.0f, 4.0f, 0.0f)
        Debug.Log("posC와 posD의 합: " + posE);

        // 벡터의 뺄셈
        Vector3 posF = posD - posC;     // (1.0f, 2.0f, 0.0f)
        Debug.Log("posC에서 posD로 가는 벡터: " + posF);

        // 두 벡터(지점) 사이의 거리
        float distance = Vector3.Distance(posC, posD);
        Debug.Log("posC와 posD 사이의 거리: " + distance);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0.0f, 1.0f * Time.deltaTime, 0.0f);

        // 보폭 벡터 활용
        Vector3 step = new Vector3(0.0f, 1.0f * Time.deltaTime, 0.0f);
        //transform.Translate(step);

        transform.position = transform.position + step;
    }
}
