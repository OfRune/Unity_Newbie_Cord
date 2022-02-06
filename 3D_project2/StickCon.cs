using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickCon : MonoBehaviour
{
    float Speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Translate(-(Speed * Time.deltaTime), 0, 0);
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Translate((Speed * Time.deltaTime), 0, 0);
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
    }
}
