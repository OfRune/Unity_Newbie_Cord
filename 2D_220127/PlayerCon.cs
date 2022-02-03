using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float speed = 0;// 변수선언
    public float num1 = 1000.0f;
    Vector2 startPos;
    Vector2 endPos;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//만약 마이스 왼쪽클릭 누를시 실행
        {
            this.startPos = Input.mousePosition;
            //this.speed = 0.05f;//시작속도 대입
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            float length = (this.endPos.x - this.startPos.x);
            this.speed = length / num1;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0); //x+ 방향으로 이동
       /* if (Input.GetMouseButton(0))//만약 마이스 왼쪽클릭 누를시 실행
        {
            this.speed = -0.05f;//시작속도 대입
        }*/
        this.speed *= 0.98f; //점차0에 가까워짐(감속)
    }
}
