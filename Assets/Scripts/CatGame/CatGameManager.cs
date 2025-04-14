using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CatGameManager : MonoBehaviour
{
    [Header("----- 화살표 스폰 -----")]
    // 복제할 화살표들의 원본이 되는 화살표 게임오브젝트
    public GameObject ArrowPrefab;

    public float SpawnSpan; // 스폰 간격(초)
    public float SpawnPosY; // 스폰 위치 y값
    public float SpawnPosXRange;    // 스폰 위치 x값의 범위

    public float SpawnTimer = 0.0f; // 스폰 타이머

    [Header("----- 스탯 -----")]
    public float MaxHp = 100.0f;        // 최대 체력
    public float CurrentHp = 100.0f;    // 현재 체력
    public bool IsAlive = true;         // 주인공이 살아 있는지 여부

    [Header("----- 점수 -----")]
    public int Score = 0;           // 점수

    [Header("----- UI 요소들 참조 -----")]
    public Image HpGauge;
    public GameObject ScoreText;
    public GameObject GameOverPanel;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTimer = SpawnSpan;
    }

    // Update is called once per frame
    void Update()
    {
        // 주인공이 죽었을 경우
        if (IsAlive == false)
        {
            // 함수를 즉시 종료한다.
            return;
        }

        SpawnTimer -= Time.deltaTime;
        if(SpawnTimer < 0.0f)
        {
            // 스폰 타이머 재충전
            SpawnTimer = SpawnSpan;

            // Instantiate(GameObject)
            // 원본 게임오브젝트의 복사본을 씬에 생성해 반환해 주는 함수
            // ArrowPrefab의 복제본을 씬에 생성
            GameObject arrow = Instantiate(ArrowPrefab);

            // Random.Range(float, float)
            // 특정 범위 내의 랜덤한 값을 반환해 주는 함수
            float posX = Random.Range(-SpawnPosXRange, SpawnPosXRange);

            // 생성된 화살표가 처음 위치할 좌표(Vector3)를 설정
            Vector3 spawnPos = new Vector3(posX, SpawnPosY, 0.0f);

            // 화살표가 위치할 좌표를 실제로 화살표 게임오브젝트에 적용
            arrow.transform.position = spawnPos;

            // 점수 증가
            Score++;
            //Score = Score + 1;

            UpdateScoreText();
        }
    }

    public void TakeDamage(float damage)
    {
        // 주인공이 죽었을 경우
        if (IsAlive == false)
        {
            // 함수를 즉시 종료한다.
            return;
        }

        CurrentHp -= damage;
        // CurrentHp = CurrentHp - damage;

        // 현재 체력이 최대 체력보다 높아지는 경우
        if(CurrentHp > MaxHp)
        {
            CurrentHp = MaxHp;
        }

        if(CurrentHp <= 0.0f)
        {
            // 게임 오버 처리
            IsAlive = false;
            GameOverPanel.SetActive(true);
        }

        HpGauge.fillAmount = CurrentHp / MaxHp;
    }

    // ScoreText 오브젝트를 갱신하는 함수
    void UpdateScoreText()
    {
        // GetComponent<T: 갖고 오고 싶은 컴포넌트의 자료형>()
        // 게임오브젝트로부터 T 타입인 컴포넌트 객체를 가져오는 함수
        Text scoreText = ScoreText.GetComponent<Text>();
        scoreText.text = "Score: " + Score;
    }


    // 게임을 재시작하는 함수
    public void RestartGame()
    {
        // SceneManager.LoadScene()
        // 씬 이름이나, 씬 번호(인덱스)로
        // 씬을 로드하는 함수
        SceneManager.LoadScene("CatGame");
    }
}
