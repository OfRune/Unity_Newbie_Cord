using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float speed = 0;// ��������
    public float num1 = 1000.0f;
    Vector2 startPos;
    Vector2 endPos;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//���� ���̽� ����Ŭ�� ������ ����
        {
            this.startPos = Input.mousePosition;
            //this.speed = 0.05f;//���ۼӵ� ����
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            float length = (this.endPos.x - this.startPos.x);
            this.speed = length / num1;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0); //x+ �������� �̵�
       /* if (Input.GetMouseButton(0))//���� ���̽� ����Ŭ�� ������ ����
        {
            this.speed = -0.05f;//���ۼӵ� ����
        }*/
        this.speed *= 0.98f; //����0�� �������(����)
    }
}
