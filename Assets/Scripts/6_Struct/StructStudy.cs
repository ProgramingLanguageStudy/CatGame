using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 구조체(struct)
// 여러 개의 변수를 하나의 자료형(데이터 타입)으로 묶어 관리할 때 사용
// 구조체를 정의하게 되면 우리가 새로운 자료형을 하나 만든 것.
// (클래스와 유사하지만 값 타입(Value Type))


// 구조체 정의하는 방법
// 접근한정자 struct 구조체이름
// {
// }

// HeroStats라는 이름의 자료형을 만들어 준 것
public struct HeroStats
{
    public string Name;
    public float Hp;
    public float Mp;

    // 생성자
    // 클래스나 구조체의 객체가 생성될 때 호출되는 특수한 함수
    // new 키워드로 사용
    // 구조체 생성자의 경우 모든 멤버 변수를 초기화해야 함
    public HeroStats(string name, float hp, float mp)
    {
        Name = name;
        Hp = hp;
        Mp = mp;
    }

    // 구조체 안에 함수를 정의할 수 있다.
    public void PrintHeroStats()
    {
        Debug.Log("이름: " + Name + ", 체력: " + Hp
            + ", 마력: " + Mp);
    }
}

public class StructStudy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. 구조체 사용
        //int num = 3;

        //int num;
        //num = 3;

        int num = new int();
        num = 5;
        // int 값을 저장할 수 있는 공간을 메모리에 확보하고
        // 거기에 num이라고 이름 붙인다.

        HeroStats stats = new HeroStats();
        // HeroStats의 데이터들을 저장할 수 있는 공간을 메모리에 확보하고
        // 거기에 heroStats라고 이름 붙인다.

        stats.Name = "전사";
        stats.Hp = 100.0f;
        stats.Mp = 100.0f;
        Debug.Log("이름: " + stats.Name + ", 체력: " + stats.Hp 
            + ", 마력: " + stats.Mp);

        stats.Hp = 200.0f;
        Debug.Log("이름: " + stats.Name + ", 체력: " + stats.Hp
    + ", 마력: " + stats.Mp);

        // 2. 구조체 사용 - 생성자
        HeroStats warriorStats = new HeroStats("전사", 200.0f, 50.0f);
        warriorStats.PrintHeroStats();

        // 3. 구조체 복사
        Debug.Log("----- 구조체 복사 -----");
        int a = 10;
        int b = a;
        b = 20;
        Debug.Log("숫자 a: " + a);
        Debug.Log("숫자 b: " + b);

        HeroStats knightStats = new HeroStats("기사", 300.0f, 50.0f);
        HeroStats wizzardStats = knightStats;
        wizzardStats.Name = "마법사";
        wizzardStats.Hp = 50.0f;
        wizzardStats.Mp = 200.0f;

        knightStats.PrintHeroStats();
        wizzardStats.PrintHeroStats();

        // 4. Vector3 사용
        Vector3 pos = transform.position;
        Debug.Log(pos);

        pos.x = 5.0f;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
