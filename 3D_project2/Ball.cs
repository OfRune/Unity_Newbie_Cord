using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 500.0f;  //공의 속도
    Rigidbody ballRbody;  //충돌판정
    bool ballMove = false;  //공 발사를 위한 bool함수
    public AudioClip Sound;
    AudioSource aud;
    private void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        ballRbody = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)// 공과 다른 오브젝트가 부딪치면 제거
    {
        if (other.gameObject.tag == "Sound")
        {
            this.aud.PlayOneShot(this.Sound);

        }
        Destroy(other.gameObject);
    }
    void Update()
    {
        if (this.transform.position.z < -10.0f)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown("space") && !ballMove)   //space를 누를시 실행
        {
            transform.parent = null;
            ballMove = true;                         //공 발사
            ballRbody.isKinematic = false;
            ballRbody.AddForce(new Vector3(ballSpeed, 0, ballSpeed)); //공의 속도만큼 좌표이동
        }                                                             //공 튕김은 Physic Material의 Bounciness를 조정하여 구현함
    
    }

}