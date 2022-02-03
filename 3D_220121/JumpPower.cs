using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpPower : MonoBehaviour
{
    public float power = 5.0f;
    
    void Update()
    {
        
      
        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, power, 0);
        }
        //GetComponent<AudioSource>().Play();
    }
    void OnCollisionEnter(Collision other)//Enter(순간),Stay(지속적),Eixt(벗어났을때)
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("GameScene");
    }
}
