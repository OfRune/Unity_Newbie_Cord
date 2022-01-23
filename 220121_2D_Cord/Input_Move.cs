using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Move : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.Translate(speed, 0, 0);
        }
        else if (Input.GetMouseButton(0))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if (Input.GetKey("up"))
        {
            transform.Translate(0, speed, 0);
        }
        else if (Input.GetKey("down"))
        {
            transform.Translate(0, -speed, 0);
        }
    }
}
