using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2 : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.01f, 0);
        if(transform.position.y < -8.0f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        //�ڽ��� ��ǥ ���� p1�� ����
        Vector2 p2 = this.player.transform.position;
        //Player�� ��ǥ���� p2�� ����
        Vector2 dir = p1 - p2; //dir�� p1-p2�� ��ǥ ���� ����
        float d = dir.magnitude;
        float r1 = 0.8f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreasHp();
            Destroy(gameObject);
        }
    }
}
