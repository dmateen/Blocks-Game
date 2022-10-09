using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static Transform Next;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 OwnPosition=transform.position;
            Vector3 TargetPosition=Next.position;
            print(TargetPosition);
            transform.position = Vector3.MoveTowards(OwnPosition, TargetPosition, 5f*Time.deltaTime);
        
    }
    
    
    
}
