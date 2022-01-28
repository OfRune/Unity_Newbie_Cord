using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject player; //�÷��̾� ������Ʈ ����
    GameObject player2; //��ǥ�� ������Ʈ�� ������ ���� ��������
    GameObject distance; //�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� UI�� ����

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.player2 = GameObject.Find("End");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.player2.transform.position.x - this.player.transform.position.x;

        if(lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + lengthDis.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!!!";
        }
        
    }
}
