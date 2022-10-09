using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,Time.deltaTime*3f);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-Time.deltaTime*3f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime*3f,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime*3f,0,0);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="barrier")
         {
            
            Time.timeScale=0;
            GameManager.instance.GameOver();
        }

        if(other.gameObject.tag=="Finish")
         {
            
            Time.timeScale=0;
            GameManager.instance.GameWon();
   
        }
    }

    
 }

