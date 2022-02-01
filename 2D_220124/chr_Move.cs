using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chr_Move : MonoBehaviour
{
    public float speed = 1.0f;//�ӵ��ʱⰪ
    float x_Speed = 0; // �ӵ�����
    float y_Speed = 0;
    bool leftFlag = false;//������ȯ
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_Speed = 0;
        y_Speed = 0;
        if (Input.GetKey("right"))
        {
            x_Speed = speed;
            leftFlag = true;
        }
        else if (Input.GetKey("left"))
        {
            x_Speed = -speed;
            leftFlag = false;
        }
        else if (Input.GetKey("up"))
        {
            y_Speed = speed;
        }
        else if (Input.GetKey("down"))
        {
            y_Speed = -speed;
        }        
    }
    private void FixedUpdate()
    {
        this.transform.Translate(x_Speed, y_Speed, 0);
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
