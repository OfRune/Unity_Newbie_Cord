using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon2 : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody playerRd; //리지드바디 컴포넌트를 대입할 변수
    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRd.AddForce(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRd.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRd.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRd.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerRd.AddForce(0, speed, 0);
        }
    }
}
