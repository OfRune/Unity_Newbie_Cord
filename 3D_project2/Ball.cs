using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = 500.0f;  //���� �ӵ�
    Rigidbody ballRbody;  //�浹����
    bool ballMove = false;  //�� �߻縦 ���� bool�Լ�
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
    private void OnTriggerEnter(Collider other)// ���� �ٸ� ������Ʈ�� �ε�ġ�� ����
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
        if (Input.GetKeyDown("space") && !ballMove)   //space�� ������ ����
        {
            transform.parent = null;
            ballMove = true;                         //�� �߻�
            ballRbody.isKinematic = false;
            ballRbody.AddForce(new Vector3(ballSpeed, 0, ballSpeed)); //���� �ӵ���ŭ ��ǥ�̵�
        }                                                             //�� ƨ���� Physic Material�� Bounciness�� �����Ͽ� ������
    
    }

}