using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Points : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Next;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

     void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Finish")
        {
            print("Trigger Detected");
            AI_Player.Next=this.Next;
            
        }
     }
}
