using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCon : MonoBehaviour
{
    Rigidbody ballRbody;
    public float ballSpeed = 100.0f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        ballRbody = GetComponent<Rigidbody>();
        startPos = new Vector3(0, 0.5f, 0); //공의 초기 위치
        ballRbody.AddForce(ballSpeed, 0, ballSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 endPos = collision.transform.position; //충돌한 대상의 현재 위치정보 변수에 저장
            Vector3 incomVec = endPos - startPos; // 현재 위치 벡터에서 출발 위치 벡터를 빼서 입사각을 계산하고 변수에 저장
            Vector3 normalVec = collision.contacts[0].normal; //Collision 클래스가 가지고 있는 법선 벡터 정보를 변수에 저장
            Vector3 reflecVec = Vector3.Reflect(incomVec, normalVec);

            reflecVec = reflecVec.normalized; //반가각을 정규화 시킴
            ballRbody.AddForce(reflecVec * ballSpeed);//ball에 반사각 벡터방향으로 힘이 가해져서 볼은 이동합니다.
        }
        startPos = transform.position; //현재 위치 벡터를 다시 저장합니다.
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
