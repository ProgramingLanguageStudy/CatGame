using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스(class)
// 객체(개체, Object)를 만들기 위한 설계도
// 여러 변수와 함수를 묶어 그룹화해서 관리
// 클래스는 new 키워드로 생성을 해야 새로운 객체가 만들어지는 것

// 값 타입(Value Type), 참조 타입(Reference Type)
// 값 타입은 int, float, struct처럼 복사할 때 값이 그대로 복사되는 타입
// 참조 타입은 class처럼 복사할 때 값이 아니라 메모리 주소만 복사되는 타입

// 클래스 정의하는 방법
// 접근한정자 class 클래스이름
// {
// }




public class Hero
{
    public string Name;     // 캐릭터 이름
    public float Hp;        // 캐릭터의 체력
    public float Mp;        // 캐릭터의 마력

    // 생성자
    // 클래스나 구조체의 객체가 생성될 호출되는 특수한 함수
    // new 키워드로 사용
    public Hero(string name, float hp, float mp)
    {
        Name = name;
        Hp = hp;
        Mp = mp;
    }
    public Hero()
    {

    }

    // 클래스 안에 함수 정의
    public void PrintHero()
    {
        Debug.Log("이름: " + Name + ", 체력: " + Hp
            + ", 마력: " + Mp);
    }
}


public class ClassStudy : MonoBehaviour
{
    // 멤버 변수로 다른 객체를 참조
    public GameObject Cat;      // 고양이 게임오브젝트
    public float MoveSpeed;     // 이동 속력


    // Start is called before the first frame update
    void Start()
    {
        // 1. 클래스 사용
        // Hero 데이터 타입인 변수 선언
        Hero knight = new Hero();

        knight.Name = "기사";
        knight.Hp = 100.0f;
        knight.Mp = 100.0f;

        Debug.Log("이름: " + knight.Name + ", 체력: "
            + knight.Hp + ", 마력: " + knight.Mp);

        // 2. 클래스 사용 - 생성자
        Hero warrior = new Hero("전사", 150.0f, 50.0f);
        warrior.PrintHero();

        // 3. 클래스 복사
        Debug.Log("----- 클래스 복사 -----");

        // 얕은 복사(Shallow Copy)
        Hero wizzard = warrior;
        wizzard.Name = "마법사";
        wizzard.Hp = 50.0f;
        wizzard.Mp = 200.0f;

        warrior.PrintHero();
        wizzard.PrintHero();

        // Hero wizzard = warrior;
        // -> 구조체와 달리 값을 복사한 것이 아니라
        // 메모리 주소만 복사한 것.

        // 정말로 독립적인 복제본을 만들려면?
        // 깊은 복사(Deep Copy)
        Hero warrior1 = new Hero("전사", 150.0f, 50.0f);

        Hero warrior2 = new Hero();
        warrior2.Name = warrior1.Name;
        warrior2.Hp = warrior1.Hp;
        warrior2.Mp = warrior1.Mp;

        warrior2.Name = "전사2";

        warrior1.PrintHero();
        warrior2.PrintHero();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Cat.transform.Translate(MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Cat.transform.Translate(-MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
