using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCon : MonoBehaviour
{
    public float dropspeed = 1f;
    
    void Update()
    {
        transform.Translate(0, -dropspeed*Time.deltaTime, 0);
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
    }
}
