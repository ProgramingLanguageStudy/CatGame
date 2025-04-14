using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public CatGameManager GameManager;
    public GameObject Cat;
    public float MoveSpeed;     // 이동 속력


    // Start is called before the first frame update
    void Start()
    {
        // GameObject.Find();
        // 이름으로 게임오브젝트를 씬에서 찾아 반환해 주는 함수
        Cat = GameObject.Find("Cat");

        // FindObjectOfType<T>();
        // T 자료형의 컴포넌트를 찾아서 반환해 주는 함수
        GameManager = FindObjectOfType<CatGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // 일정한 속력으로 낙하시킨다.
        transform.Translate(0.0f, -MoveSpeed * Time.deltaTime, 0.0f);

        // 화면 밖으로 멀리 가면 파괴시킨다.
        if(transform.position.y < -10.0f)
        {
            // 이 스크립트(컴포넌트가) 부착된 게임오브젝트를 파괴
            Destroy(gameObject);
        }

        // ----- 충돌 판정 ----- //
        Vector3 arrowPos = transform.position;  // 화살표의 위치
        Vector3 catPos = Cat.transform.position;    // 고양이의 위치

        float arrowRadius = 0.5f;   // 화살표의 충돌 반경
        float catRadius = 1.0f;     // 고양이의 충돌 반경

        float distance = Vector3.Distance(arrowPos, catPos);
        //float distance = (catPos - arrowPos).magnitude;

        // 둘 사이의 거리가 충돌 반경의 합보다 작으면 충돌한 것으로 판정
        if(distance < arrowRadius + catRadius)
        {
            Debug.Log("충돌!");
            GameManager.TakeDamage(20.0f);
            Destroy(gameObject);
        }
        // ----- 충돌 판정 ----- //
    }
}
