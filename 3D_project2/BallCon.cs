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
        startPos = new Vector3(0, 0.5f, 0); //���� �ʱ� ��ġ
        ballRbody.AddForce(ballSpeed, 0, ballSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WALL"))
        {
            Vector3 endPos = collision.transform.position; //�浹�� ����� ���� ��ġ���� ������ ����
            Vector3 incomVec = endPos - startPos; // ���� ��ġ ���Ϳ��� ��� ��ġ ���͸� ���� �Ի簢�� ����ϰ� ������ ����
            Vector3 normalVec = collision.contacts[0].normal; //Collision Ŭ������ ������ �ִ� ���� ���� ������ ������ ����
            Vector3 reflecVec = Vector3.Reflect(incomVec, normalVec);

            reflecVec = reflecVec.normalized; //�ݰ����� ����ȭ ��Ŵ
            ballRbody.AddForce(reflecVec * ballSpeed);//ball�� �ݻ簢 ���͹������� ���� �������� ���� �̵��մϴ�.
        }
        startPos = transform.position; //���� ��ġ ���͸� �ٽ� �����մϴ�.
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
