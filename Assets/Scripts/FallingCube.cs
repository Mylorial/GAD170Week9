using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
    
        
        if(collision.gameObject.tag == "Player"){
        
        Destroy(collision.gameObject, 1);
        print("Ouchy I'm DEAD");
        }
    
    }
}
