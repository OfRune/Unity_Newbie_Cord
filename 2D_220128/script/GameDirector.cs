using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject player; //플레이어 오브젝트 대입
    GameObject player2; //목표물 오브젝트를 대입할 변수 데이터형
    GameObject distance; //플레이어 오브젝트와 목표물 오브젝트 사이의 거리의 UI를 대입

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
            this.distance.GetComponent<Text>().text = "목표지점" + ":" + lengthDis.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!!!";
        }
        
    }
}
