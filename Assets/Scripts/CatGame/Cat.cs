using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 프레임
// 각각의 한 정지 장면
// 유니티는 매우 빠르게 지속적으로 한 프레임씩 작업을 반복

public class Cat : MonoBehaviour
{
    public CatGameManager GameManager;
    public float MoveSpeed = 2.0f;      // 이동 속력

    // Start is called before the first frame update

    // 첫 프레임 바로 직전에 호출되는 함수
    void Start()
    {
        
    }

    // Update is called once per frame

    // 매 프레임마다 한 번씩 호출되는 함수
    void Update()
    {
        //Debug.Log(Time.frameCount);
        //transform.Translate(0.01f, 0.0f, 0.0f);

        // 마우스 입력을 처리하는 함수 실행
        //HandleMouseInput();

        if(GameManager.IsAlive == false)
            return;

        // 키보드 입력을 처리하는 함수 실행
        HandleKeyboardInput();
    }

    // 마우스 입력을 처리하는 함수
    void HandleMouseInput()
    {
        // 0: 좌클릭, 1: 우클릭, 2: 휠클릭
        // 이번 프레임에 마우스 버튼을 누른 경우 true를 반환하는 함수
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("마우스 클릭");
        //}

        // 이번 프레임에 마우스 버튼이 눌려 있는 경우 true를 반환하는 함수
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("마우스 클릭 중...");
            transform.Translate(1.0f * Time.deltaTime, 0.0f, 0.0f);
            // Time.deltaTime
            // 이전 프레임부터 이번 프레임까지 걸린 시간
        }
        if (Input.GetMouseButton(1))
        {
            transform.Translate(-1.0f * Time.deltaTime, 0.0f, 0.0f);
        }

        // 이번 프레임에 마우스 버튼을 뗀 경우 true를 반환하는 함수
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("마우스 클릭 끝");
        //}
    }

    // 키보드 입력을 처리하는 함수
    void HandleKeyboardInput()
    {
        //float moveSpeed = 2.0f;

        // Time.deltaTime
        // 이전 프레임과 현재 프레임 사이의 시간 차이(초 단위)
        // 게임에서 매 프레임마다 실행되는 코드가
        // 일정한 속도로 동작하도록 보정하는 데 사용
        // 프레임 속도(FPS)가 다르더라도 일정한 움직임을 유지할 수 있다.

        // 키보드 입력을 받아 이동
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    Debug.Log("위쪽으로 이동");
        //    transform.Translate(0.0f, moveSpeed * Time.deltaTime, 0.0f);
        //}
        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    Debug.Log("아래쪽으로 이동");
        //    transform.Translate(0.0f, -moveSpeed * Time.deltaTime, 0.0f);
        //}


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("왼쪽으로 이동");
            transform.Translate(-MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("오른쪽으로 이동");
            transform.Translate(MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        Vector3 pos = transform.position;

        // pos.x의 최대값을 8.0f로 한정
        if(pos.x > 8.0f)
        {
            pos.x = 8.0f;
        }
        // pos.y의 최소값을 -8.0f로 한정
        if(pos.x < -8.0f)
        {
            pos.x = -8.0f;
        }

        transform.position = pos;
    }
}
