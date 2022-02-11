using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timeText;
    GameObject pointText;

    public float time = 60.0f;
    public int point = 100;

    public void GetApple()
    {
        point += 50;
    }
    public void GetBomb()
    {
        point -= 50;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.timeText = GameObject.Find("timer");
        this.pointText = GameObject.Find("score");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        this.timeText.GetComponent<Text>().text = this.time.ToString("F2");
        this.pointText.GetComponent<Text>().text = this.point.ToString();
    }
}
