using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour //클래스 이름 작성
{
    public int rot_a = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, rot_a, 0);
    }
}
