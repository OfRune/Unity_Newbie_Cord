using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPrefab : MonoBehaviour
{
    public GameObject �����簢��;
    public GameObject ����ü��;
    public float respan = 1.0f;
    float delta = 0;
    public int ratio = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;
        GameObject item;
        int dice = Random.Range(1, 10);
        if(this.delta > this.respan)
        {
            this.delta = 0;
            if (dice < this.ratio)
            {
                item = Instantiate(����ü��);
            }
            else
            {
                item = Instantiate(�����簢��);
            }
            int range = Random.Range(8, -8);
            item.transform.position = new Vector3(range, 5, 0);
            //GameObject copySquare = Instantiate(�����簢��) as GameObject;
            //int range = Random.Range(9, -9);
            //item.transform.position = new Vector3(range, 5, 0);
        }
    }
}
