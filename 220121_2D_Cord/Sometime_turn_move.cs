using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_turn : MonoBehaviour
{
    public float angle = 90.0f;
    public float maxCount = 50.0f;
    public float speed = 0.1f;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed, 0, 0);
        count = count + 1;
        if (count >= maxCount) 
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}
