using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Move : MonoBehaviour
{
    public float WallSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(WallSpeed*Time.deltaTime, 0, 0);
    }
}
