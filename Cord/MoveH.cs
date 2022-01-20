using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 5.0f;
   
    
    void Update()
    {
        this.transform.Translate(speed / 50.0f, 0, 0);
    }
}
