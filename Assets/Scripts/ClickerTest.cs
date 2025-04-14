using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 이번 프레임에 마우스 버튼이 눌렸는지 여부를 반환
        // 0: 좌클릭, 1: 우클릭
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("클릭!");
        }
        //else
        //{
        //    Debug.Log("클릭 안 됨...");
        //}
    }
}
