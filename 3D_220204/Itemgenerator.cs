using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemgenerator : MonoBehaviour
{
    public GameObject 汗力前荤苞;
    public GameObject 汗力前气藕;
    public float reSpan = 1.0f;
    float delta = 0f;
    public int ratio = 2;
    public float speed = -0.03f;
    
    public void Setparmeter(float reSpan,float speed,int ratio)
    {
        this.reSpan = reSpan;
        this.speed = speed;
        this.ratio = ratio;

    }

    
    void Update()
    {
        this.delta += Time.deltaTime;
        GameObject item;
        int dice = Random.Range(1, 10);
        if(reSpan < delta)
        {
            this.delta = 0;
            if (dice <= this.ratio)
            {
                item = Instantiate(汗力前气藕);
            }
            else
            {
                item = Instantiate(汗力前荤苞);
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 5, z);
            item.GetComponent<ItemCon>().dropspeed = this.speed;
        }
        
        /*if(reSpan < delta)
        {
            this.delta = 0;
            GameObject itemApple = Instantiate(汗力前荤苞);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            float x2 = Random.Range(-1, 2);
            float z2 = Random.Range(-1, 2);
            itemApple.transform.position = new Vector3(x, 5, z);
            GameObject itemBomb = Instantiate(汗力前气藕);
            itemBomb.transform.position = new Vector3(x2, 5, z2);
        }*/
        
    }
}
